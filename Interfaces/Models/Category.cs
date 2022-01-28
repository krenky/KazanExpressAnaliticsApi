using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    /// <summary>
    /// модель объекта товарной категории
    /// </summary>
    internal class Category
    {
        public int id { get; set; }                // ID категории в системе KazanExpress
        public string title { get; set; }          // Название категории
        public string image { get; set; }          // Ссылка на фото категории
        public Category[] children { get; set; }   // Родительская категория
    }
}
