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
//
////��С
//void test1()
//{
//	set<int> s1;
//	s1.insert(10);
//	s1.insert(30);
//	s1.insert(40);
//	s1.insert(20);
//
//	printSet(s1);
//
//	//�ж��Ƿ�Ϊ��
//	if (s1.empty())
//	{
//		cout << "s1Ϊ��" << endl;
//	}
//	else
//	{
//		cout << "s1��Ϊ��" << endl;
//		cout << "s1�Ĵ�С��" << s1.size() << endl;
//	}
//}
//
////����
//void test2()
//{
//	set<int> s1;
//	s1.insert(10);
//	s1.insert(30);
//	s1.insert(40);
//	s1.insert(20);
//
//	set<int> s2;
//	s2.insert(100);
//	s2.insert(300);
//	s2.insert(400);
//	s2.insert(200);
//
//	cout << "����ǰ��" << endl;
//	printSet(s1);
//	printSet(s2);
//	cout << "����ǰ��" << endl;
//	s1.swap(s2);
//	printSet(s1);
//	printSet(s2);
//
//}
//int main()
//{
//	//test1();
//	test2();
//}