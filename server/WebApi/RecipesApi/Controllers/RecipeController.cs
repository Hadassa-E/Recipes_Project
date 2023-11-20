using BLL.Interfaces;
using DTO.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RecipesApi.Controllers
{  
    [ApiController]
    [Route("api/[controller]")]
    public class RecipeController : ControllerBase
    {
        IRecipeBll recipeBll;
        public RecipeController(IRecipeBll recipeBll)
        {
            this.recipeBll = recipeBll;
        }
        [HttpGet]
        [Route("GetAll")]
        public ActionResult<List<RecipeDto>> GetAll()
        {
            return recipeBll.GetAll();
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public ActionResult<RecipeDto> GeGetByIdtAll(int id)
        {
            return recipeBll.GetById(id);
        }
        [HttpPost]
        [Route("Add")]
        public ActionResult<RecipeDto> Add([FromBody] RecipeDto recipe)
        {
            return recipeBll.Add(recipe);
        }
        [HttpDelete]
        [Route("Delete")]
        public ActionResult<List<RecipeDto>> Delete(int id) {
            return recipeBll.Delete(id);
        }
        [HttpPatch]
        [Route("Update/{id}")]
        public ActionResult<RecipeDto> Update(int id, [FromBody] RecipeDto recipe)
        {
            return recipeBll.Update(id, recipe);
        }
    }
}
