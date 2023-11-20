using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Functions
{
    public class RecipeDal:IRecipeDal
    {
        RecipesContext db;

        public RecipeDal(RecipesContext db)
        {
            this.db = db;

        }

        public List<Recipe> GetAll()
        {
            return db.Recipes.ToList();
        }
        public List<Recipe> Delete(int id)
        {
            db.Recipes.Remove(GetById(id));
            db.SaveChanges();
            return db.Recipes.ToList();
        }

        public Recipe GetById(int id)
        {
            return db.Recipes.Find(id);
        }

        public Recipe Add(Recipe recipe)
        {
            db.Recipes.Add(recipe);
            db.SaveChanges();
            return db.Recipes.FirstOrDefault(r => r.RecipeName == recipe.RecipeName);
        }
        public Recipe Update(int id, Recipe recipe)
        {
            Recipe rcp = db.Recipes.Find(id);
            if (rcp != null)
            {
              
                rcp.RecipeName = recipe.RecipeName;
                rcp.Time=recipe.Time;
                rcp.UserId = recipe.UserId;
                rcp.Level = recipe.Level;
                rcp.Pic=recipe.Pic;
            
            }
            db.SaveChanges();
            return rcp;
        }

    }
}
