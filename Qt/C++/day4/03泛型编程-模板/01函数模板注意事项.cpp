//#include <iostream>
//#include <fstream>
//using namespace std;
//
////ע������
////1.�Զ������Ƶ������ͱ���һ�²ſ���ʹ��
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
//	//mySwap(a, c);//����T���Ͳ�һ��
//}
////2.ģ�����Ҫȷ����T���������Ͳſ���ʹ��
//template<typename T>
//void func()
//{
//	cout << "func()����������" << endl;
//}
//void test2()
//{
//	//func();//����T������û��ȷ������
//	func<int>();//ֻ����ʾָ��T��
//}
//int main()
//{
//	test1();
//	test2();
//}