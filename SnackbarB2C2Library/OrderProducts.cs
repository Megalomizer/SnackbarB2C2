using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackbarB2C2Library
{
    internal class OrderProducts
    {
        public Order Order { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }

        public OrderProducts(Order order, Product product, int amount)
        {
            Order = order;
            Product = product;
            Amount = amount;
        }
    }
}
