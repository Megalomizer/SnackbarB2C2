namespace SnackbarB2C2.Models
{
    public class Owner
    {
        // Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        // Relational Properties
        public ICollection<Product> Products { get; set; } = new List<Product>();

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
