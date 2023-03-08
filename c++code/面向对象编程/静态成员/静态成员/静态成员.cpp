// 静态成员.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
//

#include <iostream>
using namespace std;
class CGirl
{
public:
    string m_name;
    static int m_age;
    CGirl(const string& name, int age)
    {
        m_name = name; m_age = age;
    }
    void showname() { cout << "姓名：" << m_name << endl; }
    static void showage() { cout << "年龄：" << m_age << endl; }
};
//static修饰的静态变量必须有这个在程序全局区的初始化
int CGirl::m_age = 28;//默认为0，可以赋值
int main()
{
    CGirl::showage();//不创建对象也可以访问静态成员函数
    cout << CGirl::m_age << endl;//静态成员变量不需要创建对象也可以访问。
    CGirl g1("西施", 23);
    g1.showname();
    g1.showage();
}
