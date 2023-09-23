using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Split分割字符串
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            string str = "a b    cdf + = _ ,,, fgew";

            char[] chars = { ' ', '+', '=', ',', '_' };
            string[] strings = str.Split(chars,StringSplitOptions.RemoveEmptyEntries);
            Show();
        }
        public static void Show()
        { 
            
        }
    }
}
