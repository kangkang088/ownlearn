#include <iostream>
using namespace std;

//引用作为函数参数
void func(int& a)
{
    cout << "func（int&）调用" << endl;
}
void func(const int& a)
{
    cout << "func（const int&）调用" << endl;
}
void func2(int a)
{
    cout << "func(int a)调用" << endl;
}
void func2(int a,int b = 10)
{
    cout << "func(int a,int b = 10)调用" << endl;
}
int main()
{
    int a = 10;
    func(a);
    func(10);//const int& a = 10  == int temp = 10;const int& a = temp
    func2(a,20);
}