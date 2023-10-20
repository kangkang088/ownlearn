using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13使用接口取代委托
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WrapFactory wrap = new WrapFactory();
            IProductFactory pizzaFactoty = new PizzaFactoty();
            IProductFactory carFactory = new CarFactory();

            Box box1 = wrap.WrapProduct(pizzaFactoty);
            Box box2 = wrap.WrapProduct(carFactory);

            Console.WriteLine(box1.Product.Name);
            Console.WriteLine(box2.Product.Name);
        }
    }
    interface IProductFactory
    { 
        Product Make();
    }
    class PizzaFactoty : IProductFactory
    {
        public Product Make()
        {
            Product product = new Product();
            product.Name = "Pizza";
            return product;
        }
    }
    class CarFactory : IProductFactory
    {
        public Product Make()
        {
            Product product = new Product();
            product.Name = "Car";
            return product;
        }
    }
    class Product
    { 
        public string Name { get; set; }    
    }
    class Box
    { 
        public Product Product { get; set; }
    }
    class WrapFactory
    {
        public Box WrapProduct(IProductFactory productFactory)
        {
            Box box = new Box();
            Product product = productFactory.Make();
            box.Product = product;
            return box;
        }
    }
}
