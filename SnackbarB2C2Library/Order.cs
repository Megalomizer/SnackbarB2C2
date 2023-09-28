using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

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
        public Customer Customer { get; set; } // When its a single object, it can be only the object, no seperate id

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual ICollection<Product> Products { get; set; } = new List<Product>(); // when its a list, it needs a seperate id property

        //  **Constructors**
        // Empty
        public Order() { }
        // For main use
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
        // For in the db
        public Order(int id, float cost, DateTime dateoforder, Customer customer, bool? isfavorited, string? status)
        {
            Id = id;
            Cost = cost;
            DateOfOrder = dateoforder;
            Customer = customer;
            IsFavorited = isfavorited;
            Status = status;
        }
    }
}
