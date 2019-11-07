using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Library.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Fullname { get; set; }
        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }
        public List<Order> Orders { get; set; }
    }
}
