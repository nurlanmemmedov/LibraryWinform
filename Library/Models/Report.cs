using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Library.Models
{
    class Report
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        [Required]
        public int BookId { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public decimal Pay { get; set; }
        public Client User { get; set; }
        public Book Book { get; set; }
    }
}
