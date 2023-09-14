//#include <iostream>
//#include <fstream>
//#include <vector>
//#include <algorithm>
//#include <string>
//#include <deque>
//#include <stack>
//#include <queue>
//#include <list>
//#include <set>
//#include <map>
//
//using namespace std;
//
////1.查找内置数据类型
//class Greater
//{
//public:
//	bool operator()(int val)
//	{
//		return val > 5;
//	}
//};
//void test1()
//{
//	vector<int> v;
//	for (int i = 0; i < 10; i++)
//	{
//		v.push_back(i);
//	}
//
//	vector<int>::iterator it = find_if(v.begin(), v.end(), Greater());
//	if (it == v.end())
//	{
//		cout << "没有找到" << endl;
//	}
//	else
//	{
//		cout << "找到了大于五的数字：" << *it << endl;
//	}
//}
//
//
////2.查找自定义数据类型
//class Person
//{
//public:
//	Person(string name, int age)
//	{
//		this->m_name = name;
//		this->m_age = age;
//	}
//	string m_name;
//	int m_age;
//};
//class Greater20
//{
//public:
//	bool operator()(Person& p)
//	{
//		return p.m_age > 20;
//	}
//};
//void test2()
//{
//	vector<Person> v;
//	Person p1("aaa", 10);
//	Person p2("bbb", 20);
//	Person p3("ccc", 30);
//	Person p4("ddd", 40);
//
//	v.push_back(p1);
//	v.push_back(p2);
//	v.push_back(p3);
//	v.push_back(p4);
//
//	vector<Person>::iterator it = find_if(v.begin(), v.end(), Greater20());
//	if (it==v.end())
//	{
//		cout << "没有找到" << endl;
//	}
//	else
//	{
//		cout << "找到了，姓名：" << (*it).m_name << "，年龄：" << (*it).m_age << endl;
//	}
//
//}
//int main()
//{
//	//test1();
//	test2();
//}