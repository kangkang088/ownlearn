#include <iostream>
#include <fstream>
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
////查找内置数据类型
//void test1()
//{
//	vector<int> v;
//	for (int i = 0; i < 10; i++)
//	{
//		v.push_back(i);
//	}
//
//	//查找容器中是否有5这个元素
//	vector<int>::iterator it = find(v.begin(), v.end(), 5);
//	if (it == v.end())
//	{
//		cout << "没有找到" << endl;
//	}
//	else
//	{
//		cout << "找到了：" << *it << endl;
//	}
//}
//
////查找自定义数据类型
//class Person
//{
//public:
//	Person(string name, int age)
//	{
//		this->m_name = name;
//		this->m_age = age;
//	}
//	bool operator== (const Person& p)
//	{
//		if (p.m_name == this->m_name && p.m_age == this->m_age)
//		{
//			return true;
//		}
//		return false;
//	}
//	string m_name;
//	int m_age;
//};
//void test2()
//{
//	vector<Person> v;
//
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
//	//操作自定义的数据类型时，自定义数据类型不知道如何操作 == 操作符，
//	//find的底层代码用到了 == 操作符，重载==，让find知道如何操作自定义数据类型
//
//	Person pp("bbb", 20);
//	//vector<Person>::iterator it = find(v.begin(), v.end(), p2);
//	vector<Person>::iterator it = find(v.begin(), v.end(), pp);
//	if (it == v.end())
//	{
//		cout << "没有找到" << endl;
//	}
//	else
//	{
//		cout << "找到了，" << "姓名：" << (*it).m_name << "，年龄：" << (*it).m_age << endl;
//	}
//}
//int main()
//{
//	//test1();
//	test2();
//}