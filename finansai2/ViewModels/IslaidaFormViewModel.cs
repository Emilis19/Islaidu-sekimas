using finansai2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace finansai2.ViewModels
{
    public class IslaidaFormViewModel
    {
        [DisplayName("Amount")]
        [Required]
        public double Suma { get; set; }

        [DisplayName("Date")]
        [Required]
        // [FutureDate]
        public string Date { get; set; }

        [DisplayName("Time")]
        [Required]
        [ValidTime]
        public string Time { get; set; }

        [DisplayName("Category")]
        [Required]
        public byte Kategorija { get; set; }
        public IEnumerable<Kategorija> Kategorijos { get; set; }

        [DisplayName("Name")]
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

       public DateTime GetDateTime()
        {
                return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}