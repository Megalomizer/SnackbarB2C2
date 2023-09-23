using System.ComponentModel.DataAnnotations;
namespace SnackbarB2C2.Models
{
    public class Product
    {
        // Properties
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public float Price { get; set; }
        public int? Discount { get; set; }

        [Required]
        public int Stock { get; set; }

        public string? ImgPath { get; set; }

        public string? Description { get; set; }

        // Constructor
        public Product() { }
        public Product(int id, string name, float price, int discount, int stock, string imgPath, string description)
        {
            Id = id;
            Name = name;
            Price = price;
            Discount = discount;
            Stock = stock;
            ImgPath = imgPath;
            Description = description;
        }
    }
}
