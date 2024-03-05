
namespace EShop.Modelsnamespace 
{
        public class Cart
{
    public int CartId { get; set; }
    public int ProductId { get; set; }
    public int CustomerId { get; set; }
    public int Quantity { get; set; }
}
}

namespace EShop.Models
{
    public class OrderModel
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
    }
}

namespace EShop.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
    }
}

namespace EShop.Models
{
    public class CustomerModel
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}


