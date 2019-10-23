using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RedBeltPreview.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingID { get; set;}
        [Required]
        public string WedderOne {get; set;}
        [Required]
        public string WedderTwo {get; set;}
        [Required]
        public DateTime Date { get; set;}
        [Required]
        public string Address { get; set;}
        [Required]
        public int UserId { get; set;}
        public DateTime CreatedAt { get; set;}
        public DateTime UpdatedAt { get; set;}

        //Navigational properties
        public User Planner { get; set;}
        public List<Rsvp> GuestList { get; set;}

    }
}