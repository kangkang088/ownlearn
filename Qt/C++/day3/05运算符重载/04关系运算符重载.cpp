//#include <iostream>
//using namespace std;
//
//class Person
//{
//public:
//	Person(string name, int age)
//	{
//		this->m_name = name;
//		this->m_age = age;
//	}
//	bool operator== (Person& p)
//	{
//		if (this->m_name == p.m_name && this->m_age == p.m_age)
//		{
//			return true;
//		}
//		return false;
//	}
//	bool operator!= (Person& p)
//	{
//		if (this->m_name == p.m_name && this->m_age == p.m_age)
//		{
//			return false;
//		}
//		return true;
//	}
//	string m_name;
//	int m_age;
//};
//void test1()
//{
//	Person p1("��ķ", 18);
//	Person p2("��ķ", 18);
//	if (p1 == p2)
//	{
//		cout << "p1��p2����ȵ�" << endl;
//	}
//	else
//	{
//		cout << "p1��p2�����" << endl;
//	}
//	if (p1 != p2)
//	{
//		cout << "p1��p2�����" << endl;
//	}
//	else
//	{
//		cout << "p1��p2����ȵ�" << endl;
//	}
//}
//int main()
//{
//	test1();
//}