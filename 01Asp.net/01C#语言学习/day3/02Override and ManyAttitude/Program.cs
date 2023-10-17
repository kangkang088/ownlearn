using System;

namespace _02Override_and_ManyAttitude {
    class Program {
        static void Main(string[] args){
            Vehicle v = new Car();
            v.Run();
            Console.WriteLine(v.Speed);
        }
    }
    internal class Vehicle {
        private int speed;
        public virtual int Speed {
            get { return this.speed;}
            set { this.speed = value; }
        }
        public virtual void Run(){
            Console.WriteLine("I'm running!");
            speed = 100;
        }
    }
    internal class Car : Vehicle {
        private int rpm;
        public override int Speed {
            get { return rpm / 100; }
            set { this.rpm = value * 100; }
        }
        public override void Run(){
            Console.WriteLine("Car is running!");
            rpm = 5000;
        }
    }
    internal class RaseCar : Car {
        public override void Run(){
            Console.WriteLine("Rasecar is running!");
        }
    }
}