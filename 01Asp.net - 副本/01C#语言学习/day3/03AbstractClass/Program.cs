using System;

namespace _03AbstractClass {
    class Program {
        static void Main(string[] args){
        }
    }
    interface IVehicle {
        void Stop();
        void Fill();
        void Run();
    }
     abstract class Vehicle : IVehicle {
        public  void Stop(){
            Console.WriteLine("Car has stopped");
        }
        public  void Fill(){
            Console.WriteLine("I'm filled");
        }
        abstract public void Run();
     }
    class Car : Vehicle {
        public override void Run(){
            Console.WriteLine("Car is running!");
        }
    }
    class Truck : Vehicle {
        public override void Run(){
            Console.WriteLine("Truck is running!");
        }
    }
}