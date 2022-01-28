using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    internal class SKU
    {
        public int id { get; set; }
        public CharacteristicMapping[] characteristics { get; set; }
        public int availableAmount { get; set; }
        public float price { get; set; }
    }
}
