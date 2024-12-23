using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Xml.Linq;

namespace AspNet06Store.ShopUI.Models
{

    public class StoreDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }  
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
                    Description = "This is the best phone and with good camera with 50px and its very beautiful.",
                    Price = 100

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
                        Description = "This is the best phone and with good camera with 50px and its very beautiful.",
                        Price = 47000

                    },
                    new Product
                    {
                        ID = 4,
                        Category = "Iphone",
                        Name = "Iphone13",
                        Description = "This is the best phone and with good camera with 50px and its very beautiful.",
                        Price = 0

                    },
                    new Product
                    {
                        ID = 5,
                        Category = "Samsung",
                        Name = "Samsung A20",
                        Description = "This is the best phone and with good camera with 50px and its very beautiful.",
                        Price = 43000

                    },
                    new Product
                    {
                        ID = 6,
                        Category = "Samsung",
                        Name = "Samsung A18",
                        Description = "This is the best phone and with good camera with 50px and its very beautiful.",
                        Price = 56000

                    },
                    new Product
                    {
                        ID = 7,
                        Category = "Iphone",
                        Name = "Iphone11",
                        Description = "This is the best phone and with good camera with 50px and its very beautiful.",
                        Price = 340000

                    },
                    new Product
                    {
                        ID = 8,
                        Category = "Nokia",
                        Name = "Nokia SS2",
                        Description = "This is the best phone and with good camera with 50px and its very beautiful.",
                        Price = 34000

                    },
                    new Product
                    {
                        ID = 9,
                        Category = "Iphone",
                        Name = "Iphone14",
                        Description = "This is the best phone and with good camera with 50px and its very beautiful.",
                        Price = 50000

                    },
                    new Product
                    {
                        ID = 10,
                        Category = "Nokia",
                        Name = "Nokia500",
                        Description = "This is the best phone and with good camera with 50px and its very beautiful.",
                        Price = 30000

                    },
                    new Product
                    {
                        ID = 11,
                        Category = "Samsung",
                        Name = "SamsungA60",
                        Description = "This is the best phone and with good camera with 50px and its very beautiful.",
                        Price = 30000

                    },
                    new Product
                    {
                        ID = 12,
                        Category = "Apple",
                        Name = "Apple12",
                        Description = "This is the best phone and with good camera with 50px and its very beautiful.",
                        Price = 30000

                    }
                );
            base.OnModelCreating(modelBuilder);
        }



    }
}
