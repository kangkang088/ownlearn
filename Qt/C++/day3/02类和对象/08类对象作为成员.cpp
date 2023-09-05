#include <iostream>
using namespace std;

class Phone
{
public:
    Phone(string pName) {
        this->m_pName = pName;
        cout << "Phone的构造函数调用" << endl;
    }
    string m_pName;
};
class Person 
{
public:
    Person(string name,string pName):m_name(name),m_phone(pName)
    {
        cout << "Person的构造函数调用" << endl;
    }
    string m_name;
    Phone m_phone;
};
void test1()
{
    Person p("张三", "苹果");
}
int main()
{
    test1();
}