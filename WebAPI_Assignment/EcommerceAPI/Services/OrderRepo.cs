using EcommerceAPI.Database;
using EcommerceAPI.Entities;
using EcommerceAPI.Interfaces;

namespace EcommerceAPI.Services
{
    public class OrderRepo : IOrderRepo
    {
        private EcommerceDbContext Context { get; set; }

        public OrderRepo()
        {
            Context = new EcommerceDbContext();
        }

        public void PlaceOrder(Order order)
        {
            Context.OrderList.Add(order);
            Context.SaveChanges();
        }

        public List<Order> ViewAllOrders()
        {
            return Context.OrderList.ToList();
        }

        public Order ViewOrder(int id)
        {
            return Context.OrderList.SingleOrDefault(order => order.OrderId == id);
          
        }
    }
}
