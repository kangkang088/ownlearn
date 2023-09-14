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
////统计内置数据类型
//void test1()
//{
//	vector<int> v;
//	v.push_back(10);
//	v.push_back(40);
//	v.push_back(30);
//	v.push_back(40);
//	v.push_back(20);
//	v.push_back(40);
//
//	int num = count(v.begin(), v.end(), 40);
//	cout << "40的元素个数：" << num << endl;
//}
////统计自定义数据类型
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
//		if (this->m_age == p.m_age)
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
//	Person p1("刘备", 35);
//	Person p2("关羽", 35);
//	Person p3("张飞", 35);
//	Person p4("赵云", 30);
//	Person p5("曹操", 40);
//
//	v.push_back(p1);
//	v.push_back(p2);
//	v.push_back(p3);
//	v.push_back(p4);
//	v.push_back(p5);
//
//	Person p("诸葛亮", 35);
//	int num = count(v.begin(), v.end(), p);
//
//	cout << "和诸葛亮年龄一样的人数：" << num << endl;
//	
//}
//int main()
//{
//	//test1();
//	test2();
//}