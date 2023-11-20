using BLL.Functions;
using BLL.Interfaces;
using DAL.Functions;
using DTO.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RecipesApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
  
    public class UserController : ControllerBase
    {
        IUserBll userBll;
        public UserController(IUserBll userBll)
        {
            this.userBll = userBll;
        }

        [HttpGet]
        [Route("GetAll")]
        public List<UserDto> GetAll()
        {
            return userBll.GetAll();
            
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public UserDto GetById(int id) {
            return userBll.GetById(id);
        }
        [HttpGet]
        [Route("GetByMailAndPassword/{mail}/{password}")]
        public UserDto GetByMailAndPassword(string mail, string password)
        {
            return userBll.GetByMailAndPassword(mail,password);
        }

        [HttpPost("Add")]
        public UserDto Add([FromBody]UserDto user) {
            return userBll.Add(user);
        }
    }
}
