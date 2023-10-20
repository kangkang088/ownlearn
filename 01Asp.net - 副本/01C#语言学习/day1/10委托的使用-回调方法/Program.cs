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
            Func<Product> func2 = new Func<Product>(product.MakeCar);

            Logger logger = new Logger();
            Action<Product> log = new Action<Product>(logger.Log);

            Box box1 = wrap.WrapProduct(func1, log);
            Box box2 = wrap.WrapProduct(func2, log);

            Console.WriteLine(box1.Product.Name);
            Console.WriteLine(box2.Product.Name);
        }
    }
    class Logger
    {
        public void Log(Product product)
        {
            Console.WriteLine("Product '{0}' created at {1}.Price is {2}.",product.Name,DateTime.UtcNow,product.Price);
        }
    }
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    class Box
    {
        public Product Product { get; set; }
    }
    class WrapFactory
    {
        public Box WrapProduct(Func<Product> getProduct,Action<Product> logCallBack)//模板方法 + 回调方法
        {
            Box box = new Box();
            Product product = getProduct.Invoke();
            if (product.Price >= 50)
            { 
                logCallBack(product);
            }
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
            product.Price = 12;
            return product;
        }
        public Product MakeCar()
        {
            Product product = new Product();
            product.Name = "Car";
            product.Price = 100;
            return product;
        }
    }
}
