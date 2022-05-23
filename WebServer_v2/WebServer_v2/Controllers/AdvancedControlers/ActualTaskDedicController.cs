using Microsoft.AspNetCore.Mvc;
using PlantsDatabaseControler;
using PlantsDatabaseControler.SqlCommands;
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
                /*
                List<ActualTask> ActualTaskList = MoqActualTaskList.GetInstance().GetMoqList();
                List<Palet> PaletsList = MoqPaletList.GetInstance().GetMoqList();
                List<PaletPlantsType> PaletPlantsTypeList = MoqPaletPlantsTypeList.GetInstance().GetMoqList();
                List<CareSchedule> CareScheduleList = MoqCareScheduleList.GetInstance().GetMoqList();
                List<TypeOfCare> TypeOfCareList = MoqTypeOfCareList.GetInstance().GetMoqList();

                // ----------------------------------------------------------------------------------do poprawy joinowanie-----------------------------------------------------------
                foreach (ActualTask actualTask in ActualTaskList)
                {
                    ActualTaskDedic tmp = new ActualTaskDedic();
                    tmp.ActualTaskId = actualTask.ActualTaskId;
                    tmp.User_Id = actualTask.User_Id;
                    tmp.RealizationDate = actualTask.RealizationDate;

                    foreach (Palet palet in PaletsList)
                    {
                        if (actualTask.Palet_Id == palet.PaletId)
                        {
                            tmp.DateOfPlanting = palet.DateOfPlanting;
                            tmp.PaletNumber = palet.PaletNumber;
                            foreach (PaletPlantsType paletPlantsType in PaletPlantsTypeList)
                            {
                                if (palet.PaletPlantsType_Id == paletPlantsType.PaletPlantsTypeId)
                                {
                                    tmp.PaletPlantsTypeName = paletPlantsType.PaletPlantsTypeName;
                                }
                            }
                        }
                    }
                    foreach (CareSchedule careSchedule in CareScheduleList)
                    {
                        if (actualTask.CareSchedule_Id == careSchedule.CareScheduleId)
                        {
                            tmp.PriorityNumber = careSchedule.PriorityNumber;
                            tmp.TimeOfCare = careSchedule.TimeOfCare;
                            foreach (TypeOfCare typeOfCare in TypeOfCareList)
                            {
                                if (typeOfCare.TypeOfCareId == careSchedule.TypeOfCare_Id)
                                {
                                    tmp.TypeOfCareName = typeOfCare.TypeOfCareName;
                                }
                            }
                        }
                    }
                    if (
                        tmp.DateOfPlanting != new DateTime() &&
                        tmp.PaletPlantsTypeName != null &&
                        tmp.TimeOfCare != new DateTime() &&
                        tmp.TypeOfCareName != null
                        )
                    {
                        ret.Add(tmp);
                    }
                }
                */
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

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int userId, int actualTaskId)
        {
            if (ApplicationVersion.IsTestVersion())
            {
                /*
                List<ActualTask> list = MoqActualTaskList.GetInstance().GetMoqList();
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].ActualTaskId == actualTask.ActualTaskId)
                    {
                        //list[i].CareSchedule_Id = actualTask.CareSchedule_Id ;
                        //list[i].Palet_Id = actualTask.Palet_Id ;
                        list[i].RealizationDate = actualTask.RealizationDate;
                        list[i].User_Id = actualTask.User_Id;
                    }
                }
                */
            }
            else
            {
                new ProcedureQuery().UpdateActualTaskProcedure(userId, actualTaskId);
            }
            return NoContent();
        }
    }
}
