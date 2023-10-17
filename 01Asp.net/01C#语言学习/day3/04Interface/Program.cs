using System;

namespace _04Interface {
    class Program {
        static void Main(string[] args){
            UserPhone userPhone = new UserPhone(new Sumsams());
            userPhone.UsePhone();
        }
        class UserPhone {
            private IPhone _phone;
            public UserPhone(IPhone phone){
                this._phone = phone;
            }
            public void UsePhone(){
                this._phone.Call();
                this._phone.PickUp();
                this._phone.Get();
                this._phone.Send();
            }
        }
        }
    interface IPhone {
        void Call();
        void PickUp();
        void Send();
        void Get();
    }
    class NogiaPhone : IPhone {
        public void Call(){
            Console.WriteLine("NogiaPhone is calling");
        }
        public void PickUp(){
            Console.WriteLine("NogiaPhone has picked up");
        }
        public void Send(){
            Console.WriteLine("Message has sended");
        }
        public void Get(){
            Console.WriteLine("NogiaPhone has get the message");
        }
    }
    class Sumsams : IPhone{
        public void Call(){
            Console.WriteLine("Sumsams is calling");
        }
        public void PickUp(){
            Console.WriteLine("Sumsams has picked up");
        }
        public void Send(){
            Console.WriteLine("Message has sended");
        }
        public void Get(){
            Console.WriteLine("Sumsams has get the message");
        }
    }
}