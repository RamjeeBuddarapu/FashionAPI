using FashionHexa.Entities;

namespace FashionHexa.Services
{
    public class IOrderService
    {
        void PlaceOrder(Order order);
        Order GetOrder(Guid orderId);
        List<Order> GetOrdersByUser(string userId); 
        List<Order> GetOrders(); 
    }
}
