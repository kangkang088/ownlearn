//#include <iostream>
//#include <fstream>
//using namespace std;
//
////注意事项
////1.自动类型推导的类型必须一致才可以使用
//template<typename T>
//void mySwap(T& a, T& b)
//{
//	T temp = a;
//	a = b;
//	b = temp;
//}
//void test1()
//{
//	int a = 10;
//	int b = 20;
//	mySwap(a, b);
//	cout << "a = " << a << ", " << "b = " << b << endl;
//	
//	//char c = 'a';
//	//mySwap(a, c);//错误，T类型不一致
//}
////2.模板必须要确定出T的数据类型才可以使用
//template<typename T>
//void func()
//{
//	cout << "func()函数被调用" << endl;
//}
//void test2()
//{
//	//func();//错误，T的类型没有确定出来
//	func<int>();//只能显示指定T了
//}
//int main()
//{
//	test1();
//	test2();
//}