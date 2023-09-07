//#include <iostream>
//using namespace std;
//
//class Person
//{
//public:
//	static int m_a;
//private:
//	//类外访问不到
//	static int m_b;
//};
//int Person::m_a = 5;
//int Person::m_b = 20;
//void test1()
//{
//	Person p;
//	cout << p.m_a << endl;
//	Person p2;
//	p2.m_a = 200;
//	cout << p.m_a << "  " << p2.m_a << endl;
//}
//void test2()
//{
//	Person p;
//	cout << p.m_a << endl;
//	cout << Person::m_a << endl;
//}
//int main()
//{
//	test1();
//	//test2();
//}