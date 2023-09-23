﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SnackbarB2C2.Models
{
    public class Transaction
    {
        // Properties
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Currency)]
        public float Cost { get; set; }
        public int? Discount { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateOfTransaction { get; set; }

        // Relational Properties
        public Customer Customer { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Order Order { get; set; }

        [ForeignKey("Order")]
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
