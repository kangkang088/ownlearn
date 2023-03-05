#include <iostream>
using namespace std;
int func1()
{
    int i = 3;
    return i;
}
//int i = 3;//全局变量
int &func2()
{
    static int i = 3;//静态变量
    return i;
}
int& func3(int & ra)
{
    ra++;
    cout << &ra << " " << ra << endl;
    return ra;
}
int main()
{
    int a = func1(); cout << a << endl;
    
    int& b = func2();  cout << b << endl;//如果函数中为int i =3；在函数被调用完之后，i就会被释放掉，返回局部变量的引用，本质是野指针
   
    int c = 3;
    int& d = func3(c);
    cout << &c << " " << c << endl;
    cout << &d << " " << d << endl;

    func3(c) = 10;//返回引用的函数是被引用的变量的别名,不想通过这个修改，可以加const用于被返回的引用
    //相当于调用func3函数，再把10赋值给c
    cout << c << endl;
    cout << d << endl;
}
