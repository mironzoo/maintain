using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Maintain.Service;
using Maintain.RequestBody;
using System.Text.Json;
using Microsoft.AspNetCore.Cors;

namespace Maintain.Controllers
{
    [Route("api/Login")]
    [ApiController]
    public class LoginController : ControllerBase {

        private readonly IConfiguration _configuration;
        UserService service;

        public LoginController(IConfiguration config) {
            _configuration = config;
            service = new UserService(config);
        }

        [HttpPost]
        [EnableCors("AllowOrigin")]
        [Route("loginUser")]
        public bool login([FromBody] LoginBody pid) {
            return service.doesUserExist(pid.pid);
        }

        [HttpPost]
        [EnableCors("AllowOrigin")]
        [Route("loginUser/test")]
        public string loginTest(int pid)
        {
            return "bro here i am";
        }

        [HttpGet]
        [EnableCors("AllowOrigin")]
        [Route("test")]
        public string loginTestMain(int pid)
        {
            return "bro here i am again";
        }
    }
}