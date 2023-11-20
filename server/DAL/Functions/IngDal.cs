using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Functions
{

    public class IngDal: IIngDal
    {
        RecipesContext db;

        public IngDal(RecipesContext db)
        {
            this.db = db;

        }

        public Ing Add(Ing ing)
        {
            db.Ings.Add(ing);
            db.SaveChanges();
            Ing i= db.Ings.FirstOrDefault(i => i.IngName == ing.IngName);
            return i;
        }
        public List<Ing> GetAll()
        {
            return db.Ings.ToList();
        }

        public Ing GetById(int id)
        {
            return db.Ings.Find(id);
        }

        
    }
}
