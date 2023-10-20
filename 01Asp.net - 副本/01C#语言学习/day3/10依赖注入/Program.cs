using System;
using Microsoft.Extensions.DependencyInjection;

namespace _10依赖注入 {
    internal class Program {
        static void Main(string[] args) {
            //1.引用名称空间
            //2.依赖注入有一种最重要的东西，容器(ServiceCollection)（把各种类型和对应的接口放进容器），后面要实例的时候，向容器索要。在注册类型的时候，还可以告诉容器我们创建对象时候是每次都是一个新对象，还是以单例模式创建对象。
            //DependencyInjection的使用
            //1.创建接口的实现者（服务的提供者）变量ServiceCollection，ServiceCollection其实就是我们所说的容器
            var sc = new ServiceCollection();
            //2.往容器中装东西
            //用AddScoped方法添加 接口的类型 以及 哪个实现的这个接口的类的类型。要用Typeof,因为需要的是动态的类型描述，而不是静态的类型。放入完成。
            sc.AddScoped(typeof(ITank),typeof(MediumTank));

            sc.AddScoped(typeof(IVehicle), typeof(MediumTank));
            sc.AddScoped<Driver>();
            var sp = sc.BuildServiceProvider();
            //---------------------------------分割线-----------------
            ITank tank = sp.GetService<ITank>();
            tank.Fire();
            tank.Run(); 

            var driver = sp.GetService<Driver>();
            driver.Drive();
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
