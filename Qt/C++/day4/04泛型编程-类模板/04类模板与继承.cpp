//#include <iostream>
//#include <fstream>
//using namespace std;
//
//template <class T>
//class Base
//{public:
//	Base()
//	{
//		cout << typeid(T).name() << endl;
//	}
//	T m;
//};
////1.继承的父类是一个模板，则必须显示指定T的类型
////class Son :public Base 错误
//class Son1 :public Base<int>
//{
//
//};
//void test1()
//{
//	Son1 s1;
//}
////2.如果想灵活指定T的类型，子类也必须变成一个模板
//template <class T1,class T2>
//class Son2 :public Base<T2>
//{
//public:
//	Son2()
//	{
//		cout << typeid(T1).name() << endl;
//		cout << typeid(T2).name() << endl;
//	}
//	T1 obj;
//};
//void test2()
//{
//	Son2<int, char> s2;
//	
//}
//int main()
//{
//	test2();
//}