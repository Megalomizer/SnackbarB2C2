namespace SnackbarB2C2.Models
{
    public class Transaction
    {
        // Properties
        public int Id { get; set; }
        public float Cost { get; set; }
        public int Discount { get; set; }
        public DateTime DateOfTransaction { get; set; }

        // Relational Properties
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }

        // Constructor
        public Transaction() { }
        public Transaction(int id, float cost, int discount,  DateTime dateOfTransaction, Customer customer, Order order)
        {
            Id = id;
            Cost = cost;
            Discount = discount;
            DateOfTransaction = dateOfTransaction;
            Customer = customer;
            Order = order;
        }
    }
}
