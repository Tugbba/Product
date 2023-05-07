using System;
using System.Collections.Generic;
using System.Text;


namespace Product
{
    class ProductManager
    {
        public void Add( Product product) 
        {
            Console.WriteLine(  product.ProductName + " eklendi." );
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");

        }
    }
}
