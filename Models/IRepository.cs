using System.Collections.Generic;

namespace DependencyInjection.Models 
{
    public interface IRepository
    {
        public IEnumerable<Product> Products { get; }
        Product this[string name] { get; }
        void addProduct (Product product);
        void deleteProduct(Product product);
    }
}