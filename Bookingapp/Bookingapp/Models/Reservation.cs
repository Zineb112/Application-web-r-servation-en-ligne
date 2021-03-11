using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookingapp.Models
{
    public class Reservation
    {
        public string id { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string Cause { get; set; }
        public Student Student { get; set; }
        public TypeReservation Reserve { get; set; }

    }
}
