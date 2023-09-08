//#include <iostream>
//#include <fstream>
//using namespace std;
//
////类模板中成员函数在调用时才会创建
//template<class  T>
//class MyClass
//{
//public:
//    T obj;
//    //类模板中的成员函数
//    // 下面两个会有一个出错（根据T的具体类型）
//    //没有调用时，函数模板成员函数不会创建，没错
//    void func1()
//    {
//        obj.showPerson1();
//    }
//    void func2()
//    {
//        obj.showPerson2();
//    }
//};
//class Person1
//{
//public:
//    void showPerson1(){
//        cout << "Peeson1 show" << endl;
//    }
//};
//class Person2
//{
//public:
//    void showPerson2() {
//        cout << "Peeson2 show" << endl;
//    }
//};
//void test1()
//{
//    MyClass<Person1> mc;
//    //调用了成员函数，此时会创建函数模板的成员函数，发现错误
//    mc.func1();
//    //mc.func2();//出错，因为它是Person2的showPerson2()；
//}
//int main()
//{
//    test1();
//}