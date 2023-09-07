#include <iostream>
using namespace std;

//又名仿函数
class MyPrint
{
public:
    //重载函数调用运算符
    void operator() (string test)
    {
        cout << test << endl;
    }
};
void print(string test)
{
    cout << test << endl;
}
void test1()
{
    MyPrint myPrint;
    myPrint("hello world!");
    print("hello world!");
}
int main()
{
    test1();
}