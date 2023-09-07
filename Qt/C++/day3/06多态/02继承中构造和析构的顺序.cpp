//#include <iostream>
//using namespace std;
//
//class Base
//{
//public:
//	Base()
//	{
//		cout << "Base()的构造函数" << endl;
//	}
//	~Base()
//	{
//		cout << "Base()的析构函数" << endl;
//	}
//};
//class Son :public Base
//{
//public:
//	Son()
//	{
//		cout << "Son()的构造函数" << endl;
//	}
//	~Son()
//	{
//		cout << "Son()的析构函数" << endl;
//	}
//};
//void test1()
//{
//	Son son1;
//	//继承中 先调用父类构造函数，再调用子类构造函数
//	//析构顺序与构造相反
//}
//int main()
//{
//	test1();
//}