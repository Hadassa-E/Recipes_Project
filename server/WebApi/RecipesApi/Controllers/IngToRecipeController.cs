using BLL.Interfaces;
using DTO.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RecipesApi.Controllers
{ 
    [ApiController]
    [Route("api/[controller]")]
    public class IngToRecipeController : ControllerBase
    {
        IIngToRecipeBll ingToRecipeBll;
        public IngToRecipeController(IIngToRecipeBll ingToRecipeBll)
        {
            this.ingToRecipeBll=ingToRecipeBll;
        }
        [HttpGet("GetAll")]
        public ActionResult<List<IngToRecipeDto>> GetAll()
        {
            return ingToRecipeBll.GetAll();
        }
        [HttpGet("GetByRecipeId/{id}")]
        public ActionResult<List<IngToRecipeDto>> GetByRecipeId(int id)
        {
            return ingToRecipeBll.GetByRecipeId(id);
        }
        [HttpPost("Add/{recipeId}")]
        public ActionResult<List<IngToRecipeDto>> Add(int recipeId,[FromBody] List<IngToRecipeDto> ingsToAddToRecipe)
        {
            return ingToRecipeBll.Add(recipeId,ingsToAddToRecipe);
        }
    }
}
