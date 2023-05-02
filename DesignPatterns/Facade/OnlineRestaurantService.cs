using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class OnlineRestaurantService
    {
        private readonly List<Order> _cart;

        public OnlineRestaurantService()
        {
            _cart = new List<Order>();
        }

        public void AddOrderToCart(Order order)
        {
            _cart.Add(order);
        }

        public void CompleteOrders()
        {
            Console.WriteLine("Orders completed. Dispatch in progress...");
        }
    }
}
