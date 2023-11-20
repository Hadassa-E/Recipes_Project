using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using DTO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Converters;
namespace BLL.Functions
{

    public class IngBll : IIngBll
    {
        IIngDal ingDal;

        public IngBll(IIngDal _ingDal)
        {
            ingDal = _ingDal;

        }



        public IngDto Add(IngDto ing)
        {
            Ing ingD = ingDal.Add(IngConverter.ConvertIngDtoToIng(ing));
            return IngConverter.ConvertIngToIngDto(ingD);
        }



        public IngDto GetById(int id)
        {
            return IngConverter.ConvertIngToIngDto(ingDal.GetById(id));
        }

        public List<IngDto> GetAll()
        {
            return IngConverter.ConvertIngListDtoToIngList(ingDal.GetAll());
        }


    }
}
