using Microsoft.AspNetCore.Mvc;
using Services;
using Domain;
namespace Bookmark_Manager.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class User_Controller : ControllerBase
    {
      private readonly IUser_Service _user;
        public User_Controller(IUser_Service user)
        {
            _user = user;
        }

        [HttpPost]
        [ActionName("CreateUser")]
        public string createTable()
        {
            return _user.createTable();
        }

        [HttpPost]
        [ActionName("InsertUser")]
        public string InsertTable(User user)
        {
            return _user.InsertTable(user);
        }

        [HttpGet]
        [ActionName("GetUserById")]
        public List<User> GetUserById(int id)
        {
           return  _user.GetUserById(id);
        }

        [HttpDelete]
        [ActionName("DeleteUserById")]
        public string DeleteUserById(int id)
        {
            return _user.DeleteUserById(id);
        }


    }
}
