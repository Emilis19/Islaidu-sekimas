using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finansai2.Models
{
    public class Kategorija
    {
       
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

    }
}