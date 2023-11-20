using DAL.Models;
using DTO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Converters
{
    public class IngConverter
    {
        public static Ing ConvertIngDtoToIng(IngDto ing)
        {
            Ing i = new Ing()
            {
                IngId = ing.IngId,
                IngName = ing.IngName,
            };
            return i;
        }
        public static List<Ing> ConvertIngDtoListToIngList(List<IngDto> listIng)
        {
            List<Ing> list = new List<Ing>();
            foreach (var item in listIng)
            {
                list.Add(ConvertIngDtoToIng(item));
            }
            return list;
        }

        public static IngDto ConvertIngToIngDto(Ing ing)
        {
            IngDto i = new IngDto()
            {
                IngId = ing.IngId,
                IngName = ing.IngName,
            };
            return i;
        }
        public static List<IngDto> ConvertIngListDtoToIngList(List<Ing> listIng)
        {
            List<IngDto> list = new List<IngDto>();
            foreach (var item in listIng)
            {
                list.Add(ConvertIngToIngDto(item));
            }
            return list;
        }

    }
}
