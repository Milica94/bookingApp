using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookingApp.Models
{
    public class AccomodationType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Accomodation> Accomodations { get; set; }
    }
}