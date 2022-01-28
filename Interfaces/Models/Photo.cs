using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    /// <summary>
    /// модель ссылок на фотографии товара в разных размерах и качествах
    /// </summary>
    public class Photo
    {
        [JsonProperty("80")]
        Link the80 { get; set; }
        [JsonProperty("240")]
        public Link the240 { get; set; }
        [JsonProperty("540")]
        public Link the540 { get; set; }
        [JsonProperty("800")]
        public Link the800 { get; set; }
        public string color { get; set; }   // Если у товара поле colorPhotoPreview == true, то фото будет соотноситься
                                            // с характеристикой с названием, соответствующим значению поля "color"
    }
    public class Link
    {
        public string high { get; set; }    // Ссылка на изображение товара в высоком качестве размера 
        public string low { get; set; }     // Ссылка на изображение товара в низком качестве размера
    }
}
