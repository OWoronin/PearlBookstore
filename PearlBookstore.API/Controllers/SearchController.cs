using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PearlBookstore.API.DB;
using PearlBookstore.API.Models;

namespace PearlBookstore.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class SearchController(AppDbContext context) : ControllerBase
	{
		[HttpGet("SearchItem/{phrase}")]
		public async Task<List<Item>> SearchItems(string phrase)
		{
			List<Item> items = context.Items.Include(item=> item.Author).Where(item => item.Title.Contains(phrase) || item.Author.Surname.Contains(phrase) || item.Author.Name.Contains(phrase)).ToList();

			return await Task.FromResult(items);




		}
		
	}
}
