using Microsoft.EntityFrameworkCore;

namespace Shop.Models
{
	public class ProductDbContext : DbContext
	{
		private const string connectionString = @"
                Data Source=localhost,1433;
                Initial Catalog=mydata;
                User ID=SA;Password=Password123";

		public DbSet<ProductModel> products { set; get; }
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			//modelBuilder.Configuration
		}
	}
}
