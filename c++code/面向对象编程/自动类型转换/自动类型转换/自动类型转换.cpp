#include <iostream>
using namespace std;
class mystring
{
public:
    char* ptr;
    mystring(string p)
    {
        ptr = (char*) & p;
    }
};
int main()
{
    string s1 = "我是一只傻傻鸟。";

    mystring s2 = mystring("我是一只傻傻鸟。");
}

