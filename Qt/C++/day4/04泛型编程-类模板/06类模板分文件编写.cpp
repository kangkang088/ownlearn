//#include <iostream>
//#include <fstream>
////会出错
////#include "06Person.h"
////第一种解决方法
////#include "06Person.cpp"//不常用
//
////第二种 将.cpp和.h中的代码写在一起，后缀名改为.hpp文件（类模板）
////不强制改为.hpp
////#include "06Person.h"//也可以
//#include "06Person.hpp"
//using namespace std;
//
////类模板分文件编写问题
//
////template<class T1,class T2>
////class Person
////{
////public:
////    Person(T1 name, T2 age);
////    void showPerson();
////    T1 m_name;
////    T2 m_age;
////
////};
////template<class T1,class T2>
////Person<T1, T2>::Person(T1 name, T2 age)
////{
////    this->m_name = name;
////    this->m_age = age;
////}
////template<class T1, class T2>
////void Person<T1,T2>::showPerson()
////{
////    cout << "姓名：" << this->m_name << endl;
////    cout << "年龄：" << this->m_age << endl;
////}
//void test1()
//{
//    Person<string, int> p("Jerry", 18);
//    p.showPerson();
//}
//int main()
//{
//    test1();
//}