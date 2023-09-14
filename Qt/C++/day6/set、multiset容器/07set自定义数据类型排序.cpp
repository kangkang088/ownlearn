#include <iostream>
#include <fstream>
#include <vector>
#include <algorithm>
#include <string>
#include <deque>
#include <stack>
#include <queue>
#include <list>
#include <set>
#include <map>

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
class ComparePerson
{
public:
	bool operator() (const Person& p1, const Person& p2) const
	{
		//按照年龄降序
		return p1.m_age > p2.m_age;
	}
};
void test1()
{
	//自定义数据类型要指定排序规则，利用仿函数
	set<Person,ComparePerson> s1;
	Person p1("刘备",24);
	Person p2("关羽",28);
	Person p3("张飞",25);
	Person p4("赵云",21);

	s1.insert(p1);
	s1.insert(p2);
	s1.insert(p3);
	s1.insert(p4);

	for (set<Person,ComparePerson>::iterator it = s1.begin(); it != s1.end(); it++)
	{
		cout << "姓名：" << (*it).m_name << "，年龄：" << (*it).m_age << endl;
	}
	cout << endl;
}
int main()
{
	test1();
}