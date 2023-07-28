using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice里氏转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] p = new Person[10];
            Random r = new Random();

            for (int i = 0; i < p.Length; i++)
            {
                int rnumber = r.Next(0, 6);
                switch (rnumber)
                {
                    case 0:
                        p[i] = new Student();
                        break;
                    case 1:
                        p[i] = new Teacher();
                        break;
                    case 2:
                        p[i] = new Boy();
                        break;
                    case 3:
                        p[i] = new Girl();
                        break;
                    case 4:
                        p[i] = new Person();
                        break;
                    case 5:
                        p[i] = new YeShou();
                        break;
                }
            }
            Stopwatch st = new Stopwatch();
            st.Start();
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] is Student)
                {
                    ((Student)p[i]).ShowStudent();
                }
                else if (p[i] is Teacher)
                {
                    ((Teacher)p[i]).ShowTeacher();
                }
                else if (p[i] is Boy)
                {
                    ((Boy)p[i]).ShowBoy();
                }
                else if (p[i] is Girl)
                {
                    ((Girl)p[i]).ShowGirl();
                }
                else if (p[i] is Person)
                {
                    ((Person)p[i]).ShowPerson();
                }
                else if (p[i] is YeShou)
                {
                    ((YeShou)p[i]).ShowYeShou();
                }
            }
            st.Stop();
            Console.WriteLine(st.Elapsed);
        }
    }
}
