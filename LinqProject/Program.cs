using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1 , CategoryName = "Computer" },
                new Category{CategoryId=2 , CategoryName= "Phone"}
            };

            List<Product> products = new List<Product>
            {
                //normalde db'den gelir.
                new Product{ProductId=1 ,CategoryId=1 , ProductName="Acer Computer" , UnitPrice= 10000 , QuantyPerUnit="32 GB Ram" , UnitInStock= 5},
                new Product{ProductId=2 ,CategoryId=1 , ProductName="Asus Computer" , UnitPrice= 8000 , QuantyPerUnit="16 GB Ram" , UnitInStock= 10},
                new Product{ProductId=3 ,CategoryId=1 , ProductName="Hp Computer" , UnitPrice= 6000 , QuantyPerUnit="8 GB Ram" , UnitInStock= 7},
                new Product{ProductId=4 ,CategoryId=2 , ProductName="Apple Phone" , UnitPrice= 8000 , QuantyPerUnit="4 GB Ram" , UnitInStock= 0},
                new Product{ProductId=5 ,CategoryId=2 , ProductName="Samsung Phone" , UnitPrice= 5000 , QuantyPerUnit="4 GB Ram" , UnitInStock= 15},
                new Product{ProductId=6 ,CategoryId=2 , ProductName="Xioami Phone" , UnitPrice= 4000 , QuantyPerUnit="2 GB Ram" , UnitInStock= 8}
            };

            Console.WriteLine("Algoritmik----------------");
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }
            }

            Console.WriteLine("Linq----------------");
            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3).ToList(); // p, product'ın ilk harfinden geliyor.

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

            GetProducts(products);

            Console.ReadLine();
        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInStock > 3)
                {
                    filteredProducts.Add(product);
                }

            }
            return filteredProducts;
        }

        static List<Product> GetProductLinq(List<Product> products)
        {
            //where komutu döngü oluşturarak içerisinde belirtilen şartlara uyanları ekler.
            return products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3).ToList();


        }
    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantyPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }


    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
