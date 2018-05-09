using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleCarousel.Models
{
    public class User
    {
        public string Fullname { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public bool EnableNotifications { get; set; }
        public string ProfilePicture { get; set; }
    }
}
