using Microsoft.EntityFrameworkCore;
using PearlBookstore.API.Models;

namespace PearlBookstore.API.DB
{
	public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
	{
		public DbSet<Author> Authors { get; set; }
		public DbSet<Genre> Genres { get; set; }
		public DbSet<Item> Items { get; set; }
		public DbSet<ItemGenre> ItemsGenres { get; set; }
		public DbSet<ItemType> ItemsTypes { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<Storage> Storages { get; set; }
		public DbSet<PearlBookstore.API.Models.Type> Types { get; set; }
		public DbSet<User> Users { get; set; }


	}
}
