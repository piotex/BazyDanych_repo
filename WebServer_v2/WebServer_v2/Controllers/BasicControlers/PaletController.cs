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
    public class PaletController : ControllerBase
    {
        public PaletController()
        {
        }

        [HttpGet]
        public List<Palet> Get()
        {
            if (ApplicationVersion.IsTestVersion())
            {
                return MoqPaletList.GetInstance().GetMoqList();
            }
            return new SelectQuery().Select<Palet>();
        }

        [HttpGet("{id}")]
        public Palet GetActualTask(int id)
        {
            if (ApplicationVersion.IsTestVersion())
            {
                return MoqPaletList.GetInstance().GetMoqList().Where(x => x.PALETID == id).First();
            }
            return new SelectQuery().Select<Palet>(id);
        }

        [HttpPost]
        public void Post(Palet company)
        {
            if (ApplicationVersion.IsTestVersion())
            {
                MoqPaletList.GetInstance().PushToMoqList(company);
            }
            else
            {
                new InsertQuery().Insert(company);
            }
        }
    }
}
