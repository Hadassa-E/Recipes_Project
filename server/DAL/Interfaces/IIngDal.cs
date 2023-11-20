using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IIngDal
    {
        public List<Ing> GetAll();
        public Ing GetById(int id);
        public Ing Add(Ing ing);
    }
}
