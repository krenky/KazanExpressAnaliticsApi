using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    /// <summary>
    /// модель объекта выбираемой характеристики для товара
    /// </summary>
    internal class Characteristic
    {
        public string title { get; set; }
        public Value[] Values { get; set; }
    }
    public class Value
    {
        public string title { get; set; }
        public string value { get; set; }
    }
}
