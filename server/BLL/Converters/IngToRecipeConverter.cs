using BLL.Functions;
using DAL.Models;
using DAL.Interfaces;

using DTO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;

namespace BLL.Converters
{
    public class IngToRecipeConverter
    {
        static IRecipeDal recipeDal;
        public IngToRecipeConverter(IRecipeDal _recipeDal)
        {
            recipeDal = _recipeDal;
        }

        public static IngToRecipe ConvertIngToRecipeDtoToIngToRecipe(IngToRecipeDto ingre)
        {
            IngToRecipe itr = new IngToRecipe()
            {
                Id = ingre.Id,
                IngId = ingre.IngId,
                RecipeId = ingre.RecipeId,
                Quantity = ingre.Quantity
            };
            return itr;
        }
        public static List<IngToRecipe> ConvertIngToRecipeDtoListToIngToRecipeList(List<IngToRecipeDto> ListIngre)
        {
            List<IngToRecipe> list = new List<IngToRecipe>();
            foreach (var ingre in ListIngre)
            {
                list.Add(ConvertIngToRecipeDtoToIngToRecipe(ingre));
            }
            return list;
        }
        public static IngToRecipeDto ConvertIngToRecipeToIngToRecipeDto(IngToRecipe ingre)
        {
            IngToRecipeDto itr = new IngToRecipeDto()
            {
                Id = ingre.Id,
                IngId = ingre.IngId,
                RecipeId = ingre.RecipeId,
                Quantity = ingre.Quantity,
                //RecipeName = recipeDal.GetById(ingre.RecipeId).RecipeName
            };
            return itr;
        }
        public static List<IngToRecipeDto> ConvertIngToRecipeListToIngToRecipeListDto(List<IngToRecipe> ListIngre)
        {
            List<IngToRecipeDto> list = new List<IngToRecipeDto>();
            foreach (var ingre in ListIngre)
            {
                list.Add(ConvertIngToRecipeToIngToRecipeDto(ingre));
            }
            return list;
        }
    }
}
