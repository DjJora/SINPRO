﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SINPRO.InputTypes;
using SINPRO.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SINPRO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginAPIController : ControllerBase
    {
        private readonly IAuthLogic _authLogic;
        public LoginAPIController(IAuthLogic authLogic)
        {
            _authLogic = authLogic;
        }

        // GET: api/<LoginController>
        [HttpPost]
        public LoginViewModel PostLogin(string Email,string Password)
        {
            LoginInputType item = new LoginInputType
            {
                Email = Email,
                Password = Password
            };
            return _authLogic.Login(item);
        }
    }
}
