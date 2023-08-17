using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;
using NLayer.Repository.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {
            // var p = new Product() { ProductFeature=new ProductFeature() };
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.ApplyConfiguration(new ProductConfiguration()); // bu ve benzeri kodları tek tek yazmak yerine bir üst satırdaki gibi hepsini tek seferde yapmak daha iyidir.

            //Alttaki kodlar alınan eğitimden dolayı aynı işlemlerin burdada yapılabileceğini görmek için yapılmıştır. Ancak Best
            //Practices açısından uygun bir kullanım değildir. 
            modelBuilder.Entity<ProductFeature>().HasData(
            new ProductFeature() {Id = 1, ProductId = 1,   AmmoCap = 19,  Caliber = "9 x 19mm", BarrelLenght = 160, Color = "Black", Height = 150, length = 200, TriggerSystem = "Çift Hareketli", Weight = 1500, Width = 30, AdditionalFeatures = "Polimer Gövde, Metal Şarjör"},
            new ProductFeature() {Id = 2, ProductId = 2,   AmmoCap = 15,  Caliber = "9 x 19mm", BarrelLenght = 150, Color = "Black", Height = 150, length = 200, TriggerSystem = "Çift Hareketli", Weight = 1500, Width = 30, AdditionalFeatures = "Polimer Gövde, Metal Şarjör" },
            new ProductFeature() {Id = 3, ProductId = 3,   AmmoCap = 15,  Caliber = "9 x 19mm", BarrelLenght = 150, Color = "Black", Height = 150, length = 200, TriggerSystem = "Çift Hareketli", Weight = 1500, Width = 30, AdditionalFeatures = "Polimer Gövde, Metal Şarjör" },
            new ProductFeature() {Id = 4, ProductId = 4,   AmmoCap = 15,  Caliber = "9 x 19mm", BarrelLenght = 150, Color = "Black", Height = 150, length = 200, TriggerSystem = "Çift Hareketli", Weight = 1500, Width = 30, AdditionalFeatures = "Polimer Gövde, Metal Şarjör" },
            new ProductFeature() {Id = 5, ProductId = 5,   AmmoCap = 30,  Caliber = "9 x 19mm", BarrelLenght = 450, Color = "Black", Height = 250, length = 600, TriggerSystem = "Çift Hareketli", Weight = 2500, Width = 30, AdditionalFeatures = "Polimer Gövde, Metal Şarjör" },
            new ProductFeature() {Id = 6, ProductId = 6,   AmmoCap = 30,  Caliber = "7.62 x 39mm", BarrelLenght = 700, Color = "Black", Height = 300, length = 900, TriggerSystem = "Çift Hareketli", Weight = 3500, Width = 30, AdditionalFeatures = "Polimer Gövde, Metal Şarjör" },
            new ProductFeature() {Id = 7, ProductId = 7,   AmmoCap = 30,  Caliber = "7.62 x 39mm", BarrelLenght = 700, Color = "Black", Height = 300, length = 900, TriggerSystem = "Çift Hareketli", Weight = 3500, Width = 30, AdditionalFeatures = "Polimer Gövde, Metal Şarjör" },
            new ProductFeature() {Id = 8, ProductId = 8,   AmmoCap = 100, Caliber = "7.62 x 39mm", BarrelLenght = 750, Color = "Black", Height = 300, length = 1300, TriggerSystem = "Çift Hareketli", Weight = 4500, Width = 30, AdditionalFeatures = "Polimer Gövde, Metal Şarjör" },
            new ProductFeature() {Id = 9, ProductId = 9,   AmmoCap = 10,  Caliber = "7.62 x 39mm", BarrelLenght = 860, Color = "Black", Height = 300, length = 1000, TriggerSystem = "Çift Hareketli", Weight = 12500, Width = 30, AdditionalFeatures = "Polimer Gövde, Metal Şarjör" },
            new ProductFeature() {Id = 10,ProductId = 10,  AmmoCap = 250, Caliber = "7.62 x 39mm", BarrelLenght = 750, Color = "Black", Height = 450, length = 1400, TriggerSystem = "Çift Hareketli", Weight = 15000, Width = 30, AdditionalFeatures = "Polimer Gövde, Metal Şarjör" }
            );
            
            base.OnModelCreating(modelBuilder);
        }
    }
   
}
