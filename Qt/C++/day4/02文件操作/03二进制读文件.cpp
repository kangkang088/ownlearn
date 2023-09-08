#include <iostream>
#include <fstream>
using namespace std;

//二进制读文件
class Person
{
public:
    char m_name[64];
    int m_age;
};
void test1()
{
    ifstream is;
    is.open("binary.txt", ios::in | ios::binary);
    if (!is.is_open())
    {
        cout << "打开文件失败" << endl;
        return;
    }
    Person p;
    is.read((char*)&p, sizeof(p));
    cout << p.m_name << endl;
    cout << p.m_age << endl;
    is.close();

}
int main()
{
    test1();
}