using BookAndEat.DataAccess;
using BookAndEat.DataModels;
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
            Order result = dbContext.Orders.Where(x => x.Id == orderId).FirstOrDefault();
            return await Task.FromResult(result);
        }

        public async Task<int> SaveOrder(Order order)
        {
            if (order.Id == 0)
            {
                dbContext.Orders.Add(order);
            }
            else
            {
                Order dbEntry = dbContext.Orders.Find(order.Id);
                if (dbEntry != null)
                {
                    dbEntry.DateTimeTo = order.DateTimeTo;
                    dbEntry.IsConfirmed = order.IsConfirmed;
                    dbEntry.Phone = order.Phone;
                    dbEntry.IsToGo = order.IsToGo;
                    dbEntry.Details = order.Details;
                }
            }

            await dbContext.SaveChangesAsync();

            return order.Id;
        }

        public async Task<List<Order>> GetAllOrders()
        {
            List<Order> result = null;

            result = dbContext.Orders.ToList();

            return await Task.FromResult(result);
        }

        public async Task<Order> DeleteOrder(int orderId)
        {
            Order dbEntry = dbContext.Orders.Find(orderId);
            if (dbEntry != null)
            {
                dbContext.Orders.Remove(dbEntry);
            }

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
            OrderTable result = dbContext.OrderTables.Where(x => x.Id == orderTableId).FirstOrDefault();
            return await Task.FromResult(result);
        }

        public async Task<int> SaveOrderTable(OrderTable orderTable)
        {
            if (orderTable.Id == 0)
            {
                dbContext.OrderTables.Add(orderTable);
            }
            //else
            //{
            //    OrderTable dbEntry = dbContext.OrderTables.Find(orderTable.Id);
            //    if (dbEntry != null)
            //    {
            //        dbEntry.DateTimeTo = order.DateTimeTo;
            //        dbEntry.IsConfirmed = order.IsConfirmed;
            //        dbEntry.Phone = order.Phone;
            //        dbEntry.IsToGo = order.IsToGo;
            //        dbEntry.Details = order.Details;
            //    }
            //}

            await dbContext.SaveChangesAsync();

            return orderTable.Id;
        }

        public async Task<List<OrderTable>> GetAllOrderTables()
        {
            List<OrderTable> result = null;

            result = dbContext.OrderTables.ToList();

            return await Task.FromResult(result);
        }

        public async Task<OrderTable> DeleteOrderTable(int orderTableId)
        {
            OrderTable dbEntry = dbContext.OrderTables.Find(orderTableId);
            if (dbEntry != null)
            {
                dbContext.OrderTables.Remove(dbEntry);
            }

            await dbContext.SaveChangesAsync();

            return dbEntry;
        }
        #endregion OrderTable

        #region OrderWaiter
        public async Task<OrderWaiter> GetOrderWaiterById(int orderWaiterId)
        {
            OrderWaiter result = dbContext.OrderWaiters.Where(x => x.Id == orderWaiterId).FirstOrDefault();
            return await Task.FromResult(result);
        }

        public async Task<int> SaveOrderWaiter(OrderWaiter orderWaiter)
        {
            if (orderWaiter.Id == 0)
            {
                dbContext.OrderWaiters.Add(orderWaiter);
            }
            //else
            //{
            //    OrderWaiter dbEntry = dbContext.OrderWaiters.Find(orderWaiter.Id);
            //    if (dbEntry != null)
            //    {
            //        dbEntry.DateTimeTo = order.DateTimeTo;
            //        dbEntry.IsConfirmed = order.IsConfirmed;
            //        dbEntry.Phone = order.Phone;
            //        dbEntry.IsToGo = order.IsToGo;
            //        dbEntry.Details = order.Details;
            //    }
            //}

            await dbContext.SaveChangesAsync();

            return orderWaiter.Id;
        }

        public async Task<List<OrderWaiter>> GetAllOrderWaiters()
        {
            List<OrderWaiter> result = null;

            result = dbContext.OrderWaiters.ToList();

            return await Task.FromResult(result);
        }

        public async Task<OrderWaiter> DeleteOrderWaiter(int orderWaiterId)
        {
            OrderWaiter dbEntry = dbContext.OrderWaiters.Find(orderWaiterId);
            if (dbEntry != null)
            {
                dbContext.OrderWaiters.Remove(dbEntry);
            }

            await dbContext.SaveChangesAsync();

            return dbEntry;
        }
        #endregion OrderWaiter
    }
}
