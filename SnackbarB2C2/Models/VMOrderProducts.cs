using SnackbarB2C2Library;
namespace SnackbarB2C2.Models
{
    public class VMOrderProducts
    {
        public ICollection<Product> Products { get; set; }
        public Order Orders { get; set; }
    }
}
