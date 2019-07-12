using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndEat.Services
{
    public class OrderService : IOrderService
    {
        #region Order
        public async Task<Order> GetOrderById(int orderId)
        {

        }

        public async Task<int> SaveOrder(Order order)
        {

        }

        public async Task<List<Order>> GetAllOrders()
        {

        }

        public async Task<Order> DeleteOrder(int orderId)
        {

        }
        #endregion Order

        #region OrderDetail
        Task<OrderDetail> GetOrderDetailById(int orderDetailId);
        Task<int> SaveOrderDetail(OrderDetail orderDetail);
        Task<List<OrderDetail>> GetAllOrderDetails();
        Task<OrderDetail> DeleteOrderDetail(int orderDetailId);
        #endregion OrderDetail

        #region OrderTable
        Task<OrderTable> GetOrderTableById(int orderTableId);
        Task<int> SaveOrderTable(OrderTable orderTable);
        Task<List<OrderTable>> GetAllOrderTables();
        Task<OrderTable> DeleteOrderTable(int orderTableId);
        #endregion OrderTable

        #region OrderWaiter
        Task<OrderWaiter> GetOrderWaiterById(int orderWaiterId);
        Task<int> SaveOrderWaiter(OrderWaiter orderWaiter);
        Task<List<OrderWaiter>> GetAllOrderWaiters();
        Task<OrderWaiter> DeleteOrderWaiter(int orderWaiterId);
        #endregion OrderWaiter
    }
}
