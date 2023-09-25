using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _15石头剪刀布
{
    internal class Computer
    {
        public string Fist { get; set; }
        public int ShowFist() 
        {
            
            Random random = new Random();
            int number = random.Next(1,4);
            switch (number) 
            {
                case 1:this.Fist = "石头";break;
                case 2:this.Fist = "剪刀";break;
                case 3:this.Fist = "布";break;
            }
            return number;
        }
    }
}
