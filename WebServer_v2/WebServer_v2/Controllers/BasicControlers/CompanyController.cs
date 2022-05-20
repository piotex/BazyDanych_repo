using Microsoft.AspNetCore.Mvc;
using PlantsDatabaseControler;
using PlantsDatabaseControler.SqlCommands;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebServer_v2;

namespace WebAppServer.Controllers.DbBasicControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        public CompanyController()
        {
        }

        [HttpGet]
        public List<Company> Get()
        {
            if (ApplicationVersion.IsTestVersion())
            {
                //return MoqActualTaskList.GetInstance().GetMoqList();
            }
            return new SelectQuery().Select<Company>();
        }

        [HttpGet("{id}")]
        public Company GetActualTask(int id)
        {
            if (ApplicationVersion.IsTestVersion())
            {
                //return MoqActualTaskList.GetInstance().GetMoqList();
            }
            return new SelectQuery().Select<Company>(id);
        }

        [HttpPost]
        public void Post(Company company)
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
