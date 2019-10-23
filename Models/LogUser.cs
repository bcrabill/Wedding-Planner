using System;
using System.ComponentModel.DataAnnotations;

namespace RedBeltPreview.Models
{
    public class LogUser
    {
        [Required]
        [EmailAddress]
        [Display(Name="Email")]
        public string LoginEmail {get; set;}
        
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Your pasword must be longer")]
        [Display(Name = "Password")]
        public string LoginPassword { get;set;}
       
    }
}