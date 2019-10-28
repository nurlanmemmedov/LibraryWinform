using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Library.Models
{
    class Payment
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public int BookId { get; set; }

        public decimal Cost { get; set; }

        public Client User { get; set; }
        public Book Book { get; set; }
    }
}
