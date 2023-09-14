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
		//�������併��
		return p1.m_age > p2.m_age;
	}
};
void test1()
{
	//�Զ�����������Ҫָ������������÷º���
	set<Person,ComparePerson> s1;
	Person p1("����",24);
	Person p2("����",28);
	Person p3("�ŷ�",25);
	Person p4("����",21);

	s1.insert(p1);
	s1.insert(p2);
	s1.insert(p3);
	s1.insert(p4);

	for (set<Person,ComparePerson>::iterator it = s1.begin(); it != s1.end(); it++)
	{
		cout << "������" << (*it).m_name << "�����䣺" << (*it).m_age << endl;
	}
	cout << endl;
}
int main()
{
	test1();
}