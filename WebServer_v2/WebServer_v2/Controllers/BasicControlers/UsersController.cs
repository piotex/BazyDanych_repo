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
    public class UsersController : ControllerBase
    {
        public UsersController()
        {
        }

        [HttpGet]
        public List<Users> Get()
        {
            if (ApplicationVersion.IsTestVersion())
            {
                return MoqUsersList.GetInstance().GetMoqList();
            }
            return new SelectQuery().Select<Users>();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Users>> GetActualTask(int id)
        {
            if (ApplicationVersion.IsTestVersion())
            {
                return MoqUsersList.GetInstance().GetMoqList().Where(x => x.USERSID == id).First();
            }
            return new SelectQuery().Select<Users>(id);
        }

        [HttpPost]
        public void Post(Users company)
        {
            if (ApplicationVersion.IsTestVersion())
            {
                MoqUsersList.GetInstance().PushToMoqList(company);
            }
            else
            {
                new InsertQuery().Insert(company);
            }
        }
    }
}
