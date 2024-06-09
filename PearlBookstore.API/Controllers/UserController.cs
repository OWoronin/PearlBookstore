using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PearlBookstore.API.DB;
using PearlBookstore.API.Models;
using PearlBookstore.API.Services;
using PearlBookstore.Shared.RequestsResponses.Requests;
using PearlBookstore.Shared.RequestsResponses.Responses;

namespace PearlBookstore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController(AppDbContext context, CurrentEmployee employee) : ControllerBase
    {

        [HttpPost("Login")]
        public async Task<LoginResponse> UserLogin(LoginRequest data)
        {
            //TO DO  data validation, roles conditions

            var user = await context.Users.Include(u => u.Role).Where(u => u.Login == data.Login && u.Password == data.Password).SingleOrDefaultAsync();

            LoginResponse login = new LoginResponse();
            login.Id = -1;

            if (user != null)
            {
                login.Login = user.Login;
                login.Id = user.Id;
                login.RoleId = user.Role.Id;
                login.RoleName = user.Role.Name;
                login.Name = user.Name;
                login.Surname = user.Surname;

                employee.Current = user;
            }

            return await Task.FromResult(login);

        }

        [HttpPost("Registration")]
        public async Task<RegistrationResponse> UserRegistration(RegistrationRequest data)
        {

            var user = await context.Users.Where(u => u.Login == data.Login).FirstOrDefaultAsync();

            var registrationResponse = new RegistrationResponse();

            if (user == null)
            {
                var newUser = new User();
                newUser.Name = data.Name;
                newUser.Surname = data.Surname;
                newUser.Login = data.Login;
                newUser.Password = data.Password;
                newUser.RoleId = data.Role;

                context.Users.Add(newUser);

                int added = context.SaveChanges();
                if (added == 0)
                {
                    registrationResponse.Message = "Rejestracja pracownika nie powiodła się. Skontaktuj się z administratorem.";
                    registrationResponse.Success = false;
                }
                else
                {
                    registrationResponse.Message = "Rejestracja pracownika zakończona sukcesem.";
                    registrationResponse.Success = true;
                }


            }
            else
            {
                registrationResponse.Success = false;
                registrationResponse.Message = "Ten login jest zajęty!";
            }



            return await Task.FromResult(registrationResponse);
        }

        [HttpGet("Logged/{userID}")]
        public async Task<bool> IsUserLogged(int userID)
        {
            return await Task.FromResult(employee.Current.Id == userID);
        }

        [HttpPost("Logout")]
        public Task Logout()
        {
            employee.Current = null;
            return Task.CompletedTask;
        }
    }
}

