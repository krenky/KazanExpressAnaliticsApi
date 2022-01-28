using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    internal class Products
    {
        public int id { get; set; }             // ID товара в системе KazanExpress
        public string title { get; set; }       // Название товара
        public int categoryId { get; set; }     // Идентификатор категории, в которой находится товар
        public string description { get; set; } // Описание товара в формате HTML
        public string[] attributes { get; set; }// Краткие характеристики товара
        public Photo[] photos { get; set; }     // Фото товаров  
        public Characteristic[] characteristics { get; set; }// Список назавний и значений характеристик
        public SKU[] skuList { get; set; }      // Список вариаций товара (SKU)
        public bool usePreview { get; set; }    // Поле, указывающее, нужно ли соотносить фото с характеристикой "Цвет"
    }
}
