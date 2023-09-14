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
////set容器的构造和赋值
//void test1()
//{
//	set<int> s1;
//	s1.insert(10);
//	s1.insert(40);
//	s1.insert(20);
//	s1.insert(30);
//
//	//遍历容器
//	//所有的元素插入时会自动排序
//	//不允许插入重复值，
//	printSet(s1);
//
//	//拷贝构造
//	set<int> s2(s1);
//	printSet(s2);
//
//	//=
//	set<int> s3;
//	s3 = s2;
//	printSet(s3);
//}
//int main()
//{
//	test1();
//}