#include <iostream>
using namespace std;

//�����º���
class MyPrint
{
public:
    //���غ������������
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