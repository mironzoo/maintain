using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maintain.Repository;
using Microsoft.Extensions.Configuration;

namespace Maintain.Service
{
    public class UserService
    {
        private UserRepos repos;
        public UserService(IConfiguration configuration) {
            repos = new UserRepos(configuration);
        }

        public bool doesUserExist(int pid)
        {
            return repos.GetUserById(pid) != null;
        }


    }
}
