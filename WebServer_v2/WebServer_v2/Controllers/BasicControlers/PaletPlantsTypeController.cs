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
    public class PaletPlantsTypeController : ControllerBase
    {
        public PaletPlantsTypeController()
        {
        }

        [HttpGet]
        public List<PaletPlantsType> Get()
        {
            if (ApplicationVersion.IsTestVersion())
            {
                return MoqPaletPlantsTypeList.GetInstance().GetMoqList();
            }
            return new SelectQuery().Select<PaletPlantsType>();
        }

        [HttpGet("{id}")]
        public PaletPlantsType GetActualTask(int id)
        {
            if (ApplicationVersion.IsTestVersion())
            {
                return MoqPaletPlantsTypeList.GetInstance().GetMoqList().Where(x => x.PALETPLANTSTYPEID == id).First();
            }
            return new SelectQuery().Select<PaletPlantsType>(id);
        }

        [HttpPost]
        public void Post(PaletPlantsType company)
        {
            if (ApplicationVersion.IsTestVersion())
            {
                MoqPaletPlantsTypeList.GetInstance().PushToMoqList(company);
            }
            else
            {
                new InsertQuery().Insert(company);
            }
        }
    }
}
