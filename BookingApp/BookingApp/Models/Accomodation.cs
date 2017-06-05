using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookingApp.Models
{
    public class Accomodation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Adress { get; set; }
        public double AvarageGrade { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string ImageURI { get; set; }
        public bool Aproved { get; set; }

        public IList<Comment> Comments { get; set; }

        [ForeignKey("AccomodationType")]
        public int AccomodationTypeId { get; set; }
        public AccomodationType AccomodationType { get; set; }


        [ForeignKey("AppUser")]
        public int UserId { get; set; }
        public AppUser Users { get; set; }


        [ForeignKey("Place")]
        public int PlaceId { get; set; }
        public Place Place { get; set; }




    }
}