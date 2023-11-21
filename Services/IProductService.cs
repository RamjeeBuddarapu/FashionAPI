using FashionHexa.Entities;
namespace FashionHexa.Services
{
    public class IProductService
    {
        List<Product> GetProducts();
        List<Product> GetProductsByPrice(double price);
        Product GetProductById(int productId);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int productId);
    }
}
