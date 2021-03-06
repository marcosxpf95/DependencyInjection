using System.Collections.Generic;

namespace DependencyInjection.Models
{
    public class MemoryRepository : IRepository
    {
        private Dictionary<string, Product> products;
        public MemoryRepository()
        {
            products = new Dictionary<string, Product>();

            new List<Product> 
            {
                new Product { Name = "Kayak", Price = 275M},
                new Product { Name = "Lifejacket", Price = 48.95M},
                new Product { Name = "Soccer Ball", Price = 19.50M}
            }.ForEach(p => addProduct(p));
        }  
        public IEnumerable<Product> Products => products.Values;
        public Product this[string name] => products[name];
        public void addProduct(Product product) =>
            products[product.Name] = product;
        
        public void deleteProduct(Product product) =>
            products.Remove(product.Name);
        
    }
}