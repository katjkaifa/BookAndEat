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
    public class OrderService : IOrderService
    {
        private readonly ApplicationDbContext dbContext;
        public OrderService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        #region Order
        public async Task<Order> GetOrderById(int orderId)
        {
            return await dbContext.Orders.Where(x => x.Id == orderId).FirstOrDefaultAsync();
        }

        public async Task<int> SaveOrder(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order), "Parameter is null");
            }
            if (order.Id == 0)
            {
                dbContext.Orders.Add(order);
            }
            else
            {
                Order dbEntry = dbContext.Orders.Find(order.Id);
                if (dbEntry == null)
                {
                    throw new InvalidOperationException("Order not found");
                }
                dbEntry.DateTimeTo = order.DateTimeTo;
                dbEntry.IsConfirmed = order.IsConfirmed;
                dbEntry.Phone = order.Phone;
                dbEntry.IsToGo = order.IsToGo;
                dbEntry.Details = order.Details;
            }

            await dbContext.SaveChangesAsync();
            return order.Id;
        }

        public async Task<List<Order>> GetAllOrders()
        {
            return await dbContext.Orders.ToListAsync();
        }

        public async Task<Order> DeleteOrder(int orderId)
        {
            Order dbEntry = dbContext.Orders.Find(orderId);
            if (dbEntry == null)
            {
                throw new InvalidOperationException("Order not found");
            }
            dbContext.Orders.Remove(dbEntry);

            await dbContext.SaveChangesAsync();
            return dbEntry;
        }
        #endregion Order

        #region OrderDetail
        //public async Task<OrderDetail> GetOrderDetailById(int orderDetailId)
        //{
        //    OrderDetail result = dbContext.Order.Where(x => x.Id == orderId).FirstOrDefault();
        //    return await Task.FromResult(result);
        //}

        //public async Task<int> SaveOrderDetail(OrderDetail orderDetail)
        //{
        //    if (order.Id == 0)
        //    {
        //        dbContext.Orders.Add(order);
        //    }
        //    else
        //    {
        //        Order dbEntry = dbContext.Orders.Find(order.Id);
        //        if (dbEntry != null)
        //        {
        //            dbEntry.DateTimeTo = order.DateTimeTo;
        //            dbEntry.IsConfirmed = order.IsConfirmed;
        //            dbEntry.Phone = order.Phone;
        //            dbEntry.IsToGo = order.IsToGo;
        //            dbEntry.Details = order.Details;
        //        }
        //    }

        //    await dbContext.SaveChangesAsync();

        //    return order.Id;
        //}

        //public async Task<List<OrderDetail>> GetAllOrderDetails()
        //{
        //    List<Order> result = null;

        //    result = dbContext.Orders.ToList();

        //    return await Task.FromResult(result);
        //}

        //public async Task<OrderDetail> DeleteOrderDetail(int orderDetailId)
        //{
        //    Order dbEntry = dbContext.Orders.Find(orderId);
        //    if (dbEntry != null)
        //    {
        //        dbContext.Orders.Remove(dbEntry);
        //    }

        //    await dbContext.SaveChangesAsync();

        //    return dbEntry;
        //}
        #endregion OrderDetail

        #region OrderTable
        public async Task<OrderTable> GetOrderTableById(int orderTableId)
        {
            return await dbContext.OrderTables
                .Where(x => x.Id == orderTableId)
                .FirstOrDefaultAsync();
        }

        public async Task<int> SaveOrderTable(OrderTable orderTable)
        {
            if (orderTable == null)
            {
                throw new ArgumentNullException(nameof(orderTable), "Parameter is null");
            }
            if (orderTable.Id == 0)
            {
                dbContext.OrderTables.Add(orderTable);
            }

            await dbContext.SaveChangesAsync();
            return orderTable.Id;
        }

        public async Task<List<OrderTable>> GetAllOrderTables()
        {
            return await dbContext.OrderTables.ToListAsync();
        }

        public async Task<OrderTable> DeleteOrderTable(int orderTableId)
        {
            OrderTable dbEntry = dbContext.OrderTables.Find(orderTableId);
            if (dbEntry == null)
            {
                throw new InvalidOperationException("Order table not found");
            }
            dbContext.OrderTables.Remove(dbEntry);

            await dbContext.SaveChangesAsync();
            return dbEntry;
        }
        #endregion OrderTable

        #region OrderWaiter
        public async Task<OrderWaiter> GetOrderWaiterById(int orderWaiterId)
        {
            return await dbContext.OrderWaiters
                .Where(x => x.Id == orderWaiterId)
                .FirstOrDefaultAsync();
        }

        public async Task<int> SaveOrderWaiter(OrderWaiter orderWaiter)
        {
            if (orderWaiter == null)
            {
                throw new ArgumentNullException(nameof(orderWaiter), "Parameter is null");
            }
            if (orderWaiter.Id == 0)
            {
                dbContext.OrderWaiters.Add(orderWaiter);
            }

            await dbContext.SaveChangesAsync();
            return orderWaiter.Id;
        }

        public async Task<List<OrderWaiter>> GetAllOrderWaiters()
        {
            return await dbContext.OrderWaiters.ToListAsync();
        }

        public async Task<OrderWaiter> DeleteOrderWaiter(int orderWaiterId)
        {
            OrderWaiter dbEntry = dbContext.OrderWaiters.Find(orderWaiterId);
            if (dbEntry == null)
            {
                throw new InvalidOperationException("Order waiter not found");
            }
            dbContext.OrderWaiters.Remove(dbEntry);

            await dbContext.SaveChangesAsync();
            return dbEntry;
        }
        #endregion OrderWaiter
    }
}
