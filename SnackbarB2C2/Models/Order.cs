using Microsoft.AspNetCore.Localization;

namespace SnackbarB2C2.Models
{
    public class Order
    {
        // Properties
        public int Id { get; set; }
        public float Cost {  get; set; }
        public DateTime DateOfOrder { get; set; }
        public bool IsFavorited { get; set; }
        public string Status { get; set; }

        // Relational Properties
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();

        // Constructor
        public Order() { }
        public Order(int id, float cost, DateTime dateoforder, Customer customer, ICollection<Product> products, bool isfavorited = false, string status = "to do")
        {
            Id = id;
            Cost = cost;
            DateOfOrder = dateoforder;
            Customer = customer;
            Products = products;
            IsFavorited = isfavorited;
            Status = status;
        }
    }
}
