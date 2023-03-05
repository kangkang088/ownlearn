#include <iostream>
using namespace std;
void show(short bh, string message)
{
    cout << "short亲爱的" << bh << "号：" << message << endl;
}
void show(long bh, string message)
{
    cout << "long亲爱的" << bh << "号：" << message << endl;
}
void show(double bh, string message)
{
    cout << "double亲爱的" << bh << "号：" << message << endl;
}
int main()
{
    short bh = 10;
    show(bh, "我是一直傻傻鸟");
}

