using System.Collections.Generic;
using WebApplicationLesson1.Models;

namespace WebApplicationLesson1
{
    public class ProductRepository
    {
        private List<Product> products = new List<Product>()
        {
            new Product("Name1", 10, "Desc1"),
            new Product("Name2", 20, "Desc2"),
            new Product("Name3", 30, "Desc3"),
            new Product("Name4", 40, "Desc4"),
        };

        public List<Product> GetAll()
        {
            return products;
        }
    }
}
