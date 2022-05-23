using Microsoft.AspNetCore.Mvc;
using PlantsDatabaseControler;
using PlantsDatabaseControler.MoqModels;
using PlantsDatabaseControler.SqlCommands;
using System.Collections.Generic;
using System.Linq;
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
                return MoqCareScheduleList.GetInstance().GetMoqList();
            }
            return new SelectQuery().Select<CareSchedule>();
        }

        [HttpGet("{id}")]
        public CareSchedule GetActualTask(int id)
        {
            if (ApplicationVersion.IsTestVersion())
            {
                return MoqCareScheduleList.GetInstance().GetMoqList().Where(x => x.CARESCHEDULEID == id).First();
            }
            return new SelectQuery().Select<CareSchedule>(id);
        }

        [HttpPost]
        public void Post(CareSchedule company)
        {
            if (ApplicationVersion.IsTestVersion())
            {
                MoqCareScheduleList.GetInstance().PushToMoqList(company);
            }
            else
            {
                new InsertQuery().Insert(company);
            }
        }
    }
}
