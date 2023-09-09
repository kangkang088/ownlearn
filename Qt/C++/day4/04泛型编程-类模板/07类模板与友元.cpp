//#include <iostream>
//#include <fstream>
//using namespace std;
//
////1.提前让编译器知道类的存在，解决下面函数参数的问题
//template<class T1, class T2>
//class Person;
//
////2.提前让函数知道全局函数的存在 导致在类定义的上面，则需要1.来解决函数参数是类的问题
//template<class T1, class T2>
////因为是全局函数，所以函数名前面什么也不加
////又因为参数包含模板参数，需要上面的template声明
//void printPerson2(Person<T1, T2> p)
//{
//    cout << "类外姓名：" << p.m_name << endl;
//    cout << "类外年龄：" << p.m_age << endl;
//}
//
//template<class T1,class T2>
//class Person
//{
//    //全局函数 类内实现
//    friend void printPerson(Person<T1,T2> p)
//    {
//        cout << "姓名：" << p.m_name << endl;
//        cout << "年龄：" << p.m_age << endl;
//    }
//    //全局函数 类外实现
//    //加一个空模板参数列表，因为全局函数加了template，这里函数名后面要加一个<>
//    //3.全局函数是类外实现，需要让编译器提前知道函数存在 2.来解决
//    friend void printPerson2<>(Person<T1, T2> p);
//public:
//    Person(T1 name, T2 age)
//    {
//        this->m_name = name;
//        this->m_age = age;
//    }
//private:
//    T1 m_name;
//    T2 m_age;
//};
//void test1()
//{
//    Person<string, int> p("Tom", 20);
//    printPerson(p);
//}
//void test2()
//{
//    Person<string, int> p("Jerry", 18);
//    printPerson2(p);
//}
//int main()
//{
//    test1();
//    test2();
//}