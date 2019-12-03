using System;
using System.ComponentModel.DataAnnotations;

namespace quoting_dojo.Models
{
    public class User
    {
        [Display(Name="Your name: ")]
        [Required (ErrorMessage = "A name is required.")]
        public string name { get; set; }
        [Display(Name="Your quote: ")]
        [Required (ErrorMessage = "A quote is required.")]
        public string quote { get; set; }
    }
}