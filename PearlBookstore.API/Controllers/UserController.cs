using Microsoft.AspNetCore.Mvc;
using PearlBookstore.Shared;

namespace PearlBookstore.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class UserController : ControllerBase
	{
		
		[HttpGet("Login")]
		public async Task<LoginResponse> UserLogin([FromQuery]LoginData data)
		{
			//TO DO Create connection to DB, data validation, roles conditions
			LoginResponse login = new LoginResponse()
			{
				Id = 1,
				RoleId = 1,
				Login = data.Login, 
			};

			return await Task.FromResult(login);
			
		}

		[HttpGet("Registration")]
		public async Task<RegistrationResponse> UserRegistration([FromQuery]RegistrationData data)
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

