using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_VMSample.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Titel")]
        public string Title { get; set; }

        [Required]
        [MaxLength(30)]
        public string Author { get; set; }

        [Required]
        [Range(0, 10000)]
        [DisplayName("Preis")]
        public decimal Price { get; set; }

        [Required]
        [DisplayName("Hörbuch")]
        public bool AudioBook { get; set; } = false;
    }
}
