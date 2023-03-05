#include <iostream>
using namespace std;
inline void show(int bh, string message)
{
    cout << "亲爱的" << bh << "号：" << message << endl;
}
int main()
{
    //多次调用，1.要保存每次调用函数的地址 2.实参拷贝到堆栈 3.返回值需要保存到寄存器
    /*show(3,"我是一只小小鸟");
    show(5,"我是一只傻傻鸟");
    show(8,"我是一只傻傻鸟");*/


    //占用更多内存，但不需要去其他地方调用
    // 通常将函数的声明和定义写在一起
    show(3, "我是一只小小鸟");
    //相当于
    {
        int bh = 3;
        string message = "我是一只小小鸟";
        cout << "亲爱的" << bh << "号：" << message << endl;
    }
    show(5, "我是一只傻傻鸟");
     //相当于
    {
        int bh = 5;
        string message = "我是一只傻傻鸟";
        cout << "亲爱的" << bh << "号：" << message << endl;
    }
    show(8, "我是一只傻傻鸟");
     //相当于
    {
        int bh = 8;
        string message = "我是一只傻傻鸟";
        cout << "亲爱的" << bh << "号：" << message << endl;
    }
}

