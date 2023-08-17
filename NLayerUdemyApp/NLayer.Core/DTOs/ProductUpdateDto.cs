using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class ProductUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; } // Konulan soru işareti bu değerin null değer alabileceğini belirtir.
        public int Stock { get; set; }// int ve decimal tanımlamaların Default değerleri olduğu için Nullable göstergesi olan yeşil altçizgi görünmez. Bu değer 0'dır
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

    }
}
