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
//ͳ��������������
class Greater20
{
public:
	bool operator() (int val)
	{
		return val > 20;
	}
};
void test1()
{
	vector<int> v;
	v.push_back(10);
	v.push_back(40);
	v.push_back(30);
	v.push_back(20);
	v.push_back(40);
	v.push_back(20);

	int num = count_if(v.begin(), v.end(), Greater20());
	cout << "����20��Ԫ�صĸ�����" << num << endl;
}
//ͳ���Զ�����������
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
class AgeGreater20
{
public:
	bool operator() (const Person& p)
	{
		return p.m_age > 20;
	}
};
void test2()
{
	vector<Person> v;
	Person p1("����", 35);
	Person p2("����", 35);
	Person p3("�ŷ�", 35);
	Person p4("����", 40);
	Person p5("�ܲ�", 20);

	v.push_back(p1);
	v.push_back(p2);
	v.push_back(p3);
	v.push_back(p4);
	v.push_back(p5);

	int num = count_if(v.begin(), v.end(), AgeGreater20());
	cout << "����20�����Ա������" << num << endl;
}
int main()
{
	//test1();
	test2();
}