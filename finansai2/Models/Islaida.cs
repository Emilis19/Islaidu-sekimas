using System;
using System.ComponentModel.DataAnnotations;

namespace finansai2.Models
{
    public class Islaida
    {
        public ApplicationUser Isleidejas { get; set; }

        public int Id { get; set; }

        [Required]
        public string IsleidejasId { get; set; }

        public DateTime DateTime { get; set; }

        public double Suma { get; set; }


        public Kategorija Kategorija { get; set; }

        [Required]
        public byte KategorijaId { get; set; }
    }

}