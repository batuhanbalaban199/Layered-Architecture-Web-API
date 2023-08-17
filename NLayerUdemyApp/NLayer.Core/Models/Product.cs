using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class Product : BaseEntity
    {
        //public Product(string name) 
        //{ 
        //    Name = name ?? throw new ArgumentNullException(nameof(Name)); //name alanı boşsa null exception hatası fırlatılır.
        //}


        public string Name { get; set; } // Konulan soru işareti bu değerin null değer alabileceğini belirtir.
        public int Stock { get; set; }// int ve decimal tanımlamaların Default değerleri olduğu için Nullable göstergesi olan yeşil altçizgi görünmez. Bu değer 0'dır
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } //Navigation Property
        public ProductFeature ProductFeature { get; set; } //ProductFeature Navigation Property 

    }
}
