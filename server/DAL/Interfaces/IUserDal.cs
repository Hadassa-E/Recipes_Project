using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Interfaces
{
    public interface IUserDal
    {
        public List<User> GetAll();
        public User GetById(int id);

        public User GetByMailAndPassword(string mail,string password);
        public User Add(User user);
    }
}
