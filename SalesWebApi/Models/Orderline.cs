using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SalesWebApi.Models
{
    public class Orderline
    {
        public int Id { get; set; }
        [StringLength(80), Required]
        public string Product { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(9,2)"), Required]
        public decimal Price { get; set; }

        public int OrderId { get; set; }
        [JsonIgnore]
        public virtual Order Order { get; set; }

        public Orderline() { }
    }
}
