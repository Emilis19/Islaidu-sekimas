using finansai2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace finansai2.ViewModels
{
    public class PerziuretiFormViewModel
    {
        [DisplayName("Date From")]
        [Required]
        public string dateFrom { get; set; }

        [DisplayName("Date To")]
        [Required]
        public string dateTo { get; set; }

        [DisplayName("Category")]
        [Required]
        public byte Kategorija { get; set; }
        public IEnumerable<Kategorija> Kategorijos { get; set; }


    }
}