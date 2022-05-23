using Microsoft.AspNetCore.Mvc;
using PlantsDatabaseControler;
using PlantsDatabaseControler.MoqModels;
using PlantsDatabaseControler.SqlCommands;
using System.Collections.Generic;
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
        public int LogIn(LoginModel login)                           //returns role_id
        {
            List<Users> tmp = new List<Users>();
            if (ApplicationVersion.IsTestVersion()){
                tmp = MoqUsersList.GetInstance().GetMoqList();
            }
            else{
                tmp = new SelectQuery().Select<Users>();
            }

            //-------------------------------------------------------------poprawic
            foreach (var item in tmp)
            {
                if (item.MAIL == login.Login){
                    return item.USERCATEGORYID;
                }
            }
            return -1;
        }
    }
}
