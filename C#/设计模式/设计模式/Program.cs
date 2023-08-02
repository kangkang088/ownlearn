using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 设计模式;

namespace _简单工厂设计模式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入您想要的笔记本品牌");
            string brand = Console.ReadLine();
            NoteBook nb =  GetNoteBook(brand);
            nb.SayHello();
        }
        /// <summary>
        /// 简单工厂的核心。根据用户的输入，创建对象赋值给父类。工厂不知道你到底要哪种品牌，但是返回所有品牌的父类。父类包括你所要的品牌。
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        public static NoteBook GetNoteBook(string brand) 
        {
            NoteBook nb = null;
            switch (brand)
            {
                case "Lenovo":nb = new Lenovo();
                    break;
                case "IBM":nb = new IBM();
                    break;
                case "Dell":nb = new Dell();
                    break;
                case "Acer":nb = new Acer();
                    break;
            }







            return nb;
        }
    }
}
