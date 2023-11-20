using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Functions
{
    public class IngToRecipeDal : IIngToRecipeDal
    {
        RecipesContext db;

        public IngToRecipeDal(RecipesContext db)
        {
            this.db = db;

        }
        public List<IngToRecipe> Add(int recipeId, List<IngToRecipe> ingsToAddToRecipe)
        {
           foreach(IngToRecipe itr in ingsToAddToRecipe)
            {
                db.IngToRecipes.Add(itr);
                
            }
            db.SaveChanges();
            return db.IngToRecipes.Where(itr=>itr.RecipeId == recipeId).ToList();
        }

        public List<IngToRecipe> GetAll()
        {
            return db.IngToRecipes.ToList();
        }

        public List<IngToRecipe> GetByRecipeId(int RecipeId)
        {
            return db.IngToRecipes.Where(itr=>itr.RecipeId==RecipeId).ToList();
        }
    }
}
