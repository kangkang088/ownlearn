//#include <iostream>
//using namespace std;
//
//class Person
//{
//public:
//    int m_age;
//    Person()
//    {
//        cout << "person()构造函数的调用" << endl;
//    }
//    Person(int a)
//    {
//        this->m_age = a;
//        cout << "person(int)构造函数的调用" << endl;
//    }
//    //拷贝构造函数
//    Person(const Person &p)
//    {
//        this->m_age = p.m_age;
//        cout << "调用了拷贝构造函数" << endl;
//    }
//    ~Person()
//    {
//        cout << "person析构函数的调用" << endl;
//    }
//};
//int main()
//{
//    //括号法
//    Person p;//默认构造函数的调用，不要加（），不然成函数声明了，非要用，就Person p = Person().
//    Person p2(10);//括号法，有参的
//    Person p3(p2);
//    //显示法
//    Person p4 = Person();
//    Person p5 = Person(5);
//    //隐式转换法
//    Person p6 = 10;
//}