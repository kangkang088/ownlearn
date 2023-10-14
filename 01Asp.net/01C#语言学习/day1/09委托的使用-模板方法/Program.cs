using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09委托的使用_模板方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductFactory product = new ProductFactory(); 
            WrapFactory wrap = new WrapFactory();

            Func<Product> func1 = new Func<Product>(product.MakerPizza);
            Func<Product> func2 = new Func<Product> (product.MakeCar);

            Box box1 = wrap.WrapProduct(func1);
            Box box2 = wrap.WrapProduct(func2);

            Console.WriteLine(box1.Product.Name);
            Console.WriteLine(box2.Product.Name);
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
        public Box WrapProduct(Func<Product> getProduct)//模板方法
        { 
            Box box = new Box();
            Product product = getProduct.Invoke();
            box.Product = product;
            return box;
        }
    }
    class ProductFactory
    {
        public Product MakerPizza()
        { 
            Product product = new Product();
            product.Name = "Pizza";
            return product;
        }
        public Product MakeCar()
        {
            Product product = new Product();
            product.Name = "Car";
            return product;
        }
    }
}
