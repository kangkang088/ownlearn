#include <iostream>
using namespace std;
void* operator new (size_t size)
{
    cout << "调用了全局重载的new" << size << "字节" << endl;
    void* ptr = malloc(size);
    cout << "申请到内存的地址是：" << ptr << endl;
    return ptr;
}
void operator delete(void* ptr)
{
    cout << "调用了全局重载的delete\n";
    if (ptr == 0)
    {
        return;
    }
    free(ptr);
}
class CGirl
{
public:
    int m_bh;
    int m_age;
    CGirl(int bh, int age) { m_bh = bh; m_age = age; }
    ~CGirl() { cout << "调用了析构函数\n"; }
    void* operator new (size_t size)
    {
        cout << "调用了类中重载的new" << size << "字节" << endl;
        void* ptr = malloc(size);
        cout << "申请到内存的地址是：" << ptr << endl;
        return ptr;
    }
    void operator delete(void* ptr)
    {
        cout << "调用了类中重载的delete\n";
        if (ptr == 0)
        {
            return;
        }
        free(ptr);
    }
};
int main()
{
    int* p1 = new int(3);
    cout << "p1=" << (void*)p1 << ",*p1=" << *p1 << endl;
    delete p1;
    CGirl* p2 = new CGirl(3, 25);
    cout << "p2=" << p2 << endl;
    delete p2;
}
