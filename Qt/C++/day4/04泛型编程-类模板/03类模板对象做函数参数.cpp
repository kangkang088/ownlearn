#include <iostream>
#include <fstream>
using namespace std;

//��ģ��Ķ�������������
template<class T1, class T2>
class Person
{
public:
	Person(T1 name, T2 age)
	{
		this->m_name = name;
		this->m_age = age;
	}
	void showPerson()
	{
		cout << "name:" << this->m_name << "," << "age:" << this->m_age << endl;
	}
	T1 m_name;
	T2 m_age;
};
//1.ָ����������
void printPerson1(Person<string, int>& p)
{
	p.showPerson();
}
void test1()
{
	Person<string, int> p("�����", 100);
	printPerson1(p);
}

//2.����ģ�廯
template<class T1, class T2>
void printPerson2(Person<T1, T2>& p)
{
	p.showPerson();
	cout << "T1������Ϊ��" << typeid(T1).name() << endl;
	cout << "T2������Ϊ��" << typeid(T2).name() << endl;
}
void test2()
{
	Person<string, int>p("��˽�", 150);
	printPerson2(p);
}

//3.������ģ�廯
template<class T>
void printPerson3(T& p)
{
	p.showPerson();
	cout << "T���������ͣ�" << typeid(T).name() << endl;
}
void test3()
{
	Person<string, int>p("��ɮ", 30);
	printPerson3(p);
}
int main()
{
	test1();
	test2();
	test3();
}