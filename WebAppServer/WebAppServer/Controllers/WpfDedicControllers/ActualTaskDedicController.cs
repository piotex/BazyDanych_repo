﻿using DedicModels_Library;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppServer.Contexts;
using WebAppServer.Models;
using WebAppServer.MoqModels;
using WebAppServer.SingletonsFlags;

namespace WebAppServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActualTaskDedicController : ControllerBase
    {
        private readonly OracleDbContext _dataContext;
        public ActualTaskDedicController(OracleDbContext dbContext)
        {
            _dataContext = dbContext;
        }

        [HttpGet]
        public List<ActualTaskDedic> Get()
        {
            if (ApplicationVersion.IsTestVersion())
            {
                List<ActualTaskDedic> ret = new List<ActualTaskDedic>();

                List<ActualTask> ActualTaskList = new MoqActualTaskList().GetMoqList();
                List<Palet> PaletsList = new MoqPaletList().GetMoqList();
                List<PaletPlantsType> PaletPlantsTypeList = new MoqPaletPlantsTypeList().GetMoqList();
                List<CareSchedule> CareScheduleList = new MoqCareScheduleList().GetMoqList();
                List<TypeOfCare> TypeOfCareList = new MoqTypeOfCareList().GetMoqList();

                // ----------------------------------------------------------------------------------do poprawy joinowanie-----------------------------------------------------------
                foreach (ActualTask actualTask in ActualTaskList)
                {
                    ActualTaskDedic tmp = new ActualTaskDedic();
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
                    ret.Add(tmp);
                }

                return ret;
            }
            //return _dataContext.ActualTask.ToList();
            throw new NotImplementedException("ActualTaskDedicController -> Get()");
        }
    }
}
