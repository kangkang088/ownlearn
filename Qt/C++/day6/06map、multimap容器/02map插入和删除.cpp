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
//void test1()
//{
//	map<int, int> m1;
//
//	//插入
//	//1.
//	m1.insert(pair<int, int>(1, 10));
//	//2.
//	m1.insert(make_pair(2, 20));
//	//3.
//	m1.insert(map<int, int>::value_type(3, 30));
//	//4.
//	m1[4] = 40;//不建议用[]来添加，可以用[]来访问
//
//	printMap(m1);
//
//	//删除
//	m1.erase(m1.begin());
//	printMap(m1);
//
//	m1.erase(3);//按照key删除
//	printMap(m1);
//
//	//清空
//	//m1.erase(m1.begin(), m1.end());
//	m1.clear();
//	printMap(m1);
//}
//int main()
//{
//	test1();
//}