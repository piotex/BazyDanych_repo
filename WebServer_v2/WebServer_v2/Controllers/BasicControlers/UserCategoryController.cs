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
    public class UserCategoryController : ControllerBase
    {
        public UserCategoryController()
        {
        }

        [HttpGet]
        public List<UserCategory> Get()
        {
            if (ApplicationVersion.IsTestVersion())
            {
                return MoqUserCategoryList.GetInstance().GetMoqList();
            }
            return new SelectQuery().Select<UserCategory>();
        }

        [HttpGet("{id}")]
        public UserCategory GetActualTask(int id)
        {
            if (ApplicationVersion.IsTestVersion())
            {
                return MoqUserCategoryList.GetInstance().GetMoqList().Where(x => x.USERCATEGORYID == id).First();
            }
            return new SelectQuery().Select<UserCategory>(id);
        }

        [HttpPost]
        public void Post(UserCategory company)
        {
            if (ApplicationVersion.IsTestVersion())
            {
                MoqUserCategoryList.GetInstance().PushToMoqList(company);
            }
            else
            {
                new InsertQuery().Insert(company);
            }
        }
    }
}
