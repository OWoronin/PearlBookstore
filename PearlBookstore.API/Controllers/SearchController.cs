using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PearlBookstore.API.DB;
using PearlBookstore.API.Models;
using PearlBookstore.Shared.Dtos;

namespace PearlBookstore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SearchController(AppDbContext context) : ControllerBase
    {
        [HttpGet("SearchItem/{phrase}")]
        public async Task<List<ItemDto>> SearchItems(string phrase)
        {
            List<Item> items = context.Items
                .Include(i => i.Author)
                .Include(i => i.Genres)
                    .ThenInclude(it => it.Genre)
                .Include(i => i.Types)
                    .ThenInclude(it => it.Type)
                .Where(item => item.Title.Contains(phrase) || item.Author.Surname.Contains(phrase) || item.Author.Name.Contains(phrase))
                 .ToList();

            List<ItemDto> result = new List<ItemDto>();
            foreach (var item in items)
            {
                List<GenreDto> genreDtos = new List<GenreDto>();
                foreach (var genre in item.Genres)
                {
                    genreDtos.Add(new GenreDto() { Id = genre.Genre.Id, Name = genre.Genre.Name });
                }

                List<TypeDto> typeDtos = new List<TypeDto>();
                foreach (var type in item.Types)
                {
                    typeDtos.Add(new TypeDto() { Id = type.Type.Id, Name = type.Type.Name });
                }

                result.Add(
                    new ItemDto()
                    {
                        Id = item.Id,
                        Title = item.Title,
                        Description = item.Description,
                        YearPublication = item.YearPublication,
                        Counter = item.Counter,
                        Price = item.Price,
                        AuthorDto = new AuthorDto()
                        {
                            Id = item.Author.Id,
                            Name = item.Author.Name,
                            Surname = item.Author.Surname
                        },
                        GenresDtos = genreDtos,
                        TypesDtos = typeDtos
                    });
            }

            return await Task.FromResult(result);

        }

    }
}
