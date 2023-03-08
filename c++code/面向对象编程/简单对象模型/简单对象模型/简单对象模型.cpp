#include <iostream>
using namespace std;
class CGirl
{
public:
    int m_bh;
    char m_name[3];
    static int m_age;
    CGirl() { m_bh = 0; memset(m_name, 0, sizeof(m_name)); m_age = 0; }
    ~CGirl() {}
    void showname() { cout << "姓名:" << m_name << endl; }
     void showage() { cout << "年龄:" << m_age << endl; }
};
int CGirl::m_age;
int aaa;
void func() {}
int main()
{
    CGirl g;
    cout << sizeof(g) << endl;
    //成员函数是分开存储的，不论对象是否存在都占用存储空间，
    //在内存中只有一个副本，也不计算在对象大小之内。
   
    //非静态成员变量的地址和静态成员变量的地址不在一起
    cout << &g.m_bh << endl;
    cout << &g.m_name << endl;
    cout << &g.m_age << endl;//静态成员变量的地址和全局变量在一起
    cout << &aaa << endl;
    //成员函数的地址和普通函数的地址在一起
    printf("%p\n", &CGirl::showname);
    printf("%p\n", &CGirl::showage);
    printf("%p\n", &func);
}
