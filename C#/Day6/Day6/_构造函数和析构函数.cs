using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class _构造函数和析构函数
    {
        static void Main(string[] args)
        {
            //构造函数可以避免这种依次初始化成员的代码冗余
            //帮助我们初始化对象
            //1.构造函数是一个特殊的方法，没有返回值，没有void
            //2.名称必须和类名一样，必须是public
            //3.创建对象的时候执行构造函数
            //4.可以重载
            //5.默认构造函数由程序自动提供
            //6.重载时，系统不自动提供默认构造函数，需要无参时，必须手动写

            //前面的Student=class Day6.Student，new后面的是Student.Student()。
            //new 在内存中开辟一块空间
            //空间中创建对象
            //调用构造函数为对象初始化，创建对象完成
            //如果构造函数不是public，这里无法调用，无法创建对象。调用完了，对象才会创建
            Student student = new Student("张三",15,'男',15,25,35);                       
            student.SayHello();
            student.ShowScores();

            //Student student2 = new Student();有构造函数时，默认空参数的构造函数系统不自动提供，需要时必须手动写，否则这行代码会报错                      
            //student.Name = "小兰";
            //student2.Age = 15;
            //student2.Gender = '女';
            //student2.English = 15;
            //student2.Chinese = 20;
            //student2.Math = 100;
            //student2.SayHello(); student2.ShowScores();
        }
    }
}
