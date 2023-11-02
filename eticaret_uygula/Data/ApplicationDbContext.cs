using eticaret_uygula.Models;
using Microsoft.EntityFrameworkCore;

namespace eticaret_uygula.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
		{
		}
		public DbSet<Products>? Products { get; set; }
		public DbSet<Category>? Categories { get; set; }
		public DbSet<slider>? Slider { get; set; }	
	}
}
