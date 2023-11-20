using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
namespace DAL.Interfaces
{
    public interface IIngToRecipeDal
    {
        public List<IngToRecipe> GetAll();

        public List<IngToRecipe> GetByRecipeId(int RecipeId);
        public List<IngToRecipe> Add(int recipeId,List<IngToRecipe> ingsToAddToRecipe);
    }
}
