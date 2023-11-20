using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Functions
{
    public class UserDal : IUserDal
    {
        RecipesContext db;
        public UserDal(RecipesContext db)
        {
            this.db = db;
            
        }
        public User Add(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return db.Users.FirstOrDefault(u => u.FirstName == user.FirstName && u.LastName == user.LastName);
        }

        public List<User> GetAll()
        {
            return db.Users.ToList();
        }

        public User GetById(int id)
        {
            return db.Users.Find(id);
        }

        public User GetByMailAndPassword(string mail, string password)
        {
            return db.Users.FirstOrDefault((user) => user.Password == password && user.Email == mail);
        } 
    }
}
