#include <iostream>
using namespace std;
void func1(int** p)
{
    *p =new int(3);
    cout << "内存中的值**p=" << **p << "func1的地址是：" << *p << endl;
}
void func2(int*& p)
{
    p = new int(3);
    cout << "内存中的值*p=" << *p << "func1的地址是：" << p << endl;
}
int main()
{
    int* p = nullptr;
    //func1(&p);
    func2(p);
}

