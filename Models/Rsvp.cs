using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace RedBeltPreview.Models
{
    public class Rsvp
    {
        public int RsvpId { get; set;}
        public int UserId { get; set;}
        public int WeddingId { get; set;}
        //Navigational properties

        public User Guest { get; set;}
        public Wedding Attending { get; set;}
    }
}