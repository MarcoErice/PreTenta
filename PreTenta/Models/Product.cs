using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PreTenta.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        [Range(1, 1000000)]        
        public decimal UnitPrice { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Boolean IsDeleted { get; set; }
    }
}
