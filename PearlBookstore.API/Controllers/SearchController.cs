using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PearlBookstore.API.DB;
using PearlBookstore.API.Extensions;
using PearlBookstore.API.Models;
using PearlBookstore.Shared.Dtos;
using PearlBookstore.Shared.RequestsResponses.Responses;

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
                foreach (var type in item.Types)
                {
                    List<GenreDto> genreDtos = new List<GenreDto>();
                    foreach (var genre in item.Genres)
                    {
                        genreDtos.Add(new GenreDto() { Id = genre.Genre.Id, Name = genre.Genre.Name });
                    }

                    result.Add(
                    new ItemDto()
                    {
                        Id = item.Id,
                        Title = item.Title,
                        Description = item.Description,
                        YearPublication = item.YearPublication,
                        Counter = type.Counter,
                        Price = type.Price,
                        AuthorDto = new AuthorDto()
                        {
                            Id = item.Author.Id,
                            Name = item.Author.Name,
                            Surname = item.Author.Surname
                        },
                        GenresDtos = genreDtos,
                        TypeDto = new TypeDto()
                        {
                            Id = type.Type.Id,
                            Name = type.Type.Name
                        }
                    });
                }


            }

            return await Task.FromResult(result);

        }

        [HttpGet("SearchToOrder/{id}/{type}")]
        public async Task<ItemDto> GetItemToOrdere(int id, int type)
        {
            var item = context.Items
                .Include(i => i.Author)
                .Include(i => i.Genres)
                    .ThenInclude(it => it.Genre)
                .Include(i => i.Types)
                    .ThenInclude(it => it.Type)
                .Where(item => item.Id == id)
                 .ToList();

            ItemDto itemDto = new();

            foreach (var it in item)
            {
                foreach (var typ in it.Types)
                {
                    if (typ.TypeId != type)
                    {
                        continue;
                    }
                    List<GenreDto> genreDtos = [];
                    foreach (var genre in it.Genres)
                    {
                        genreDtos.Add(new GenreDto() { Id = genre.Genre.Id, Name = genre.Genre.Name });
                    }
                    itemDto = new ItemDto()
                    {
                        Id = it.Id,
                        Title = it.Title,
                        Description = it.Description,
                        YearPublication = it.YearPublication,
                        Counter = typ.Counter,
                        Price = typ.Price,
                        AuthorDto = new AuthorDto()
                        {
                            Id = it.Author.Id,
                            Name = it.Author.Name,
                            Surname = it.Author.Surname
                        },
                        GenresDtos = genreDtos,
                        TypeDto = new TypeDto()
                        {
                            Id = typ.Type.Id,
                            Name = typ.Type.Name
                        }
                    };
                    break;
                }


            }

            return await Task.FromResult(itemDto);
        }

        [HttpGet("SearchExtended")]
        public async Task<List<ItemDto>> SearchItemsExtended([FromHeader] string phrase, [FromHeader] int autorID, [FromHeader] int genreID, [FromHeader] decimal minPrice, [FromHeader] decimal maxPrice, [FromHeader] bool isHard, [FromHeader] bool isSoft, [FromHeader] bool isEbook, [FromHeader] bool isAudiobook)
        {
            var items = context.Items
                .Include(i => i.Author)
                .Include(i => i.Genres)
                    .ThenInclude(it => it.Genre)
                .Include(i => i.Types)
                    .ThenInclude(it => it.Type)
                .Where(item => item.Title.Contains(phrase) || item.Author.Surname.Contains(phrase) || item.Author.Name.Contains(phrase));

            if (autorID > 0)
            {
                items = items.Where(item => item.AuthorId == autorID);
            }

            if (genreID > 0)
            {
                items = items.Where(item => item.Genres.Select(g => g.GenreId).Contains(genreID));
            }

            if (minPrice > 0)
            {
                items = items.Where(item => item.Types.Any(t => t.Price > minPrice));
            }

            if (maxPrice > 0)
            {
                items = items.Where(item => item.Types.Any(t => t.Price < maxPrice));
            }

            if (isHard)
            {
                items = items.Where(item => item.Types.Any(t => t.TypeId == 1));
            }

            if (isSoft)
            {
                items = items.Where(item => item.Types.Any(t => t.TypeId == 2));
            }

            if (isEbook)
            {
                items = items.Where(item => item.Types.Any(t => t.TypeId == 3));
            }

            if (isAudiobook)
            {
                items = items.Where(item => item.Types.Any(t => t.TypeId == 4));
            }

            List<ItemDto> result = new List<ItemDto>();
            foreach (var item in items)
            {
                foreach (var type in item.Types)
                {
                    if (isHard || isSoft || isEbook || isAudiobook)
                    {
                        if (type.TypeId == 1 && !isHard)
                        {
                            continue;
                        }

                        if (type.TypeId == 2 && !isSoft)
                        {
                            continue;
                        }

                        if (type.TypeId == 3 && !isEbook)
                        {
                            continue;
                        }

                        if (type.TypeId == 4 && !isAudiobook)
                        {
                            continue;
                        }
                    }

                    if ((maxPrice > 0 || minPrice > 0) && (type.Price > maxPrice || type.Price < minPrice))
                    {
                        continue;
                    }

                    List<GenreDto> genreDtos = new List<GenreDto>();
                    foreach (var genre in item.Genres)
                    {
                        genreDtos.Add(new GenreDto() { Id = genre.Genre.Id, Name = genre.Genre.Name });
                    }

                    result.Add(
                    new ItemDto()
                    {
                        Id = item.Id,
                        Title = item.Title,
                        Description = item.Description,
                        YearPublication = item.YearPublication,
                        Counter = type.Counter,
                        Price = type.Price,
                        AuthorDto = new AuthorDto()
                        {
                            Id = item.Author.Id,
                            Name = item.Author.Name,
                            Surname = item.Author.Surname
                        },
                        GenresDtos = genreDtos,
                        TypeDto = new TypeDto()
                        {
                            Id = type.Type.Id,
                            Name = type.Type.Name
                        }
                    });
                }


            }

            return await Task.FromResult(result);
        }

        [HttpGet("SearchPurchase/{phrase}")]
        public async Task<SearchPurchaseResponse> SearchPurchase(string phrase)
        {
            var response = new SearchPurchaseResponse();
            string prefix = "Nie udało się wyszukać zakupu.";
            var itemsPurchase = await context.Purchases
                .Include(x => x.Items)
                    .ThenInclude(i => i.Item)
                        .ThenInclude(i => i.Author)
                .Include(x => x.Items)
                    .ThenInclude(i => i.Item)
                        .ThenInclude(i => i.Genres)
                            .ThenInclude(it => it.Genre)
                .Include(x => x.Items)
                    .ThenInclude(i => i.Type)
                .Where(i => i.PurchaseID.Equals(phrase))
                .FirstOrDefaultAsync();

            if (itemsPurchase == null)
            {
                response.IsSuccess = false;
                response.Message = $"{prefix} Dany zakup nie istnieje w systemie.";
                return await Task.FromResult(response);
            }

            if (itemsPurchase.Date.IsAtLeast14DaysEarlierThanToday())
            {
                response.IsSuccess = false;
                response.Message = $"{prefix} Od daty zakupu minęło więcej niż 14 dni.";
                return await Task.FromResult(response);
            }

            var items = new List<ItemDto>();

            foreach (var item in itemsPurchase.Items)
            {
                List<GenreDto> genreDtos = [];
                foreach (var genre in item.Item.Genres)
                {
                    genreDtos.Add(new GenreDto() { Id = genre.Genre.Id, Name = genre.Genre.Name });
                }

                var price = await context.ItemsTypes.Where(x => x.TypeId == item.TypeId && x.ItemId == item.ItemId).Select(x => x.Price).FirstAsync();

                int counter = item.Counter;

                var itemInReturn = context.ItemReturns.Where(x => x.Return.Purchase.PurchaseID == phrase && x.ItemId == item.ItemId && x.TypeId == item.TypeId);

                foreach (var i in itemInReturn)
                {
                    counter -= i.Counter;
                }

                var itemDto = new ItemDto()
                {
                    Id = item.Item.Id,
                    Title = item.Item.Title,
                    Description = item.Item.Description,
                    AuthorDto = new AuthorDto()
                    {
                        Id = item.Item.Author.Id,
                        Name = item.Item.Author.Name,
                        Surname = item.Item.Author.Surname,
                    },
                    YearPublication = item.Item.YearPublication,
                    Counter = item.Counter,
                    Price = price,
                    GenresDtos = genreDtos,
                    TypeDto = new TypeDto()
                    {
                        Id = item.Type.Id,
                        Name = item.Type.Name,
                    },
                    ReturnCounter = counter
                };
                items.Add(itemDto);
            }

            response.Items = items;
            response.IsSuccess = true;
            return await Task.FromResult(response);
        }

    }
}
