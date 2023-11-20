using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using DAL.Interfaces;
using BLL.Interfaces;
using DTO.Classes;
using BLL.Converters;
namespace BLL.Functions
{
    public class RecipeBll : IRecipeBll
    {
        IRecipeDal recipeDal;
        public RecipeBll(IRecipeDal _recipeDal)
        {
            recipeDal = _recipeDal;
        }
        public RecipeDto Add(RecipeDto recipe)
        {
            return RecipeConverter.ConvertRecipeToRecipeDto(recipeDal.Add(RecipeConverter.ConvertRecipeDtoToRecipe(recipe)));
        }

        public List<RecipeDto> GetAll()
        {
            return RecipeConverter.ConvertRecipeListToRecipeDtoList(recipeDal.GetAll());
        }

        public RecipeDto GetById(int id)
        {
            return RecipeConverter.ConvertRecipeToRecipeDto(recipeDal.GetById(id));
        }
        public List<RecipeDto> Delete(int id)
        {
            return RecipeConverter.ConvertRecipeListToRecipeDtoList(recipeDal.Delete(id));
        }
        public RecipeDto Update(int id, RecipeDto recipe)
        {
            return RecipeConverter.ConvertRecipeToRecipeDto(recipeDal.Update(id, RecipeConverter.ConvertRecipeDtoToRecipe(recipe)));
        }

    }
}
