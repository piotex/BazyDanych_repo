using Microsoft.AspNetCore.Mvc;
using PlantsDatabaseControler;
using PlantsDatabaseControler.MoqModels;
using PlantsDatabaseControler.SqlCommands;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebServer_v2.Controllers.AdvancedControlers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActualTaskDedicController : ControllerBase
    {
        public ActualTaskDedicController()
        {
        }

        [HttpGet]
        public List<ActualTaskImportantData> Get()
        {
            if (ApplicationVersion.IsTestVersion())
            {
                List<ActualTaskImportantData> ret = new List<ActualTaskImportantData>();
                
                List<ActualTask> ActualTaskList = MoqActualTaskList.GetInstance().GetMoqList();
                List<Palet> PaletsList = MoqPaletList.GetInstance().GetMoqList();
                List<PaletPlantsType> PaletPlantsTypeList = MoqPaletPlantsTypeList.GetInstance().GetMoqList();
                List<CareSchedule> CareScheduleList = MoqCareScheduleList.GetInstance().GetMoqList();
                List<TypeOfCare> TypeOfCareList = MoqTypeOfCareList.GetInstance().GetMoqList();

                // ----------------------------------------------------------------------------------do poprawy joinowanie-----------------------------------------------------------
                foreach (ActualTask actualTask in ActualTaskList)
                {
                    ActualTaskImportantData tmp = new ActualTaskImportantData();
                    tmp.ACTUALTASKID = actualTask.ACTUALTASKID;
                    tmp.USERID = actualTask.USERID;
                    tmp.REALIZATIONDATE = actualTask.REALIZATIONDATE;

                    foreach (Palet palet in PaletsList)
                    {
                        if (actualTask.PALETID == palet.PALETID)
                        {
                            tmp.DATEOFPLANTING = palet.DATEOFPLANTING;
                            tmp.PALETID = palet.PALETNUMBER;
                            foreach (PaletPlantsType paletPlantsType in PaletPlantsTypeList)
                            {
                                if (palet.PALETPLANTSTYPEID == paletPlantsType.PALETPLANTSTYPEID)
                                {
                                    tmp.PALETPLANTSTYPENAME = paletPlantsType.PALETPLANTSTYPENAME;
                                }
                            }
                        }
                    }
                    foreach (CareSchedule careSchedule in CareScheduleList)
                    {
                        if (actualTask.CARESCHEDULEID == careSchedule.CARESCHEDULEID)
                        {
                            tmp.PRIORITYNUMBER = careSchedule.PRIORITYNUMBER;
                            tmp.TIMEOFCARE = careSchedule.TIMEOFCARE;
                            foreach (TypeOfCare typeOfCare in TypeOfCareList)
                            {
                                if (typeOfCare.TYPEOFCAREID == careSchedule.TYPEOFCAREID)
                                {
                                    tmp.TYPEOFCARENAME = typeOfCare.TYPEOFCARENAME;
                                }
                            }
                        }
                    }
                    if (
                        tmp.DATEOFPLANTING != new DateTime() &&
                        tmp.PALETPLANTSTYPENAME != null &&
                        tmp.TIMEOFCARE != 0 &&
                        tmp.TYPEOFCARENAME != null
                        )
                    {
                        ret.Add(tmp);
                    }
                }
                
                return ret;
            }
            else
            {
                return new ProcedureQuery().SelectActualTasksProcedureImportantData();
            }
        }

        private void conv_to_ActualTaskDedic_List()
        {

        }

        [HttpPut]
        public async Task<IActionResult> Update(int userId, int actualTaskId)
        {
            if (ApplicationVersion.IsTestVersion())
            {
                List<ActualTask> list = MoqActualTaskList.GetInstance().GetMoqList();
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].ACTUALTASKID == actualTaskId)
                    {
                        list[i].REALIZATIONDATE = DateTime.Now;
                        list[i].USERID = userId;
                    }
                }
            }
            else
            {
                new ProcedureQuery().UpdateActualTaskProcedure(userId, actualTaskId);
            }
            return NoContent();
        }
    }
}
