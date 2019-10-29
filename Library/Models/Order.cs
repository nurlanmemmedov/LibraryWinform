using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DAL;
using Library.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    class Order
    {

        public int Id { get; set; }
        [Required]
        public int ClientId { get; set; }
        [Required]
        public int BookId { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public DateTime ReturnDate { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public decimal Cost { get; set; }
        [Required]
        public bool Returned { get; set; }
        public Book Book { get; set; }
        public Client Client { get; set; }
    }
}
