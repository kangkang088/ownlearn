using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    //方法自己调用自己
    //例如找一个文件夹中的所以文件
    internal class _方法的递归
    {   
        static void Main(string[] args)
        {
            int i = 1;
            Story(i);
        }
        public static void Story(int i) 
        {
            
            Console.WriteLine("从前有座山");
            Console.WriteLine("山里有座庙");
           
            i++;
            if (i <= 10)
            {
                
                Story(i);
                
            }
            return;
        }
    }
}
