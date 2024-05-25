using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PearlBookstore.API.DB;
using PearlBookstore.Shared;

namespace PearlBookstore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController(AppDbContext context) : ControllerBase
    {

        [HttpGet]
        public async Task<UserDto> Test()
        {

            var user = await context.Users
                            .Include(u => u.Role)
                            .FirstOrDefaultAsync();

            var userDto = new UserDto
            {
                Id = user.Id,
                Login = user.Login,
                Name = user.Name,
                Surname = user.Surname,
                Role = new RoleDto()
                {
                    Id = user.Role.Id,
                    Name = user.Role.Name,
                }
            };

            return await Task.FromResult(userDto);
        }

        [HttpPost("Login")]
        public async Task<LoginResponse> UserLogin(LoginData data)
        {
            //TO DO  data validation, roles conditions

            var user = await context.Users.Include(u => u.Role).Where(u => u.Login == data.Login && u.Password == data.Password).FirstOrDefaultAsync();

            LoginResponse login = new LoginResponse();

            if (user != null)
            {
                login.Login = user.Login;
                login.Id = user.Id;
                login.RoleId = user.Role.Id;
            }

            return await Task.FromResult(login);

        }

        [HttpPost("Registration")]
        public async Task<RegistrationResponse> UserRegistration(RegistrationData data)
        {
            //TO  DO connection to DB, data validation

            //User user = new User()
            //{
            //    Name = data.Name,
            //    Login = data.Login,
            //    Surname = data.Surname,
            //}

            RegistrationResponse registrationResponse = new RegistrationResponse()
            {
                Success = true,
            };


            return await Task.FromResult(registrationResponse);
        }

    }
}

