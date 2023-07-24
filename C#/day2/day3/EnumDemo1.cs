using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    public enum Gender
    {
        男,
        女
    }
    public enum Seasons
    {
        春,
        夏,
        秋,
        冬
    }
    public enum QQState
    { 
        OnLine=1,
        OffLine,
        Leave,
        Busy,
        QMe
    }
    internal class EnumDemo1
    {
        static void Main(string[] args)
        {
            Gender gender = Gender.男;
            Seasons seasons = Seasons.春;
            Seasons seasons1 = Seasons.夏;
            Console.WriteLine(seasons1);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            int n = (int)seasons1;
            Console.WriteLine(n);
            Console.WriteLine((int)Seasons.春);
            Console.WriteLine((int)Seasons.夏);
            Console.WriteLine((int)Seasons.秋);
            Console.WriteLine((int)Seasons.冬);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            int a = 3;
            Console.WriteLine((Seasons)a);


            string s = "0";
            Seasons seasons2 = (Seasons)Enum.Parse(typeof(Seasons),s);
            Console.WriteLine(seasons2);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            string s1 = "124sq5w";
            int i = 0;
            bool m = int.TryParse(s1,out i);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("请选择您的QQ状态，1-在线，2-离线，3-离开，4-忙碌，5-Q我。");
            string choice = Console.ReadLine();
            QQState qQState = (QQState)Enum.Parse(typeof (QQState),choice);
            Console.WriteLine(qQState);
            Console.ReadKey();
        }
    }
}
