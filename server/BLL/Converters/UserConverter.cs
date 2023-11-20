using DAL.Models;
using DTO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Converters
{
    public class UserConverter
    {
        public static User ConvertUserDtoToUser(UserDto user)
        {
            User u = new User()
            {
                UserId = user.UserId,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Password = user.Password,
            };
            return u;
        }
        public static List<User> ConvertUserDtoListToUserList(List<UserDto> listUsers)
        {
            List<User> list = new List<User>();
            foreach (UserDto user in listUsers)
            {
                list.Add(ConvertUserDtoToUser(user));
            }
            return list;

        }
        public static UserDto ConvertUserToUserDto(User user)
        {
            UserDto u = new UserDto()
            {
                UserId = user.UserId,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Password = user.Password,
            };
            return u;
        }
        public static List<UserDto> ConvertUserListToUserDtoList(List<User> listUsers)
        {
            List<UserDto> list = new List<UserDto>();
            foreach (User user in listUsers)
            {
                list.Add(ConvertUserToUserDto(user));
            }
            return list;

        }
    }
}
