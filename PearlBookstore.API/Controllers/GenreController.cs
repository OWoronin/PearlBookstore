using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PearlBookstore.API.DB;
using PearlBookstore.Shared.Dtos;

namespace PearlBookstore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenreController(AppDbContext context) : ControllerBase
    {
        [HttpGet("All")]
        public async Task<List<GenreDto>> GetAllGenres()
        {
            return await Task.FromResult(await context.Genres.Select(x => new GenreDto { Id = x.Id, Name = x.Name }).ToListAsync());
        }
    }
}
