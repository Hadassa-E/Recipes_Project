
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Classes;
namespace BLL.Interfaces
{
    public interface IIngToRecipeBll
    {

        public List<IngToRecipeDto> GetAll();

        public List<IngToRecipeDto> GetByRecipeId(int RecipeId);
        public List<IngToRecipeDto> Add(int recipeId, List<IngToRecipeDto> ingsToAddToRecipe);
    }
}
