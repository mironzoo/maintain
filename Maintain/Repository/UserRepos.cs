using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Maintain.Models;

namespace Maintain.Repository
{
    public class UserRepos : Repos
    {
        
        public UserRepos(IConfiguration configuration) : base(configuration) { }

        public User GetUserById(int pid) {
            OpenConnection();
            Console.WriteLine("We connected maybe???");
            string selectQuery =
                "SELECT pid, f_name, l_name " +
                "FROM USERS " +
                "WHERE pid = '" + pid + "';";
            SqlCommand command = new SqlCommand(selectQuery, getConn());
            SqlDataReader reader = command.ExecuteReader();
            User result = null;
            if (reader.Read()) {
                Console.WriteLine(reader[1].ToString());
                result = new User(pid, reader[1].ToString(), reader[2].ToString());
            }

            CloseConnection();
            return result;
        }

        public bool AddUser() { 
            return false;
        }        

        public bool DeleteUser() {
            return false;
        }

        public bool EditUser(int pid) {
            return false;
        }
    }
}
