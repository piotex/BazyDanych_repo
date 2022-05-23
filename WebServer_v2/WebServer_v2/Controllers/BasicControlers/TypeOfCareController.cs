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
    public class TypeOfCareController : ControllerBase
    {
        public TypeOfCareController()
        {
        }

        [HttpGet]
        public List<TypeOfCare> Get()
        {
            if (ApplicationVersion.IsTestVersion())
            {
                return MoqTypeOfCareList.GetInstance().GetMoqList();
            }
            return new SelectQuery().Select<TypeOfCare>();
        }

        [HttpGet("{id}")]
        public TypeOfCare GetActualTask(int id)
        {
            if (ApplicationVersion.IsTestVersion())
            {
                return MoqTypeOfCareList.GetInstance().GetMoqList().Where(x => x.TYPEOFCAREID == id).First();
            }
            return new SelectQuery().Select<TypeOfCare>(id);
        }

        [HttpPost]
        public void Post(TypeOfCare company)
        {
            if (ApplicationVersion.IsTestVersion())
            {
                MoqTypeOfCareList.GetInstance().PushToMoqList(company);
            }
            else
            {
                new InsertQuery().Insert(company);
            }
        }
    }
}
