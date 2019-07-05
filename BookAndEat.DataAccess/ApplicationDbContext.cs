using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BookAndEat.DataModels;
using BookAndEat.DataModels.Infrastructure;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookAndEat.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //public DbSet<Restaurant> Restaurants { get; set; }
        //public DbSet<Cuisine> Cuisines { get; set; }
        //public DbSet<RestaurantCuisine> RestaurantCuisines { get; set; }
        //public DbSet<DataModels.Type> Types { get; set; }
        //public DbSet<RestaurantType> RestaurantTypes { get; set; }
        //public DbSet<RestaurantHall> RestaurantHalls { get; set; }
        //public DbSet<RestaurantTable> RestaurantTables { get; set; }
        //public DbSet<RestaurantPhoto> RestaurantPhotos { get; set; }

        //public DbSet<Dish> Dishes { get; set; }
        //public DbSet<DishCategory> DishCategories { get; set; }
        //public DbSet<DishContaining> DishContainings { get; set; }

        //public DbSet<Product> Products { get; set; }

        //public DbSet<Order> Orders { get; set; }
        //public DbSet<OrderDetail> OrderDetails { get; set; }
        //public DbSet<OrderTable> OrderTables { get; set; }
        //public DbSet<OrderWaiter> OrderWaiters { get; set; }

        //public DbSet<Invoice> Invoices { get; set; }
        //public DbSet<InvoiceProduct> InvoiceProducts { get; set; }
        //public DbSet<Supplier> Suppliers { get; set; }

        //public DbSet<UserComment> UserComments { get; set; }
        //public DbSet<UserFavourite> UserFavourites { get; set; }
        //public DbSet<UserFavouriteDish> UserFavouriteDishes { get; set; }
        //public DbSet<UserRestaurant> UserRestaurants { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<AppUser>()
        //        .HasKey(x => new { x.Id, x.PhoneNumber, x.UserName });

        //    builder.Entity<Order>()
        //        .Property(x => x.Phone)
        //        .IsRequired();
        //}

        //public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var selectedEntityList = ChangeTracker.Entries();

        //    foreach (var entity in selectedEntityList)
        //    {
        //        if (entity is IHasCreationTime)
        //        {
        //            ((IHasCreationTime)entity).CreationTime = DateTime.UtcNow;
        //        }
        //        if (entity is IHasModificationTime)
        //        {
        //            ((IHasModificationTime)entity).LastModificationTime = DateTime.UtcNow;
        //        }
        //    }
        //    return base.SaveChangesAsync(cancellationToken);
        //}
    }
}
