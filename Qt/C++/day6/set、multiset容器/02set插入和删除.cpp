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
//void printSet(set<int>& s)
//{
//	for (set<int>::iterator it = s.begin(); it != s.end(); it++)
//	{
//		cout << *it << " ";
//	}
//	cout << endl;
//}
//void test1()
//{
//	set<int> s1;
//
//	//插入
//	s1.insert(30);
//	s1.insert(10);
//	s1.insert(20);
//	s1.insert(40);
//
//	//遍历
//	printSet(s1);
//
//	//删除
//	s1.erase(s1.begin());//根据排序后的顺序删除
//	printSet(s1);
//
//	//删除的重载版本
//	s1.erase(30);
//	printSet(s1);
//
//	//清空
//	s1.erase(s1.begin(), s1.end());
//	printSet(s1);
//}
//int main()
//{
//	test1();
//}