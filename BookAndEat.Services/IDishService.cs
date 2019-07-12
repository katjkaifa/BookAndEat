using BookAndEat.DataModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookAndEat.Services
{
    public interface IDishService
    {
        #region Dish
        Task<Dish> GetDishById(int dishId);
        Task<int> SaveDish(Dish dish);
        Task<List<Dish>> GetAllDishes();
        Task<Dish> DeleteDish(int dishId);
        #endregion Dish

        #region DishCategory
        Task<DishCategory> GetDishCategoryById(int dishCategoryId);
        Task<int> SaveDishCategory(DishCategory dishCategory);
        Task<List<DishCategory>> GetAllDishCategories();
        Task<DishCategory> DeleteDishCategory(int dishCategoryId);
        #endregion DishCategory

        #region DishContaining
        Task<DishContaining> GetDishContainingById(int dishContainingId);
        Task<int> SaveDishContaining(DishContaining dishContaining);
        Task<List<DishContaining>> GetDishContainings();
        Task<DishContaining> DeleteDishContaining(int dishContainingId);
        #endregion DishContaining
    }
}
