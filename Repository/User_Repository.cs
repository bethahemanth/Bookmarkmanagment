using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;
using Domain;

namespace Repository
{
    public class User_Repository: IUser_Repository
    {
       private readonly IDatabaseContext _context;
        public User_Repository(IDatabaseContext context)
        {
            _context = context;
        }

        public string createTable()
        {
            string query = "CREATE TABLE Users_P( " +
                "ID SERIAL PRIMARY KEY, " +
                "Name VARCHAR(50), " +
                "Email VARCHAR(50));";  
            return _context.ExecuteQuery(query);
        }

        public string InsertTable(User user)
        {
            string query = "INSERT INTO Users_P(" +
                   "ID, " +
                   "Name, " +
                   "Email) " +
                   "VALUES(" +
                   $"{user.Id}, " +
                   $"'{user.Name}', " +
                   $"'{user.Email}');";
            return _context.ExecuteQuery(query);
        }

        public List<User> GetUserById(int id)
        {
            string query = $@"SELECT * FROM ""users_p"" WHERE ID = {id}";
            return _context.GetTableData<User>(query);
        }

        public string DeleteUserById(int id)
        {
            string query = $@"DELETE FROM ""users_p"" WHERE ID = {id}";
            return _context.ExecuteQuery(query);
        }



    }
}
