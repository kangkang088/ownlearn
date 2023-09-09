//#include <iostream>
//#include <fstream>
//using namespace std;
//
//template <class T1,class T2>
//class Person
//{
//public:
//    //构造函数类内shixian
//    Person(T1 name, T2 age);
//  /*  {
//        this->m_name = name;
//        this->m_age = age;
//    }*/
//    void showPerson();
//   /* {
//        cout << "姓名：" << this->m_name << "," << "年龄：" << this->m_age << endl;
//    }*/
//    T1 m_name;
//    T2 m_age;
//};
////类模板成员函数类外实现
//template<class T1,class T2>
//Person<T1, T2>::Person(T1 name, T2 age)
//{
//    this->m_name = name;
//    this->m_age = age;
//}
//
////就算成员函数没有用到参数，也要这样定义,指明这是类模板的成员函数
//template <class T1,class T2>
//void Person<T1, T2>::showPerson()
//{
//    cout << "姓名：" << this->m_name << "," << "年龄：" << this->m_age << endl;
//}
//void test1()
//{
//    Person<string, int> p("Tom", 18);
//    p.showPerson();
//}
//int main()
//{
//    test1();
//}