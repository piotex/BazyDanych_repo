using Microsoft.AspNetCore.Mvc;
using PlantsDatabaseControler;
using PlantsDatabaseControler.SqlCommands;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebServer_v2.Controllers.BasicControlers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CareScheduleController : ControllerBase
    {
        public CareScheduleController()
        {
        }

        [HttpGet]
        public List<CareSchedule> Get()
        {
            if (ApplicationVersion.IsTestVersion())
            {
                //return MoqActualTaskList.GetInstance().GetMoqList();
            }
            return new SelectQuery().Select<CareSchedule>();
        }

        [HttpGet("{id}")]
        public CareSchedule GetActualTask(int id)
        {
            if (ApplicationVersion.IsTestVersion())
            {
                //return MoqActualTaskList.GetInstance().GetMoqList();
            }
            return new SelectQuery().Select<CareSchedule>(id);
        }

        [HttpPost]
        public void Post(CareSchedule company)
        {
            if (ApplicationVersion.IsTestVersion())
            {
                //MoqActualTaskList.GetInstance().PushToMoqList(company);
            }
            else
            {
                new InsertQuery().Insert(company);
            }
        }
    }
}
