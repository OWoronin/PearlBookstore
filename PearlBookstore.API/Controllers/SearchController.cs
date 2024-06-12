﻿using Microsoft.AspNetCore.Mvc;
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
        public async Task<List<ItemDto>> SearchPurchase(string phrase)
        {
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
                .FirstAsync();

            var items = new List<ItemDto>();

            foreach (var item in itemsPurchase.Items)
            {
                List<GenreDto> genreDtos = [];
                foreach (var genre in item.Item.Genres)
                {
                    genreDtos.Add(new GenreDto() { Id = genre.Genre.Id, Name = genre.Genre.Name });
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
                    Price = item.Type.Items.First(x => x.TypeId == item.TypeId).Price,
                    GenresDtos = genreDtos,
                    TypeDto = new TypeDto()
                    {
                        Id = item.Type.Id,
                        Name = item.Type.Name,
                    }
                };
                items.Add(itemDto);
            }

            return await Task.FromResult(items);
        }

    }
}
