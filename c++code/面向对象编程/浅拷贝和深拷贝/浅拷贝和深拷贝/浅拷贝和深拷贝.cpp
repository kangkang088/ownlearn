#include <iostream>
using namespace std;
//浅拷贝
//指针指向同一个对象，修改一个对象指针指向的内容时，另一个对象的值也会改变
//创建对象时，析构函数的调用会把指针指向的内存释放，第二个对象创建对象时，指针就变成了野指针
class CGirl
{
public:
    string m_name;
    int m_age;
    int* m_ptr;
    CGirl()
    { 
        m_name.clear(); m_age = 0; m_ptr = nullptr; cout << "调用了CGirl()\n";
    }
    ~CGirl()
    {
        if (m_ptr == nullptr)
        {
            delete m_ptr; 
            m_ptr = nullptr;//这一步是为了规避野指针，释放内存后指针不会置空，必须手动置空。
        }
        cout << "调用了~CGirl()\n";
    }
    CGirl(const CGirl& g)
    {
        m_name = g.m_name; m_age = g.m_age; m_ptr = g.m_ptr;
        cout << "调用了默认拷贝构造函数\n";
    }
    CGirl(const CGirl& g, int i)
    {
        m_name = g.m_name; m_age = g.m_age - i; m_ptr = g.m_ptr;
        cout << "调用了重载拷贝构造函数\n";
    }
    void show() { cout << "姓名：" << m_name << "，年龄：" << m_age << "m_ptr的地址是：" << m_ptr << "值是：" << *m_ptr << endl; }
};
int main()
{
    CGirl g1;
    g1.m_name = "西施"; g1.m_age = 23; g1.m_ptr = new int(3);
    g1.show();
    CGirl g2(g1);
    *(g2.m_ptr) = 8;
    g1.show();
    g2.show();
}
