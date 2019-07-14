using BookAndEat.DataModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookAndEat.Services
{
    public interface IUserService
    {
        #region UserComment
        Task<UserComment> GetUserCommenttById(int userCommentId);
        Task<int> SaveUserComment(UserComment userComment);
        Task<List<UserComment>> GetAllUserComments();
        Task<UserComment> DeleteUserComment(int userCommentId);
        #endregion UserComment

        #region UserFavourite
        Task<UserFavourite> GetUserFavouriteById(int userFavouriteId);
        Task<int> SaveUserFavourite(UserFavourite userFavourite);
        Task<List<UserFavourite>> GetAllUserFavourites();
        Task<UserFavourite> DeleteUserFavourite(int userFavouriteId);
        #endregion UserFavourite

        #region UserFavouriteDish
        Task<UserFavouriteDish> GetUserFavouriteDishById(int userFavouriteDishId);
        Task<int> SaveUserFavouriteDish(UserFavouriteDish userFavouriteDish);
        Task<List<UserFavouriteDish>> GetAllUserFavouriteDishes();
        Task<UserFavouriteDish> DeleteUserFavouriteDish(int userFavouriteDishId);
        #endregion UserFavourite
    }
}