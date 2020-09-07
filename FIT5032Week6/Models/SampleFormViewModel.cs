using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FIT5032Week6.Models
{
    public class SampleFormViewModel
    {
    }

    public class FormOneViewModel
    {
        [Required]
        [Display(Name ="First Name")]
        public String FirstName { get; set; }

        public String LastName { get; set; }
    }
}