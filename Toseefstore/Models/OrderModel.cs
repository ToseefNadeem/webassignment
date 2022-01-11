using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Toseefstore.Models
{
    public class OrderModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        [Required]
        public int price { get; set; }
       [DisplayName("upload image")]
        public string Image { get; set; }

    }
}
