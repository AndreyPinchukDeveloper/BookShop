﻿namespace BookStore.Web.Models
{
    public class AppUser:IdentityUser
    {
        public int? Pace { get; set; }
        public int? Mileage { get; set; }
        public Address? Address { get; set; }
    }
}
