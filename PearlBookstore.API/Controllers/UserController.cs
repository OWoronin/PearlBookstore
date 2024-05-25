﻿using Microsoft.AspNetCore.Mvc;
using PearlBookstore.API.DB;
using PearlBookstore.Shared;

namespace PearlBookstore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController(AppDbContext context) : ControllerBase
    {

        [HttpPost("Login")]
        public async Task<LoginResponse> UserLogin(LoginData data)
        {
            //TO DO  data validation, roles conditions
            LoginResponse login = new LoginResponse()
            {
                Id = 1,
                RoleId = 1,
                Login = data.Login,
            };

            return await Task.FromResult(login);

        }

        [HttpPost("Registration")]
        public async Task<RegistrationResponse> UserRegistration(RegistrationData data)
        {
            //TO  DO connection to DB, data validation 
            RegistrationResponse registrationResponse = new RegistrationResponse()
            {
                Success = true,
            };


            return await Task.FromResult(registrationResponse);
        }

    }
}

