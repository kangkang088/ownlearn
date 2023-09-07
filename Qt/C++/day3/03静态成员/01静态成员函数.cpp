//#include <iostream>
//using namespace std;
//
////静态成员函数
////所有对象共享同一个函数
////静态成员函数只能访问静态成员变量
////非静态成员函数可以访问静态和非静态成员变量
//class Person
//{
//public:
//    int m_a;
//    static int m_b;
//    static void func()
//    {
//        m_b = 100;
//        cout << "static void func()被调用" << endl;
//    }
//};
//int Person::m_b = 20;
//int main()
//{
//    Person p;
//    p.func();
//    Person::func();
//}