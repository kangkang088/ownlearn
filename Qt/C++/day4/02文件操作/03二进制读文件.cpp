#include <iostream>
#include <fstream>
using namespace std;

//�����ƶ��ļ�
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
        cout << "���ļ�ʧ��" << endl;
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