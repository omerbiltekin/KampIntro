using System;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "İphone 12";
            product1.Customer = "Apple";
            product1.Price = 1000;

            Product product2 = new Product();
            product2.Name = "Samsung 21 Ultra";
            product2.Customer = "Samsung";
            product2.Price = 1200;

            Product product3 = new Product();
            product3.Name = "Huawei Mate 20";
            product3.Customer = "Huawei";
            product3.Price = 950;

            Product[] products = new Product[] { product1, product2, product3 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Name + " | " + product.Customer + " " + product.Price + "$");
                
            }
                Console.WriteLine("End of the foreach");
            for (int i = 0; i <products.Length; i++)
            {
                Console.WriteLine(products[i].Name +" " + products[i].Customer +" " + products[i].Price);
                
            }
                Console.WriteLine("End of the for");
            int p = 0;
            while (p <products.Length)
            {
                Console.WriteLine(products[p].Name + " " + products[p].Customer + " " + products[p].Price); p++;
              
            }
                Console.WriteLine("End of the while");


        }
    }

    class Product
    {
       
       public string Name { get; set; }

       public string Customer { get; set; }

       public int Price { get; set; }
        

        

          

    } 


}
