using Energy.Core.Entities.CatalogItems;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Energy.Infrastructure.ModelBuilding
{
    public class CatalogContext : DbContext
    {
        public DbSet<CatalogItem> CatalogItems { get; set; }
        public DbSet<CatalogCategory> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }

        #region Configuration
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder.UseCosmos(
                "https://localhost:8081/",
                "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==",
                databaseName: "CatalogDB");
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultContainer("Store");
            SetContainers(modelBuilder);
        }

        private static void SetContainers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatalogItem>().ToContainer("CatalogItems");
            modelBuilder.Entity<CatalogCategory>().ToContainer("Categories");
            modelBuilder.Entity<Review>().ToContainer("Reviews");
        }
    }
}
