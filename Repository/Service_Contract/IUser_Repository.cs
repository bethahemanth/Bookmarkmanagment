using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Repository
{
    public interface IUser_Repository

    {
        public string createTable();
        public string InsertTable(User user);
        public List<User> GetUserById(int id);
        public string DeleteUserById(int id);


    }
}
