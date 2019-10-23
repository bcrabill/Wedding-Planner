using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RedBeltPreview.Models;

namespace RedBeltPreview.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set;}

        [Required]
        [EmailAddress]
        public string Email { get; set;}


        [Required]
        public string FirstName { get; set;}


        [Required]
        public string LastName { get; set;}


        [Required]
        [MinLength(8, ErrorMessage = "Your pasword must be longer")]
        [DataType(DataType.Password)]
        
        public string Password { get; set;}
       
        
        [NotMapped]
        [Required]
        [MinLength(8, ErrorMessage = "Your pasword must be longer")]
        [DataType(DataType.Password)]       
        [Compare("Password")]
        public string ConfirmPassword { get; set;}
        
        

        public List<Rsvp> myRsvps { get; set;}
        public List<Wedding> createdWeddings { get; set;}
    }
}