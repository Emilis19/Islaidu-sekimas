using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace finansai2.ViewModels
{
    public class KategorijaFormViewModel
    {
        [DisplayName("Name")]
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}