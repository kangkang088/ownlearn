using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10test1 {
    internal class Program {
        static void Main(string[] args) {
            Customer customer = new Customer();
            Waiter waiter = new Waiter();
            customer.Order += waiter.Action;
            customer.Action();
            
        }
    }
    public class OrderEventArgs : EventArgs {
        public string Name { get; set; }
        public string Size { get; set; }
    }
    public delegate void OrderHandlerEvent(Customer customer, OrderEventArgs e);
    public class Customer {
        private OrderHandlerEvent OrderHandlerEvent;
        public event OrderHandlerEvent Order {
            add {
                this.OrderHandlerEvent += value;
            }
            remove {
                this.OrderHandlerEvent -= value;
            }
        }
        public double Bill { get; set; }
        public void PayBill() {
            Console.WriteLine($"I will pay {Bill}$");
        }
        public void think() {
            for (int i = 0; i < 5; i++) {
                Console.WriteLine("I need to think...");
                Thread.Sleep(1000);
            }
            OnOrder();
        }
        public void OnOrder() {
            if (this.OrderHandlerEvent != null) {
                OrderEventArgs orderEventArgs = new OrderEventArgs();
                orderEventArgs.Name = "manhanquanxi";
                orderEventArgs.Size = "large";
                this.OrderHandlerEvent.Invoke(this, orderEventArgs);
            }
        }
        public void Action() {
            think();
            PayBill();
        }
    }
    public class Waiter {
        internal void Action(Customer customer, OrderEventArgs e) {
            Console.WriteLine("I will serve you the {0}",e.Name);
            double price = 10;
            switch (e.Size) {
                case "small":
                    price = price * 0.5; break;
                case "large":
                    price = price * 1.5; break;
                default:
                    break;
            }
            customer.Bill = price;
        }
    }
}
