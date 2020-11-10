using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Maintain.Repository
{
    public class UserRepos : Repos
    {
        
        public UserRepos(IConfiguration configuration) : base(configuration) { }

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
