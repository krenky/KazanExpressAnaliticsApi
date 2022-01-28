using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    /// <summary>
    /// модель соотношения выбранных характеристики к SKU
    /// </summary>
    internal class CharacteristicMapping
    {
        public int charIndex { get; set; }      // Индекс названия характеристики
        public int valueIndex { get; set; }     // Индекс значения характеристики 
    }
}
