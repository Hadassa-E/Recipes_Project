using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using DTO.Classes;
using BLL.Converters;
namespace BLL.Functions
{
    public class IngToRecipeBll : IIngToRecipeBll
    {
        IIngToRecipeDal ingToRecipeDal;

        public IngToRecipeBll(IIngToRecipeDal _ingTORecipeDal)
        {
            ingToRecipeDal = _ingTORecipeDal;

        }


        public List<IngToRecipeDto> Add(int recipeId, List<IngToRecipeDto> ingsToAddToRecipe)
        {
            return IngToRecipeConverter.ConvertIngToRecipeListToIngToRecipeListDto(ingToRecipeDal.Add(recipeId, IngToRecipeConverter.ConvertIngToRecipeDtoListToIngToRecipeList(ingsToAddToRecipe)));
        }
        List<IngToRecipeDto> IIngToRecipeBll.GetAll()
        {
            return IngToRecipeConverter.ConvertIngToRecipeListToIngToRecipeListDto(ingToRecipeDal.GetAll());
        }

        List<IngToRecipeDto> IIngToRecipeBll.GetByRecipeId(int recipeId)
        {
            return IngToRecipeConverter.ConvertIngToRecipeListToIngToRecipeListDto(ingToRecipeDal.GetByRecipeId(recipeId));
        }
    }


}
