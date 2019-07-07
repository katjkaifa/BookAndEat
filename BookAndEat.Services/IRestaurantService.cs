using BookAndEat.DataModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookAndEat.Services
{
    public interface IRestaurantService
    {
        #region Restaurant
        Task<Restaurant> GetRestaurantById(int restaurntId);
        Task<int> SaveRestaurant(Restaurant restaurant);
        Task<List<Restaurant>> GetAllRestaurants();
        Task<Restaurant> DeleteRestaurant(int restaurantId);
        #endregion Restaurant

        #region RestaurantHall
        Task<RestaurantHall> GetRestaurantHallById(int restaurntHallId);
        Task<int> SaveRestaurantHall(RestaurantHall restaurantHall);
        Task<List<RestaurantHall>> GetAllRestaurantHalls();
        Task<RestaurantHall> DeleteRestaurantHall(int restaurantHallId);
        #endregion RestaurantHall

        #region RestaurantTable
        Task<RestaurantTable> GetRestaurantTableById(int restaurantTableId);
        Task<int> SaveRestaurantTable(RestaurantTable restaurantTable);
        Task<List<RestaurantTable>> GetAllRestaurantTables();
        Task<RestaurantTable> DeleteRestaurantTable(int restaurantTableId);
        #endregion RestaurantTable

        #region RestaurantPhoto
        Task<RestaurantPhoto> GetRestaurantPhotoById(int restaurntHallId);
        Task<int> SaveRestaurantPhoto(RestaurantPhoto restaurantPhoto);
        Task<List<RestaurantPhoto>> GetAllRestaurantPhotos();
        Task<RestaurantPhoto> DeleteRestaurantPhoto(int restaurantPhotoId);
        #endregion RestaurantPhoto

        #region Cuisine
        Task<Cuisine> GetCuisineById(int cuisineId);
        Task<int> SaveCuisine(Cuisine cuisine);
        Task<List<Cuisine>> GetAllCuisines();
        Task<Cuisine> DeleteCuisine(int cuisineId);
        #endregion Cuisine

        #region RestaurantCuisine
        Task<RestaurantCuisine> GetRestaurantCuisineById(int restaurantCuisineId);
        Task<int> SaveRestaurantCuisine(RestaurantCuisine restaurantCuisine);
        Task<List<RestaurantCuisine>> GetAllRestaurantCuisines();
        Task<RestaurantCuisine> DeleteRestaurantCuisine(int restaurantCuisineId);
        #endregion RestaurantCuisine

        #region Type
        Task<Type> GetTypeById(int typeId);
        Task<int> SaveType(Type type);
        Task<List<Type>> GetAllTypes();
        Task<Type> DeleteType(int typeId);
        #endregion Type

        #region RestaurantType
        Task<RestaurantType> GetRestaurantTypeById(int restaurantTypeId);
        Task<int> SaveRestaurantType(RestaurantType restaurantType);
        Task<List<RestaurantType>> GetAllRestaurantTypes();
        Task<RestaurantType> DeleteRestaurantType(int restaurantTypeId);
        #endregion RestaurantType
    }
}