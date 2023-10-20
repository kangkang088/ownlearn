using System;

namespace _06接口隔离原则 {
    internal class Program {
        static void Main(string[] args) {
            var driver = new Driver(new LightTank());
            driver.Drive();
        }
    }
    class Driver {
        private IVehicle _vehicle;
        public Driver(IVehicle vehicle)
        {
            this._vehicle = vehicle;
        }
        public void Drive() {
            this._vehicle.Run();
        }
    }
    interface IVehicle {
        void Run();
    }
    class Car : IVehicle { 
        public void Run() {
            Console.WriteLine("Car is running...");
        }
    }
    class Truck : IVehicle {
        public void Run() {
            Console.WriteLine("Truck is running...");
        }
    }
    interface IWeapon {
        void Fire();
    }
    interface ITank:IWeapon,IVehicle {
        void Fire();
        void Run();
    }
    class LightTank : ITank {
        public void Fire() {
            Console.WriteLine("Boom!");
        }
        public void Run() {
            Console.WriteLine("Ka! ka! ka...");
        }
    }
    class MediumTank : ITank {
        public void Fire() {
            Console.WriteLine("Boom!!");
        }
        public void Run() {
            Console.WriteLine("Ka!! ka!! ka...");
        }
    }
    class HeavyTank : ITank {
        public void Fire() {
            Console.WriteLine("Boom!!!");
        }
        public void Run() {
            Console.WriteLine("Ka!!! ka!!! ka...");
        }
    }
}
