using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Services
{
    public interface IUser_Service
    {
        public string createTable();

        public string InsertTable(User user);

        public List<User> GetUserById(int id);

        public string DeleteUserById(int id);

    }
}
