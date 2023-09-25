using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SnackbarB2C2Library
{
    public class Order
    {
        // Properties
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Currency)]
        public float Cost {  get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateOfOrder { get; set; }

        public bool? IsFavorited { get; set; }

        public string? Status { get; set; }

        // Relational Properties
        public Customer Customer { get; set; }

        [ForeignKey("Customer")]
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
