using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
namespace DAL.Interfaces
{
    public interface IRecipeDal
    {
        public List<Recipe> GetAll();
        public List<Recipe> Delete(int id);
        public Recipe GetById(int id);
        public Recipe Add(Recipe recipe);
        public Recipe Update(int id,Recipe recipe);
    }
}
