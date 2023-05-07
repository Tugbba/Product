using System;

namespace Product
{

    class Program
    {

        static void Main(string[] args)
        {
          Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 3020;
            product1.ProductName = "Lila Cicekli Drapeli Sifon Elbise";
            product1.UnitPrice = 540;
            product1.UnitsInStock = 10;

            // Bir diğer ürün bilgisi girme yolu da aşağıdaki gibidir ve bu ikinci yol daha pratiktir.

            Product product2 = new Product 
            {   Id = 2, 
                CategoryId = 3115 , 
                ProductName = "Kırmızı Yaka Fırfır Detay Elbise", 
                UnitPrice = 370 ,
                UnitsInStock = 12 
            };
           
           ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            //Birkaç ürünü diziye ekleyelim sonra ürünlerimizi foreach döngüsü ile listeyelim.

            Product[] products = new Product[] { product1, product2 };
            foreach (Product product in products)
            {
                Console.WriteLine(product.Id);
                Console.WriteLine(product.CategoryId);
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.UnitPrice);
                Console.WriteLine(product.UnitsInStock);
            }


        }
    }
}



