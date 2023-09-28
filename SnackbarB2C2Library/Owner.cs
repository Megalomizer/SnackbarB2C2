using System.ComponentModel.DataAnnotations;

namespace SnackbarB2C2Library
{
    public class Owner
    {
        // Properties
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        public string? Phone { get; set; }

        // Relational Properties
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();

        // Constructors
        public Owner() { }
        public Owner(int id, string firstname, string lastname, string email, string phone)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Phone = phone;
        }
    }
}
