using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class Order
    {

        public int Id { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public DateTime MustReturnAt { get; set; }
        public DateTime? ReturningDate { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public decimal Cost { get; set; }
        [Required]
        public bool Returned { get; set; }
        [Required]
        public int BookId { get; set; }
        public Book Book { get; set; }
        [Required]
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
