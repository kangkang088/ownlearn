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
//void printMap(map<int, int>& m)
//{
//	for (map<int,int>::iterator it = m.begin(); it != m.end(); it++)
//	{
//		cout << "key = " << (*it).first << ",value = " << (*it).second << endl;
//	}
//	cout << endl;
//}
////大小
//void test1()
//{
//	map<int, int> m1;
//	m1.insert(pair<int, int>(1, 10));
//	m1.insert(pair<int, int>(2, 20));
//	m1.insert(pair<int, int>(3, 30));
//	m1.insert(pair<int, int>(4, 40));
//
//	if (m1.empty())
//	{
//		cout << "m1为空" << endl;
//	}
//	else
//	{
//		cout << "m1不为空" << endl;
//		cout << "m1的大小：" << m1.size() << endl;
//	}
//}
//
////交换
//void test2()
//{
//	map<int, int> m1;
//	m1.insert(pair<int, int>(1, 10));
//	m1.insert(pair<int, int>(2, 20));
//	m1.insert(pair<int, int>(3, 30));
//	m1.insert(pair<int, int>(4, 40));
//
//	map<int, int> m2;
//	m2.insert(pair<int, int>(10, 100));
//	m2.insert(pair<int, int>(20, 200));
//	m2.insert(pair<int, int>(30, 300));
//	m2.insert(pair<int, int>(40, 400));
//
//	cout << "交换前：" << endl;
//	printMap(m1);
//	printMap(m2);
//
//	cout << "交换后：" << endl;
//	m1.swap(m2);
//	printMap(m1);
//	printMap(m2);
//}
//int main()
//{
//	//test1();
//	test2();
//}