using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07事件的完整声明
{

    class Program
    {

        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Waiter waiter = new Waiter();
            customer.Order += waiter.Action;
            customer.Action();
            customer.PaidTheBidd();
        }
    }
    public class OrderEventArgs : EventArgs
    {
        public string DishName { get; set; }
        public string Size { get; set; }
    }

    //1.实例用来存储事件处理器
    //2.约束事件处理器
    //3.专门为特定事件准备（用于声明事件），不要用做其他用途
    public delegate void OrderEventHandler(Customer customer, OrderEventArgs e);

    public class Customer
    {
        private OrderEventHandler orderEventHandler;//用来存储事件处理器
        public event OrderEventHandler Order//事件名为Order，用OrderEventHandler这个委托类型来约束事件
        {
            //事件处理器的添加器
            add
            {
                this.orderEventHandler += value;
            }
            //事件处理器的移除器
            remove
            { 
                this.orderEventHandler -= value;
            }
        }
        public double Bill { get; set; }
        public void PaidTheBidd()
        {
            Console.WriteLine("I will pay ${0}", this.Bill);
        }
        public void WalkIn()
        {
            Console.WriteLine("Walk into the restaurant");
        }
        public void SitDown()
        {
            Console.WriteLine("Sit down!");
        }
        //触发事件
        public void Think()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Let me think...");
                Thread.Sleep(1000);
            }
            if (this.orderEventHandler != null)
            { 
                OrderEventArgs e = new OrderEventArgs();
                e.DishName = "Kongpao Chicken";
                e.Size = "large";
                this.orderEventHandler.Invoke(this,e);
            }
        }
        public void Action()
        {
            Console.ReadLine();
            this.WalkIn();
            this.SitDown();
            this.Think();
        }
    }
    public class Waiter
    {
        public void Action(Customer customer, OrderEventArgs e)
        {
            Console.WriteLine("I will serve you the dish - {0}",e.DishName);
            double price = 10;
            switch (e.Size) 
            {
                case "small":
                    price = price * 0.5;
                    break;
                case "large":
                    price = price * 1.5;
                    break;
                default:
                    break;
            }
            customer.Bill += price;
        }
    }
}
