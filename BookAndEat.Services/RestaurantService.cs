using BookAndEat.DataAccess;
using BookAndEat.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAndEat.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly ApplicationDbContext dbContext;
        public RestaurantService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        #region Restaurant
        public async Task<Restaurant> GetRestaurantById(int restaurntId)
        {
            Restaurant result = await dbContext.Restaurants
                .Where(x => x.Id == restaurntId)
                .FirstOrDefaultAsync();
            return result;
        }
        public async Task<int> SaveRestaurant(Restaurant restaurant)
        {
            if (restaurant == null)
            {
                throw new ArgumentNullException(nameof(restaurant), "Parameter is null");
            }
            if (restaurant.Id == 0)
            {
                dbContext.Restaurants.Add(restaurant);
            }
            else
            {
                Restaurant dbEntry = dbContext.Restaurants.Find(restaurant.Id);
                if (dbEntry == null)
                {
                    throw new InvalidOperationException("Restaurant not found");
                }
                dbEntry.Name = restaurant.Name;
                dbEntry.ShortDescription = restaurant.ShortDescription;
                dbEntry.LongDescription = restaurant.LongDescription;
                dbEntry.Photo = restaurant.Photo;
            }

            await dbContext.SaveChangesAsync();

            return restaurant.Id;
        }
        public Task<List<Restaurant>> GetAllRestaurants()
        {
            return dbContext.Restaurants.ToListAsync();
        }
        public async Task<Restaurant> DeleteRestaurant(int restaurantId)
        {
            Restaurant dbEntry = await dbContext.Restaurants.FindAsync(restaurantId);
            if (dbEntry == null)
            {
                throw new InvalidOperationException("Restaurant not found");
            }
            dbContext.Restaurants.Remove(dbEntry);

            await dbContext.SaveChangesAsync();

            return dbEntry;
        }
        #endregion Restaurant

        #region RestaurantHall
        public async Task<RestaurantHall> GetRestaurantHallById(int restaurntHallId)
        {
            RestaurantHall result = dbContext.RestaurantHalls.Where(x => x.Id == restaurntHallId).FirstOrDefault();
            return await Task.FromResult(result);
        }
        public async Task<int> SaveRestaurantHall(RestaurantHall restaurantHall)
        {
            if (restaurantHall.Id == 0)
            {
                dbContext.RestaurantHalls.Add(restaurantHall);
            }
            else
            {
                RestaurantHall dbEntry = dbContext.RestaurantHalls.Find(restaurantHall.Id);
                if (dbEntry != null)
                {
                    dbEntry.Name = restaurantHall.Name;
                }
            }

            await dbContext.SaveChangesAsync();

            return restaurantHall.Id;
        }
        public async Task<List<RestaurantHall>> GetAllRestaurantHalls()
        {
            List<RestaurantHall> result = null;

            result = dbContext.RestaurantHalls.ToList();

            return await Task.FromResult(result);
        }
        public async Task<RestaurantHall> DeleteRestaurantHall(int restaurantHallId)
        {
            RestaurantHall dbEntry = dbContext.RestaurantHalls.Find(restaurantHallId);
            if (dbEntry != null)
            {
                dbContext.RestaurantHalls.Remove(dbEntry);
            }

            await dbContext.SaveChangesAsync();

            return dbEntry;
        }
        #endregion RestaurantHall

        #region RestaurantTable
        public async Task<RestaurantTable> GetRestaurantTableById(int restaurantTableId)
        {
            RestaurantTable result = dbContext.RestaurantTables.Where(x => x.Id == restaurantTableId).FirstOrDefault();
            return await Task.FromResult(result);
        }
        public async Task<int> SaveRestaurantTable(RestaurantTable restaurantTable)
        {
            if (restaurantTable.Id == 0)
            {
                dbContext.RestaurantTables.Add(restaurantTable);
            }
            else
            {
                RestaurantTable dbEntry = dbContext.RestaurantTables.Find(restaurantTable.Id);
                if (dbEntry != null)
                {
                    dbEntry.Name = restaurantTable.Name;
                }
            }

            await dbContext.SaveChangesAsync();

            return restaurantTable.Id;
        }
        public async Task<List<RestaurantTable>> GetAllRestaurantTables()
        {
            List<RestaurantTable> result = null;

            result = dbContext.RestaurantTables.ToList();

            return await Task.FromResult(result);
        }
        public async Task<RestaurantTable> DeleteRestaurantTable(int restaurantTableId)
        {
            RestaurantTable dbEntry = dbContext.RestaurantTables.Find(restaurantTableId);
            if (dbEntry != null)
            {
                dbContext.RestaurantTables.Remove(dbEntry);
            }

            await dbContext.SaveChangesAsync();

            return dbEntry;
        }
        #endregion RestaurantTable

        #region RestaurantPhoto
        public async Task<RestaurantPhoto> GetRestaurantPhotoById(int restaurntHallId)
        {
            RestaurantPhoto result = dbContext.RestaurantPhotos.Where(x => x.Id == restaurntHallId).FirstOrDefault();
            return await Task.FromResult(result);
        }
        public async Task<int> SaveRestaurantPhoto(RestaurantPhoto restaurantPhoto)
        {
            if (restaurantPhoto.Id == 0)
            {
                dbContext.RestaurantPhotos.Add(restaurantPhoto);
            }
            else
            {
                RestaurantPhoto dbEntry = dbContext.RestaurantPhotos.Find(restaurantPhoto.Id);
                if (dbEntry != null)
                {
                    dbEntry.Photo = restaurantPhoto.Photo;
                }
            }

            await dbContext.SaveChangesAsync();

            return restaurantPhoto.Id;
        }
        public async Task<List<RestaurantPhoto>> GetAllRestaurantPhotos()
        {
            List<RestaurantPhoto> result = null;

            result = dbContext.RestaurantPhotos.ToList();

            return await Task.FromResult(result);
        }
        public async Task<RestaurantPhoto> DeleteRestaurantPhoto(int restaurantPhotoId)
        {
            RestaurantPhoto dbEntry = dbContext.RestaurantPhotos.Find(restaurantPhotoId);
            if (dbEntry != null)
            {
                dbContext.RestaurantPhotos.Remove(dbEntry);
            }

            await dbContext.SaveChangesAsync();

            return dbEntry;
        }
        #endregion RestaurantPhoto

        #region Cuisine
        public async Task<Cuisine> GetCuisineById(int cuisineId)
        {
            Cuisine result = dbContext.Cuisines.Where(x => x.Id == cuisineId).FirstOrDefault();
            return await Task.FromResult(result);
        }
        public async Task<int> SaveCuisine(Cuisine cuisine)
        {
            if (cuisine.Id == 0)
            {
                dbContext.Cuisines.Add(cuisine);
            }
            else
            {
                Cuisine dbEntry = dbContext.Cuisines.Find(cuisine.Id);
                if (dbEntry != null)
                {
                    dbEntry.Name = cuisine.Name;
                }
            }

            await dbContext.SaveChangesAsync();

            return cuisine.Id;
        }
        public async Task<List<Cuisine>> GetAllCuisines()
        {
            List<Cuisine> result = null;

            result = dbContext.Cuisines.ToList();

            return await Task.FromResult(result);
        }
        public async Task<Cuisine> DeleteCuisine(int cuisineId)
        {
            Cuisine dbEntry = dbContext.Cuisines.Find(cuisineId);
            if (dbEntry != null)
            {
                dbContext.Cuisines.Remove(dbEntry);
            }

            await dbContext.SaveChangesAsync();

            return dbEntry;
        }
        #endregion Cuisine

        #region RestaurantCuisine
        public async Task<RestaurantCuisine> GetRestaurantCuisineById(int restaurantCuisineId)
        {
            RestaurantCuisine result = dbContext.RestaurantCuisines.Where(x => x.Id == restaurantCuisineId).FirstOrDefault();
            return await Task.FromResult(result);
        }
        public async Task<int> SaveRestaurantCuisine(RestaurantCuisine restaurantCuisine)
        {
            if (restaurantCuisine.Id == 0)
            {
                dbContext.RestaurantCuisines.Add(restaurantCuisine);
            }

            await dbContext.SaveChangesAsync();

            return restaurantCuisine.Id;
        }
        public async Task<List<RestaurantCuisine>> GetAllRestaurantCuisines()
        {
            List<RestaurantCuisine> result = null;

            result = dbContext.RestaurantCuisines.ToList();

            return await Task.FromResult(result);
        }
        public async Task<RestaurantCuisine> DeleteRestaurantCuisine(int restaurantCuisineId)
        {
            RestaurantCuisine dbEntry = dbContext.RestaurantCuisines.Find(restaurantCuisineId);
            if (dbEntry != null)
            {
                dbContext.RestaurantCuisines.Remove(dbEntry);
            }

            await dbContext.SaveChangesAsync();

            return dbEntry;
        }
        #endregion RestaurantCuisine

        #region Type
        public async Task<DataModels.Type> GetTypeById(int typeId)
        {
            DataModels.Type result = dbContext.Types.Where(x => x.Id == typeId).FirstOrDefault();
            return await Task.FromResult(result);
        }
        public async Task<int> SaveType(DataModels.Type type)
        {
            if (type.Id == 0)
            {
                dbContext.Types.Add(type);
            }
            else
            {
                DataModels.Type dbEntry = dbContext.Types.Find(type.Id);
                if (dbEntry != null)
                {
                    dbEntry.Name = type.Name;
                }
            }

            await dbContext.SaveChangesAsync();

            return type.Id;
        }
        public async Task<List<DataModels.Type>> GetAllTypes()
        {
            List<DataModels.Type> result = null;

            result = dbContext.Types.ToList();

            return await Task.FromResult(result);
        }
        public async Task<DataModels.Type> DeleteType(int typeId)
        {
            DataModels.Type dbEntry = dbContext.Types.Find(typeId);
            if (dbEntry != null)
            {
                dbContext.Types.Remove(dbEntry);
            }

            await dbContext.SaveChangesAsync();

            return dbEntry;
        }
        #endregion Type

        #region RestaurantType
        public async Task<RestaurantType> GetRestaurantTypeById(int restaurantTypeId)
        {
            RestaurantType result = dbContext.RestaurantTypes.Where(x => x.Id == restaurantTypeId).FirstOrDefault();
            return await Task.FromResult(result);
        }
        public async Task<int> SaveRestaurantType(RestaurantType restaurantType)
        {
            if (restaurantType.Id == 0)
            {
                dbContext.RestaurantTypes.Add(restaurantType);
            }

            await dbContext.SaveChangesAsync();

            return restaurantType.Id;
        }
        public async Task<List<RestaurantType>> GetAllRestaurantTypes()
        {
            List<RestaurantType> result = null;

            result = dbContext.RestaurantTypes.ToList();

            return await Task.FromResult(result);
        }
        public async Task<RestaurantType> DeleteRestaurantType(int restaurantTypeId)
        {
            RestaurantType dbEntry = dbContext.RestaurantTypes.Find(restaurantTypeId);
            if (dbEntry != null)
            {
                dbContext.RestaurantTypes.Remove(dbEntry);
            }

            await dbContext.SaveChangesAsync();

            return dbEntry;
        }
        #endregion RestaurantType
    }
}
