using Candy.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Candy.Web.Data
{
	public class DataContext:DbContext
	{
		public DbSet<Client> Clients { get; set; }
		public DbSet<Country> Countries { get; set; }
		public DbSet<Gender> Genders { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Provider> Providers  { get; set; }
		public DbSet<TypeP> TypePs { get; set; }
		public DataContext(DbContextOptions<DataContext> options):base(options)
		{

		}
	}
}
