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
//	Person p1("汤姆", 18);
//	Person p2("汤姆", 18);
//	if (p1 == p2)
//	{
//		cout << "p1和p2是相等的" << endl;
//	}
//	else
//	{
//		cout << "p1和p2不相等" << endl;
//	}
//	if (p1 != p2)
//	{
//		cout << "p1和p2不相等" << endl;
//	}
//	else
//	{
//		cout << "p1和p2是相等的" << endl;
//	}
//}
//int main()
//{
//	test1();
//}