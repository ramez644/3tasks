using System.Security.Cryptography.X509Certificates;

namespace demoday2.Models
{
    public class ProductmockData
    {
        List<Product> products;

        public ProductmockData() {
            products=new List<Product>();
            products.Add(new Product { Id = 1, Name = "iphonex", Description = "brand new", ImagePath = "download.jpg", Price = 13000 });
            products.Add(new Product { Id = 2, Name = "iphone11", Description = "brand new", ImagePath = "download.jpg", Price = 30000 });






        }


        public List<Product> GetProducts()
        {
            return products;
        }

        public Product getprod(int id)
        {

            return products.FirstOrDefault(x => x.Id == id);
        }





    }
}
