using EcommerceAPI.Entities;

namespace EcommerceAPI.Interfaces
{
    public interface IOrderRepo
    {
        void PlaceOrder(Order order);
        Order ViewOrder(int OrderId);
        List<Order> ViewAllOrders();
    }
}
