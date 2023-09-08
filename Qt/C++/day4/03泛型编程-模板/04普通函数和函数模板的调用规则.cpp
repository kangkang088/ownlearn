//#include <iostream>
//#include <fstream>
//using namespace std;
//
////1.如果函数模板和普通函数都可以实现，优先调用普通函数
//void myPrint(int a, int b)
//{
//	cout << "调用普通函数" << endl;
//}
//template <typename T>
//void myPrint(T a, T b)
//{
//	cout << "调用函数模板" << endl;
//}
//template <typename T>
//void myPrint(T a, T b, T c)
//{
//	cout << "调用重载函数模板" << endl;
//}
//
////2.可以通过空模板参数列表的方式，优先调用函数模板
////3.函数模板可以重载
////4.如果函数模板可以产生更好的匹配，优先调用函数模板
//
//int main()
//{
//	int a = 10;
//	int b = 10;
//	int c = 100;
//	//优先普通函数
//	myPrint(a, b);
//	//通过空模板参数列表，调用函数模板
//	myPrint<>(a, b);
//	//函数模板可以发生重载
//	myPrint(a, b, c);
//	//函数模板产生更好的匹配
//	char c1 = 'a';		
//	char c2 = 'b';
//	myPrint(c1, c2);
//
//}