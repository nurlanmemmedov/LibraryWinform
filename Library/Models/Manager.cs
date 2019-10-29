using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Library.Models
{
    class Manager
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]

        public string Surname { get; set; }
        public string Phone { get; set; }

    }
}
