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
    public class DishService : IDishService
    {
        private readonly ApplicationDbContext dbContext;
        public DishService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        #region Dish
        public async Task<Dish> GetDishById(int dishId)
        {
            return await dbContext.Dishes
                .Where(x => x.Id == dishId)
                .FirstOrDefaultAsync();
        }

        public async Task<int> SaveDish(Dish dish)
        {
            if (dish == null)
            {
                throw new ArgumentNullException(nameof(dish), "Parameter is null");
            }
            if (dish.Id == 0)
            {
                dbContext.Dishes.Add(dish);
            }
            else
            {
                Dish dbEntry = dbContext.Dishes.Find(dish.Id);
                if (dbEntry == null)
                {
                    throw new InvalidOperationException("Dish not found");
                }
                dbEntry.Name = dish.Name;
                dbEntry.Description = dish.Description;
                dbEntry.Price = dish.Price;
                dbEntry.IsInMenu = dish.IsInMenu;
                dbEntry.Photo = dish.Photo;
            }

            await dbContext.SaveChangesAsync();
            return dish.Id;
        }

        public async Task<List<Dish>> GetAllDishes()
        {
            return await dbContext.Dishes.ToListAsync();
        }

        public async Task<Dish> DeleteDish(int dishId)
        {
            Dish dbEntry = dbContext.Dishes.Find(dishId);
            if (dbEntry == null)
            {
                throw new InvalidOperationException("Dish not found");
            }
            dbContext.Dishes.Remove(dbEntry);

            await dbContext.SaveChangesAsync();
            return dbEntry;
        }
        #endregion Dish

        #region DishCategory
        public async Task<DishCategory> GetDishCategoryById(int dishCategoryId)
        {
            return await dbContext.DishCategories
                .Where(x => x.Id == dishCategoryId)
                .FirstOrDefaultAsync();
        }

        public async Task<int> SaveDishCategory(DishCategory dishCategory)
        {
            if (dishCategory == null)
            {
                throw new ArgumentNullException(nameof(dishCategory), "Parameter is null");
            }
            if (dishCategory.Id == 0)
            {
                dbContext.DishCategories.Add(dishCategory);
            }
            else
            {
                DishCategory dbEntry = dbContext.DishCategories.Find(dishCategory.Id);
                if (dbEntry == null)
                {
                    throw new InvalidOperationException("Dish category not found");
                }
                dbEntry.Name = dishCategory.Name;
            }

            await dbContext.SaveChangesAsync();
            return dishCategory.Id;
        }

        public async Task<List<DishCategory>> GetAllDishCategories()
        {
            return await dbContext.DishCategories.ToListAsync();
        }

        public async Task<DishCategory> DeleteDishCategory(int dishCategoryId)
        {
            DishCategory dbEntry = dbContext.DishCategories.Find(dishCategoryId);
            if (dbEntry == null)
            {
                throw new InvalidOperationException("Dish category not found");
            }
            dbContext.DishCategories.Remove(dbEntry);

            await dbContext.SaveChangesAsync();
            return dbEntry;
        }
        #endregion DishCategory

        #region DishContaining
        public async Task<DishContaining> GetDishContainingById(int dishContainingId)
        {
            return await dbContext.DishContainings
                .Where(x => x.Id == dishContainingId)
                .FirstOrDefaultAsync();
        }

        public async Task<int> SaveDishContaining(DishContaining dishContaining)
        {
            if (dishContaining == null)
            {
                throw new ArgumentNullException(nameof(dishContaining), "Parameter is null");
            }
            if (dishContaining.Id == 0)
            {
                dbContext.DishContainings.Add(dishContaining);
            }
            else
            {
                DishContaining dbEntry = dbContext.DishContainings.Find(dishContaining.Id);
                if (dbEntry == null)
                {
                    throw new InvalidOperationException("Dish containing not found");
                }
                dbEntry.Quantity = dishContaining.Quantity;
            }

            await dbContext.SaveChangesAsync();
            return dishContaining.Id;
        }

        public async Task<List<DishContaining>> GetDishContainings()
        {
            return await dbContext.DishContainings.ToListAsync();
        }

        public async Task<DishContaining> DeleteDishContaining(int dishContainingId)
        {
            DishContaining dbEntry = dbContext.DishContainings.Find(dishContainingId);
            if (dbEntry == null)
            {
                throw new InvalidOperationException("Dish containing not found");
            }
            dbContext.DishContainings.Remove(dbEntry);

            await dbContext.SaveChangesAsync();
            return dbEntry;
        }
        #endregion DishContaining
    }
}
