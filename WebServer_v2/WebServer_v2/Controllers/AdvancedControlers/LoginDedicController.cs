using Microsoft.AspNetCore.Mvc;
using PlantsDatabaseControler;
using PlantsDatabaseControler.MoqModels;
using PlantsDatabaseControler.SqlCommands;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServer_v2.Models;

namespace WebServer_v2.Controllers.AdvancedControlers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginDedicController : ControllerBase
    {
        public LoginDedicController()
        {
        }

        [HttpPost]
        public Users LogIn(Users user)                        
        {
            if (ApplicationVersion.IsTestVersion()){
                return MoqUsersList.GetInstance().GetMoqList().Where(x => x.MAIL == user.MAIL).FirstOrDefault();
            }
            else{
                return new SelectQuery().Select<Users>().Where(x => x.MAIL == user.MAIL).First();
            }
        }
    }
}
