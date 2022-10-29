using EcommerceAPI.Entities;

namespace EcommerceAPI.Interfaces
{
    public interface IProductRepo
    {
        Product GetProductById(int id);
        List<Product> GetAllProducts();
        void AddProduct(Product product);
        void UpdateProduct(int id, double NewPrice);
        void DeleteProduct(int id);
    }
}
