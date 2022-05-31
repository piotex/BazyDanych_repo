using Microsoft.AspNetCore.Mvc;
using PlantsDatabaseControler;
using PlantsDatabaseControler.MoqModels;
using PlantsDatabaseControler.SqlCommands;
using System;
using System.Collections.Generic;
using System.Linq;
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
                        if (actualTask.PALETID == palet.PALETNUMBER)
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

        [HttpPut]
        public void Update(int userId, int actualTaskId)                                        //zmienia userId i RealizationDate - wywoluje procedure
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
        }
        [HttpPut("{id}")]   
        public void UpdateUserId(int userId, int actualTaskId)                                  //zmienia tylko UserId
        {
            if (ApplicationVersion.IsTestVersion())
            {
                List<ActualTask> list = MoqActualTaskList.GetInstance().GetMoqList();
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].ACTUALTASKID == actualTaskId)
                    {
                        list[i].USERID = userId;
                    }
                }
            }
            else
            {
                ActualTask model = new ActualTask() { USERID = userId, ACTUALTASKID = actualTaskId };
                new UpdateQuery().Update(model);
            }
        }

        [HttpPost]
        public void Post(int paletNumber, int paletPlantsTypeId)
        {
            if (ApplicationVersion.IsTestVersion())
            {
                int maxPaletIdx = MoqPaletList.GetInstance().GetMoqList().Max(x => x.PALETID);
                int maxActualTaskIdx = MoqActualTaskList.GetInstance().GetMoqList().Max(x => x.ACTUALTASKID);

                List<CareSchedule> collection = MoqCareScheduleList.GetInstance().GetMoqList().Where(x => x.PALETPLANTSTYPEID == paletPlantsTypeId).ToList();
                foreach (var item in collection)
                {
                    ActualTask model = new ActualTask()
                    {
                        ACTUALTASKID = maxActualTaskIdx+1,
                        CARESCHEDULEID = item.CARESCHEDULEID,
                        PALETID = paletNumber,
                        REALIZATIONDATE = null,
                        USERID = null
                    };
                    MoqActualTaskList.GetInstance().PushToMoqList(model);
                    maxActualTaskIdx++;
                }
                Palet palet = new Palet()
                {
                    DATEOFPLANTING = DateTime.Now,
                    PALETID = maxPaletIdx + 1,
                    PALETNUMBER = paletNumber,
                    PALETPLANTSTYPEID = paletPlantsTypeId
                };
                MoqPaletList.GetInstance().PushToMoqList(palet);
            }
            else
            {
                new ProcedureQuery().AddActualTasksProcedure(paletNumber, paletPlantsTypeId);
            }
        }
    }
}
