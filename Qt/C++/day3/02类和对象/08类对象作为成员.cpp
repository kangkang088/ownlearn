#include <iostream>
using namespace std;

class Phone
{
public:
    Phone(string pName) {
        this->m_pName = pName;
        cout << "Phone�Ĺ��캯������" << endl;
    }
    string m_pName;
};
class Person 
{
public:
    Person(string name,string pName):m_name(name),m_phone(pName)
    {
        cout << "Person�Ĺ��캯������" << endl;
    }
    string m_name;
    Phone m_phone;
};
void test1()
{
    Person p("����", "ƻ��");
}
int main()
{
    test1();
}