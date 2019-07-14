using BookAndEat.DataModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookAndEat.Services
{
    public interface IOrderService
    {
        #region Order
        Task<Order> GetOrderById(int orderId);
        Task<int> SaveOrder(Order order);
        Task<List<Order>> GetAllOrders();
        Task<Order> DeleteOrder(int orderId);
        #endregion Order

        #region OrderDetail
        //Task<OrderDetail> GetOrderDetailById(int orderDetailId);
        //Task<int> SaveOrderDetail(OrderDetail orderDetail);
        //Task<List<OrderDetail>> GetAllOrderDetails();
        //Task<OrderDetail> DeleteOrderDetail(int orderDetailId);
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
