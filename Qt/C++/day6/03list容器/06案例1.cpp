#include <iostream>
#include <fstream>
#include <vector>
#include <algorithm>
#include <string>
#include <deque>
#include <stack>
#include <queue>
#include <list>

using namespace std;

class Person
{
public:
	Person() {}
	Person(string name, int age, double height)
	{
		this->m_name = name;
		this->m_age = age;
		this->m_height = height;
	}
	string m_name;
	int m_age;
	double m_height;
};

//指定排序规则
bool myComparePerson(Person& p1, Person& p2)
{
	if (p1.m_age == p2.m_age)
	{
		return p1.m_height > p2.m_height;
	}
	return p1.m_age < p2.m_age;
}
void test1()
{
	list<Person> l1;
	Person p1("刘备", 35, 175);
	Person p2("曹操", 45, 180);
	Person p3("孙权", 40, 170);
	Person p4("赵云", 25, 190);
	Person p5("张飞", 35, 160);
	Person p6("关羽", 35, 200);

	//年龄升序排列，年龄一样，按身高降序
	l1.push_back(p1);
	l1.push_back(p2);
	l1.push_back(p3);
	l1.push_back(p4);
	l1.push_back(p5);
	l1.push_back(p6);

	for (list<Person>::iterator it = l1.begin(); it != l1.end(); it++)
	{
		cout << "姓名：" << (*it).m_name << ",年龄：" << (*it).m_age << ",身高：" << (*it).m_height << endl;
	}

	//排序后
	cout << "-------------------------------------" << endl;
	l1.sort(myComparePerson);
	for (list<Person>::iterator it = l1.begin(); it != l1.end(); it++)
	{
		cout << "姓名：" << (*it).m_name << ",年龄：" << (*it).m_age << ",身高：" << (*it).m_height << endl;
	}
}
int main()
{
	test1();
}