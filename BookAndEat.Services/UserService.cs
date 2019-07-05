using BookAndEat.DataAccess;
using BookAndEat.Web.Data;
using System;
using System.Threading.Tasks;

namespace BookAndEat.Services
{
    public class UserService: IUserService
    {
        private readonly ApplicationDbContext _dbContext;
        public UserService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Foo()
        {
            return; // await Task.CompletedTask;
        }
    }
}
