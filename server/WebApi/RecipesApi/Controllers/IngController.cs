using BLL.Interfaces;
using DTO.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace RecipesApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IngController : ControllerBase
    {
        IIngBll ingBll;
        public IngController(IIngBll ingBll)
        {
            this.ingBll = ingBll;
        }
        [HttpGet("GetAll")]
        public ActionResult<List<IngDto>> GetAll() {
            return ingBll.GetAll();
        }
        [HttpGet("GetById/{id}")]
        public ActionResult<IngDto> GetById(int id)
        {
            return ingBll.GetById(id);
        }
        [HttpPost]
        [Route("Add")]
        public IngDto Add([FromBody]IngDto ing)
        {
            return ingBll.Add(ing);
        }
    }
}
