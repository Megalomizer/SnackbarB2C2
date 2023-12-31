﻿using System.ComponentModel.DataAnnotations;

namespace SnackbarB2C2Library
{
    public class Customer
    {
        // Properties
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string? LastName { get; set; }

        [Required]
        public string Email { get; set; }
        public string? Phone {  get; set; }

        // Relational Properties
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
        public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();

        // Constructor
        public Customer() { }
        public Customer(int id, string firstname, string lastname, string email, string phone)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Phone = phone;
        }
    }
}
