#include <iostream>
using namespace std;
void show(string str)
{
    cout << "普通函数：" << str << endl;
}
class CGirl
{
public:
    void operator ()(string str)
    {
        cout << "重载函数：" << str << endl;
    }
};
int main()
{
    
    CGirl show;
    show("我是一只傻傻鸟。");
    
    show("我是一只傻傻鸟。");
}
