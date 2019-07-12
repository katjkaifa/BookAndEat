using BookAndEat.DataAccess;
using BookAndEat.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAndEat.Services
{
    public class DishService: IDishService
    {
        private readonly ApplicationDbContext dbContext;
        public DishService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        #region Dish
        public async Task<Dish> GetDishById(int dishId)
        {
            Dish result = dbContext.Dishes.Where(x => x.Id == dishId).FirstOrDefault();
            return await Task.FromResult(result);
        }

        public async Task<int> SaveDish(Dish dish)
        {
            if (dish.Id == 0)
            {
                dbContext.Dishes.Add(dish);
            }
            else
            {
                Dish dbEntry = dbContext.Dishes.Find(dish.Id);
                if (dbEntry != null)
                {
                    dbEntry.Name = dish.Name;
                    dbEntry.Description = dish.Description;
                    dbEntry.Price = dish.Price;
                    dbEntry.IsInMenu = dish.IsInMenu;
                    dbEntry.Photo = dish.Photo;
                }
            }

            await dbContext.SaveChangesAsync();

            return dish.Id;
        }

        public async Task<List<Dish>> GetAllDishes()
        {
            List<Dish> result = null;

            result = dbContext.Dishes.ToList();

            return await Task.FromResult(result);
        }

        public async Task<Dish> DeleteDish(int dishId)
        {
            Dish dbEntry = dbContext.Dishes.Find(dishId);
            if (dbEntry != null)
            {
                dbContext.Dishes.Remove(dbEntry);
            }

            await dbContext.SaveChangesAsync();

            return dbEntry;
        }
        #endregion Dish

        #region DishCategory
        public async Task<DishCategory> GetDishCategoryById(int dishCategoryId)
        {
            DishCategory result = dbContext.DishCategories.Where(x => x.Id == dishCategoryId).FirstOrDefault();
            return await Task.FromResult(result);
        }

        public async Task<int> SaveDishCategory(DishCategory dishCategory)
        {
            if (dishCategory.Id == 0)
            {
                dbContext.DishCategories.Add(dishCategory);
            }
            else
            {
                DishCategory dbEntry = dbContext.DishCategories.Find(dishCategory.Id);
                if (dbEntry != null)
                {
                    dbEntry.Name = dishCategory.Name;
                }
            }

            await dbContext.SaveChangesAsync();

            return dishCategory.Id;
        }

        public async Task<List<DishCategory>> GetAllDishCategories()
        {
            List<DishCategory> result = null;

            result = dbContext.DishCategories.ToList();

            return await Task.FromResult(result);
        }

        public async Task<DishCategory> DeleteDishCategory(int dishCategoryId)
        {
            DishCategory dbEntry = dbContext.DishCategories.Find(dishCategoryId);
            if (dbEntry != null)
            {
                dbContext.DishCategories.Remove(dbEntry);
            }

            await dbContext.SaveChangesAsync();

            return dbEntry;
        }
        #endregion DishCategory

        #region DishContaining
        public async Task<DishContaining> GetDishContainingById(int dishContainingId)
        {
            DishContaining result = dbContext.DishContainings.Where(x => x.Id == dishContainingId).FirstOrDefault();
            return await Task.FromResult(result);
        }

        public async Task<int> SaveDishContaining(DishContaining dishContaining)
        {
            if (dishContaining.Id == 0)
            {
                dbContext.DishContainings.Add(dishContaining);
            }
            else
            {
                DishContaining dbEntry = dbContext.DishContainings.Find(dishContaining.Id);
                if (dbEntry != null)
                {
                    dbEntry.Quantity = dishContaining.Quantity;
                }
            }

            await dbContext.SaveChangesAsync();

            return dishContaining.Id;
        }

        public async Task<List<DishContaining>> GetDishContainings()
        {
            List<DishContaining> result = null;

            result = dbContext.DishContainings.ToList();

            return await Task.FromResult(result);
        }

        public async Task<DishContaining> DeleteDishContaining(int dishContainingId)
        {
            DishContaining dbEntry = dbContext.DishContainings.Find(dishContainingId);
            if (dbEntry != null)
            {
                dbContext.DishContainings.Remove(dbEntry);
            }

            await dbContext.SaveChangesAsync();

            return dbEntry;
        }
        #endregion DishContaining
    }
}
