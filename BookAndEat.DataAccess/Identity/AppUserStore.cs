using BookAndEat.DataModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;

namespace BookAndEat.DataAccess.Identity
{
    public class AppUserStore : UserStore<AppUser, IdentityRole, ApplicationDbContext, string, IdentityUserClaim<string>, IdentityUserRole<string>, IdentityUserLogin<string>, IdentityUserToken<string>, IdentityRoleClaim<string>>
    {
        public AppUserStore(ApplicationDbContext dbContext) : base(dbContext) { }

        public Task AddToRoleAsync(AppUser user, Restaurant restaurant, String roleName)
        {
            IdentityRole role = null;

            try
            {
                role = Context.Set<IdentityRole>().Where(mr => mr.Name == roleName).Single();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            Context.Set<AppUserRole>().Add(new AppUserRole
            {
                Restaurant = restaurant,
                RoleId = role.Id,
                UserId = user.Id
            });

            return Context.SaveChangesAsync();
        }
    }
}
