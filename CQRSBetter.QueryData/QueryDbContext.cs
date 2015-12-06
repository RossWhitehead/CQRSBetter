using CQRSBetter.QueryData.DataModel;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace CQRSBasic.QueryData
{
    public class QueryDbContext : DbContext
    {
        // Use ReadOnlyConnectionString from App/Web.config
        public QueryDbContext() : base("Name=QueryDb")
        {
        }

        public override int SaveChanges()
        {
            // Throw if they try to call this
            throw new InvalidOperationException("This context is read-only.");
        }

        // Does not expose Add(), Remove(), etc.
        public DbQuery<Product> Products
        {
            get
            {
                // Don't track changes to query results
                return Set<Product>().AsNoTracking();
            }
        }

        public DbQuery<ProductCategory> ProductCategories
        {
            get
            {
                // Don't track changes to query results
                return Set<ProductCategory>().AsNoTracking();
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Need to register the entities
            modelBuilder.Entity<Product>().ToTable("vProduct");
            modelBuilder.Entity<ProductCategory>().ToTable("vProductCategory");

            base.OnModelCreating(modelBuilder);
        }
    }
}
