//#include <iostream>
//#include <fstream>
//using namespace std;
//
//template <class T1=string,class T2 = int>
//class Person
//{
//public:
//    Person(T1 name, T2 age)
//    {
//        this->m_name = name;
//        this->m_age = age;
//    }
//    void showPerson()
//    {
//        cout << "name:" << this->m_name << "," << "age:" << this->m_age << endl;
//    }
//    T1 m_name;
//    T2 m_age;
//};
////1.类模板没有自动类型推导
//void test1()
//{
//    //Person p("孙悟空", 18);//错误，无法自动类型推导
//    Person<string, int> p("孙悟空", 18);//只能用具体化
//    p.showPerson();
//}
//
////2.类模板在模板参数列表中可以有默认参数
//void test2()
//{
//    Person<> p("猪八戒", 19);
//    p.showPerson();
//}
//int main()
//{
//    test1();
//    test2();
//}