using System;
using System.Reflection;

namespace _09反射 {
    internal class Program {
        static void Main(string[] args) {
            ITank tank = new HeavyTank();
            //---------------------------
            //反射原理（一般不这样用）
            var t = tank.GetType();
            object o = Activator.CreateInstance(t);
            MethodInfo fireMi = t.GetMethod("Fire");
            MethodInfo runMi = t.GetMethod("Run");
            fireMi.Invoke(o, null);
            runMi.Invoke(o, null);
        }
    }
    class Driver {
        private IVehicle _vehicle;
        public Driver(IVehicle vehicle) {
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
    interface ITank : IWeapon, IVehicle {
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
