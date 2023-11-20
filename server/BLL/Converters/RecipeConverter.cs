using DAL.Models;
using DTO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Converters
{
    public class RecipeConverter
    {

        public static Recipe ConvertRecipeDtoToRecipe(RecipeDto recipe)
        {
            Recipe recipe1 = new Recipe()
            {
                RecipeId = recipe.RecipeId,
                RecipeName = recipe.RecipeName,
                Level = recipe.Level,
                Pic = recipe.Pic,
                Time = recipe.Time,
                UserId = recipe.UserId,

            };
            return recipe1;
        }
        public static List<Recipe> ConvertRecipeDtoListToRecipeList(List<RecipeDto> recipeList)
        {
            List<Recipe> list = new List<Recipe>();
            foreach (RecipeDto recipe in recipeList)
            {
                list.Add(ConvertRecipeDtoToRecipe(recipe));
            }
            return list;
        }
        public static RecipeDto ConvertRecipeToRecipeDto(Recipe recipe)
        {
            RecipeDto recipe1 = new RecipeDto()
            {
                RecipeId = recipe.RecipeId,
                RecipeName = recipe.RecipeName,
                Level = recipe.Level,
                Pic = recipe.Pic,
                Time = recipe.Time,
                UserId = recipe.UserId,
            };
            return recipe1;
        }
        public static List<RecipeDto> ConvertRecipeListToRecipeDtoList(List<Recipe> recipeList)
        {
            List<RecipeDto> list = new List<RecipeDto>();
            foreach (Recipe recipe in recipeList)
            {
                list.Add(ConvertRecipeToRecipeDto(recipe));
            }
            return list;
        }
    }
}
