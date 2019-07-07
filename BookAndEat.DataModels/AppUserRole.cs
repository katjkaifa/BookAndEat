using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndEat.DataModels
{
    public class AppUserRole: IdentityUserRole<string>
    {
        public int? RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
