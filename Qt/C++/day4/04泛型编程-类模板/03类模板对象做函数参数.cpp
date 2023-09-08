#include <iostream>
#include <fstream>
using namespace std;

//类模板的对象做函数参数
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
//1.指定传入类型
void printPerson1(Person<string, int>& p)
{
	p.showPerson();
}
void test1()
{
	Person<string, int> p("孙悟空", 100);
	printPerson1(p);
}

//2.参数模板化
template<class T1, class T2>
void printPerson2(Person<T1, T2>& p)
{
	p.showPerson();
	cout << "T1的类型为：" << typeid(T1).name() << endl;
	cout << "T2的类型为：" << typeid(T2).name() << endl;
}
void test2()
{
	Person<string, int>p("猪八戒", 150);
	printPerson2(p);
}

//3.整个类模板化
template<class T>
void printPerson3(T& p)
{
	p.showPerson();
	cout << "T的数据类型：" << typeid(T).name() << endl;
}
void test3()
{
	Person<string, int>p("唐僧", 30);
	printPerson3(p);
}
int main()
{
	test1();
	test2();
	test3();
}