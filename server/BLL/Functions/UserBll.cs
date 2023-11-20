using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using DTO.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Converters;
namespace BLL.Functions
{
    public class UserBll : IUserBll
    {
        IUserDal userDal;

        public UserBll(IUserDal _userDal)
        {
            userDal = _userDal;
        }
        public UserDto Add(UserDto user)
        {
            User u = userDal.Add(UserConverter.ConvertUserDtoToUser(user));
            return UserConverter.ConvertUserToUserDto(u);
        }

        public List<UserDto> GetAll()
        {
            return UserConverter.ConvertUserListToUserDtoList(userDal.GetAll());
        }

        public UserDto GetById(int id)
        {
            return UserConverter.ConvertUserToUserDto(userDal.GetById(id));
        }

        public UserDto GetByMailAndPassword(string mail, string password)
        {
            User u=userDal.GetByMailAndPassword(mail, password);
            if(u != null)
                return UserConverter.ConvertUserToUserDto(u);
            return null;
        }
    }
}
