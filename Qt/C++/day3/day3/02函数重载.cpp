#include <iostream>
using namespace std;

//������Ϊ��������
void func(int& a)
{
    cout << "func��int&������" << endl;
}
void func(const int& a)
{
    cout << "func��const int&������" << endl;
}
void func2(int a)
{
    cout << "func(int a)����" << endl;
}
void func2(int a,int b = 10)
{
    cout << "func(int a,int b = 10)����" << endl;
}
int main()
{
    int a = 10;
    func(a);
    func(10);//const int& a = 10  == int temp = 10;const int& a = temp
    func2(a,20);
}