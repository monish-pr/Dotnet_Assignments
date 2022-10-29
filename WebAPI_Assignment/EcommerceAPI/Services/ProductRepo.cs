using EcommerceAPI.Database;
using EcommerceAPI.Entities;
using EcommerceAPI.Interfaces;

namespace EcommerceAPI.Services
{
    public class ProductRepo : IProductRepo
    {
        private EcommerceDbContext Context { get; set; }

        public ProductRepo() {
            Context = new EcommerceDbContext();
        }

        public void AddProduct(Product product)
        {
            Context.ProductList.Add(product);
            Context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            Context.ProductList.Remove(GetProductById(id));
            Context.SaveChanges();
        }

        public List<Product> GetAllProducts()
        {
            return Context.ProductList.ToList();
        }

        public Product GetProductById(int id)
        {
            return Context.ProductList.SingleOrDefault(product => product.ProductId == id);
        }

        public void UpdateProduct(int id, double NewPrice)
        {
            Product product = GetProductById(id);
            product.Price = NewPrice;
            Context.SaveChanges();
        }
    }
}
