using SnackbarB2C2Library;

namespace SnackbarB2C2.Models
{
    public class OrdersVMOrderProduct
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }

        public OrdersVMOrderProduct(int productId, int orderId)
        {
            ProductId = productId;
            OrderId = orderId;
        }
    }
}
