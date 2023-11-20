using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Classes;

namespace BLL.Interfaces
{
    public interface IUserBll
    {
        List<UserDto> GetAll();
        UserDto GetById(int id);

        UserDto GetByMailAndPassword(string mail, string password);
        UserDto Add(UserDto user);
    }
}
