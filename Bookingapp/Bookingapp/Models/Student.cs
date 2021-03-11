using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookingapp.Models
{
    public class Student : IdentityUser
    {
        public String FullName { get; set; }
        public String classe { get; set; }
        public int ResCount { get; set; }

    }
}
