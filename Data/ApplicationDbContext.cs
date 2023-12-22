using Microsoft.EntityFrameworkCore;
using WebMarket.Models;

namespace WebMarket.Data
{
	public class ApplicationDbContext: DbContext 
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		public DbSet<Category> Categories { get; set; }
	}
}

