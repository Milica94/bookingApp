using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookingApp.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int Grade { get; set; }
        public string Text { get; set; }

        [ForeignKey("AppUser")]
        public int UserId { get; set; }

        public AppUser User { get; set; }

        [ForeignKey("Accomodation")]
        public int AccomodationId { get; set; }
        public Accomodation Accomodation { get; set; }

    }
}