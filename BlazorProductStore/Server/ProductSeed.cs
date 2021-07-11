﻿using BlazorProductStore.Server.Models;
using BlazorProductStore.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProductStore.Server
{
    public static class ProductSeed
    {
        public static void EnsurePopulated()
        {
            using var context = new ProductDbContext();

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product()
                    {
                        Name = "Shoes for tourism",
                        Description = "Special touristic",
                        Price = 800,
                        Category = "Shoes"
                    },
                    new Product()
                    {
                        Name = "Rubber boots",
                        Description = "Boots for fishing",
                        Price = 1200,
                        Category = "Shoes"
                    },
                    new Product()
                    {
                        Name = "Trekking shoes",
                        Description = "Comfortable trekking shoes",
                        Price = 1100,
                        Category = "Shoes"
                    },
                    new Product()
                    {
                        Name = "The coil",
                        Description = "Fishing coil",
                        Price = 200,
                        Category = "Fishing"
                    },
                    new Product()
                    {
                        Name = "Boggies",
                        Description = "Boggies for water fishing",
                        Price = 800,
                        Category = "Fishing"
                    },
                    new Product()
                    {
                        Name = "Ice axe",
                        Description = "For winter fishing",
                        Price = 1000,
                        Category = "Fishing"
                    },
                    new Product()
                    {
                        Name = "Fishing rod",
                        Description = "Comfortable fishing rod with coil",
                        Price = 900,
                        Category = "Fishing"
                    },
                    new Product()
                    {
                        Name = "Pneumatic pistol",
                        Description = "Pistol for sport shooting",
                        Price = 2000,
                        Category = "Shooting"
                    },
                    new Product()
                    {
                        Name = "Air rifle",
                        Description = "Rifle for sport shooting",
                        Price = 5000,
                        Category = "Shooting"
                    },
                    new Product()
                    {
                        Name = "Weapon case",
                        Description = "Nice weapon case",
                        Price = 1500,
                        Category = "Safes"
                    },
                    new Product()
                    {
                        Name = "Box case",
                        Description = "Box weapon case",
                        Price = 1000,
                        Category = "Safes"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
