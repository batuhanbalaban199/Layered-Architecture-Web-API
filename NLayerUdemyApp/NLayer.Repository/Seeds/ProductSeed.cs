﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder) 
        {
            builder.HasData(
                new Product { Id = 1, CategoryId = 1, Price = 150,   Stock = 20, CreatedDate = DateTime.Now, Name = "Sar9 Sport"},
                new Product { Id = 2, CategoryId = 1, Price = 100,   Stock = 20, CreatedDate = DateTime.Now, Name = "Sar9"},
                new Product { Id = 3, CategoryId = 1, Price = 100,   Stock = 20, CreatedDate = DateTime.Now, Name = "Kılınç 2000 Mega" },
                new Product { Id = 4, CategoryId = 1, Price = 100,   Stock = 20, CreatedDate = DateTime.Now, Name = "Kılınç 2000 Light" },
                new Product { Id = 5, CategoryId = 2, Price = 250,   Stock = 30, CreatedDate = DateTime.Now, Name = "Sar109T"},
                new Product { Id = 6, CategoryId = 3, Price = 350,   Stock = 40, CreatedDate = DateTime.Now, Name = "MPT 76 SH"},
                new Product { Id = 7, CategoryId = 3, Price = 375,   Stock = 40, CreatedDate = DateTime.Now, Name = "Sar 15T"},
                new Product { Id = 8, CategoryId = 4, Price = 1000,  Stock = 40, CreatedDate = DateTime.Now, Name = "Sar 762 MT"},
                new Product { Id = 9, CategoryId = 5, Price = 1500,  Stock = 5,  CreatedDate = DateTime.Now, Name = "Bora 12 - JNG 90"},
                new Product { Id = 10, CategoryId = 6, Price = 10000, Stock = 10,CreatedDate = DateTime.Now, Name = "Sarsılmaz 127 MT"}
                );
        }
    }
}