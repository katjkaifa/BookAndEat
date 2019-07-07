using BookAndEat.DataAccess;
using BookAndEat.Web.Data;
using System;
using System.Threading.Tasks;

namespace BookAndEat.Services
{
    public class UserService: IUserService
    {
        private readonly ApplicationDbContext dbContext;
        public UserService(ApplicationDbContext dbContext)
        {
            dbContext = dbContext;
        }

        public async Task Foo()
        {
            return; // await Task.CompletedTask;
        }
    }
}
