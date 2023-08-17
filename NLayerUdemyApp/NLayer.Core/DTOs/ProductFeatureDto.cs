using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class ProductFeatureDto
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int length { get; set; }
        public int Weight { get; set; }
        public int AmmoCap { get; set; }
        public int BarrelLenght { get; set; }
        public string Caliber { get; set; }
        public string TriggerSystem { get; set; }
        public string AdditionalFeatures { get; set; }
        public int ProductId { get; set; }

    }
}
