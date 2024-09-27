using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Xml.Linq;

namespace AspNet06Store.ShopUI.Models
{

    public class StoreDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public StoreDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID = 1,
                    Category = "Iphone",
                    Name = "Apple 16",
                    Description = "",
                    Price =100

                },
                     new Product
                     {
                         ID = 2,
                         Category = "Samsung",
                         Name = "A70",
                         Description = "",
                         Price = 6000

                     },
                    new Product
                    {
                        ID = 3,
                        Category = "Iphone",
                        Name = "Iphone 12",
                        Description = "",
                        Price = 47000

                    }, 
                    new Product
                    {
                        ID = 4,
                        Category = "Iphone",
                        Name = "Iphone13",
                        Description = "",
                        Price = 0

                    },
                    new Product
                    {
                        ID = 5,
                        Category = "Samsung",
                        Name = "Samsung A20",
                        Description = "",
                        Price = 43000

                    },
                    new Product
                    {
                        ID = 6,
                        Category = "Samsung",
                        Name = "Samsung A18",
                        Description = "",
                        Price = 56000

                    },
                    new Product
                    {
                        ID = 7,
                        Category = "Iphone",
                        Name = "Iphone11",
                        Description = "",
                        Price = 340000

                    },
                    new Product
                    {
                        ID = 8,
                        Category = "Nokia",
                        Name = "Nokia SS2",
                        Description = "",
                        Price = 34000

                    },
                    new Product
                    {
                        ID = 9,
                        Category = "Iphone",
                        Name = "Iphone14",
                        Description = "",
                        Price = 50000

                    },
                    new Product
                    {
                        ID = 10,
                        Category = "Nokia",
                        Name = "Nokia500",
                        Description = "",
                        Price = 30000

                    }
                );
            base.OnModelCreating(modelBuilder);
        }



    }
}
