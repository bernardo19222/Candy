using Candy.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Candy.Web.Data
{
	public class DataContext:DbContext
	{
		public DbSet<Gender> Genders { get; set; }
		public DbSet<Client> Clients { get; set; }
		public DataContext(DbContextOptions<DataContext> options):base(options)
		{

		}
	}
}
