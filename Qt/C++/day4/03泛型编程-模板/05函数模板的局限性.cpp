#include <iostream>
#include <fstream>
using namespace std;

class Person
{

public:
	Person(string name, int age)
	{
		this->m_name = name;
		this->m_age = age;
	}
	string m_name;
	int m_age;
};
template <typename T>
bool myCompare(T& a, T& b)
{
	if (a == b)
	{
		return true;
	}
	return false;
}
void test1()
{
	int a = 10;
	int b = 20;
	bool b1 = myCompare(a, b);
	if (b1)
	{
		cout << "a��b���" << endl;
	}
	else
	{
		cout << "a��b�����" << endl;
	}
}
//������޷��Ƚ�
// 1.�����������ṩ��������ؽ��
// 2.���þ��廯Person�İ汾ʵ�ִ��룬���廯���ȵ���

template<> bool myCompare(Person& a, Person& b)
{
	if (a.m_name == b.m_name && a.m_age == b.m_age)
	{
		return true;
	}
	return false;
}



void test2()
{
	Person p1("tom", 10);
	Person p2("tom", 100);
	bool b1 = myCompare(p1, p2);
	if (b1)
	{
		cout << "p1��p2���" << endl;

	}
	else
	{
		cout << "p1��p2�����" << endl;
	}
}
int main()
{
	test1();
	test2();
}