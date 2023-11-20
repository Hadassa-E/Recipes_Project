using DTO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IIngBll
    {
        public List<IngDto> GetAll();
        public IngDto GetById(int id);
        public IngDto Add(IngDto ing);
    }
}
