//#include <iostream>
//using namespace std;
//
//class Person
//{
//public:
//	/*Person operator+ (Person& person)
//	{
//		Person temp;
//		temp.m_a = this->m_a + person.m_a;
//		temp.m_b = this->m_b + person.m_b;
//		return temp;
//	}*/
//	int m_a;
//	int m_b;
//};
//Person operator+ (Person& p1,Person& p2)
//{
//	Person temp;
//	temp.m_a = p1.m_a + p2.m_a;
//	temp.m_b = p1.m_b + p2.m_b;
//	return temp;
//}
//void test1()
//{
//	Person p1;
//	p1.m_a = 10;
//	p1.m_b = 10;
//	Person p2;
//	p2.m_a = 20;
//	p2.m_b = 20;
//	Person p3 = p1 + p2;
//	//成员函数本质 Person p3 = p1.operator+ (p2);
//	//全局函数本质 Person p3 = operator+ (p1,p2);
//	cout << p3.m_a << " " << p3.m_b << endl;
//}
//int main()
//{
//	test1();
//}