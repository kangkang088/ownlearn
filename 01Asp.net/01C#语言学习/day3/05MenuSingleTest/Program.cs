using System;
using System.Collections;

namespace _05MenuSingleTest {
    class Program {
        static void Main(string[] args) {
            DeskFan deskFan = new DeskFan(new PowerSupply());
            Console.WriteLine(deskFan.Work());
            
        }
    }
    public interface IPowerSupply {
        int GetPower();
    }
    public class PowerSupply : IPowerSupply {
        public int GetPower() {
            return 110;
        }
    }
    public class DeskFan {
        private IPowerSupply _powerSupply;
        public DeskFan(IPowerSupply powerSupply) {
            this._powerSupply = powerSupply;
        }
        public string Work() {
            int power = _powerSupply.GetPower();
            if (power <= 0) {
                return "Won't work!";
            }
            else if (power < 100) {
                return "slow!";
            }
            else if (power < 200) {
                return "Work fine!";
            }
            else return "Warning";
        }
    }
}