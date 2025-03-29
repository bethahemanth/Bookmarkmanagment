using Repository;
using Domain;
namespace Services
{

    public class User_Service : IUser_Service
    {
        private readonly IUser_Repository _user;
        public User_Service(IUser_Repository user)
        {
            _user = user;
        }

        public string createTable()
        {
            return _user.createTable();
        }

        public string InsertTable(User user)
        {
            return _user.InsertTable(user);
        }

        public List<User> GetUserById(int id)
        {
            return _user.GetUserById(id);
        }

        public string DeleteUserById(int id)
        {
            return _user.DeleteUserById(id);
        }

    }
}
