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
////1.�̳еĸ�����һ��ģ�壬�������ʾָ��T������
////class Son :public Base ����
//class Son1 :public Base<int>
//{
//
//};
//void test1()
//{
//	Son1 s1;
//}
////2.��������ָ��T�����ͣ�����Ҳ������һ��ģ��
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