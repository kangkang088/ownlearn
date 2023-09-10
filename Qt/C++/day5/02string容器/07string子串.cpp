#include <iostream>
#include <fstream>
using namespace std;

//stringÇó×Ó´®
void test1()
{
    string str = "abcdef";
    string subStr = str.substr(1, 3);
    cout << "sunStr = " << subStr << endl;
}

void test2()
{
    string email = "zhangsan@sina.com";

    int pos = email.find("@");
    string userName = email.substr(0, pos);
    cout << pos << endl;
    cout << userName << endl;
}
int main()
{
    test1();
    test2();
}