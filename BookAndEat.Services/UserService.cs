using BookAndEat.DataAccess;
using BookAndEat.DataModels;
using BookAndEat.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAndEat.Services
{
    public class UserService//: IUserService
    {
        private readonly ApplicationDbContext dbContext;
        public UserService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //#region UserComment
        //public async Task<UserComment> GetUserCommenttById(int restaurntId)
        //{
        //    UserComment result = dbContext.UserComments.Where(x => x.Id == restaurntId).FirstOrDefault();
        //    return await Task.FromResult(result);
        //}

        //public async Task<int> SaveUserComment(UserComment userComment)
        //{
        //    if (restaurant.Id == 0)
        //    {
        //        dbContext.Restaurants.Add(restaurant);
        //    }
        //    else
        //    {
        //        Restaurant dbEntry = dbContext.Restaurants.Find(restaurant.Id);
        //        if (dbEntry != null)
        //        {
        //            dbEntry.Name = restaurant.Name;
        //            dbEntry.ShortDescription = restaurant.ShortDescription;
        //            dbEntry.LongDescription = restaurant.LongDescription;
        //            dbEntry.Photo = restaurant.Photo;
        //        }
        //    }

        //    await dbContext.SaveChangesAsync();

        //    return restaurant.Id;
        //}

        //public async Task<List<UserComment>> GetAllUserComments()
        //{
        //    List<Restaurant> result = null;

        //    result = dbContext.Restaurants.ToList();

        //    return await Task.FromResult(result);
        //}

        //public async Task<UserComment> DeleteUserComment(int userCommentId)
        //{
        //    Restaurant dbEntry = dbContext.Restaurants.Find(restaurantId);
        //    if (dbEntry != null)
        //    {
        //        dbContext.Restaurants.Remove(dbEntry);
        //    }

        //    await dbContext.SaveChangesAsync();

        //    return dbEntry;
        //}
        //#endregion UserComment

        //#region UserFavourite
        //public async Task<UserFavourite> GetUserFavouriteById(int userFavouriteId)
        //{

        //}

        //public async Task<int> SaveUserFavourite(UserFavourite userFavourite)
        //{

        //}

        //public async Task<List<UserFavourite>> GetAllUserFavourites()
        //{

        //}

        //public async Task<UserFavourite> DeleteUserFavourite(int userFavouriteId)
        //{

        //}
        //#endregion UserFavourite

        //#region UserFavouriteDish
        //public async Task<UserFavouriteDish> GetUserFavouriteDishById(int userFavouriteDishId)
        //{

        //}

        //public async Task<int> SaveUserFavouriteDish(UserFavouriteDish userFavouriteDish)
        //{

        //}

        //public async Task<List<UserFavouriteDish>> GetAllUserFavouriteDishes()
        //{

        //}

        //public async Task<UserFavouriteDish> DeleteUserFavouriteDish(int userFavouriteDishId)
        //{

        //}
        //#endregion UserFavourite
    }
}
