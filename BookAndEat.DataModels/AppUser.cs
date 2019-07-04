using System;
using System.Collections.Generic;
using BookAndEat.DataModels.Infrastructure;
using Microsoft.AspNetCore.Identity;

namespace BookAndEat.DataModels
{
    public class AppUser : IdentityUser, IAudited
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public DateTime CreationTime { get; set; }
        public DateTime? LastModificationTime { get; set; }

        public List<Invoice> Invoices { get; set; }
        public List<UserComment> UserComments { get; set; }
        public List<UserFavourite> UserFavourites { get; set; }
        public List<Order> Orders { get; set; }
    }
}
