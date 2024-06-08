using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PearlBookstore.API.DB;
using PearlBookstore.Shared.Dtos;

namespace PearlBookstore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController(AppDbContext context) : ControllerBase
    {
        [HttpGet("All")]
        public async Task<List<AuthorDto>> GetAllAuthors()
        {
            return await Task.FromResult(await context.Authors.Select(a => new AuthorDto() { Id = a.Id, Name = a.Name, Surname = a.Surname }).ToListAsync());
        }
    }
}
