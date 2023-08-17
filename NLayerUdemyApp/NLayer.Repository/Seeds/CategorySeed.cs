using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 1, Name = "Pistols" }, 
                new Category { Id = 2, Name = "SMGs" }, 
                new Category { Id = 3, Name = "Rifles" }, 
                new Category { Id = 4, Name = "MTs" }, 
                new Category { Id = 5, Name = "Sniper Rifles" }, 
                new Category { Id = 6, Name = "Mounted MGs" });
        }
    }
}
