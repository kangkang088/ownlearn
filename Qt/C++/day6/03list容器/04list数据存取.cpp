//#include <iostream>
//#include <fstream>
//#include <vector>
//#include <algorithm>
//#include <string>
//#include <deque>
//#include <stack>
//#include <queue>
//#include <list>
//
//using namespace std;
//
//void printList(const list<int>& l)
//{
//	for (list<int>::const_iterator it = l.begin(); it != l.end(); it++)
//	{
//		cout << *it << " ";
//	}
//	cout << endl;
//}
//void test1()
//{
//	list<int> l1;
//	l1.push_back(10);
//	l1.push_back(20);
//	l1.push_back(30);
//	l1.push_back(40);
//
//	//list是链表，非连续的，不支持[]和at() 
//	cout << "第一个元素：" << l1.front() << endl;
//	cout << "最后一个元素：" << l1.back() << endl;
//
//	//验证双向
//	list<int>::iterator it = l1.begin();
//	it++;
//	it--;//不报错，就是双向
//	//验证随机访问
//	//it = it + 1;//报错，不支持随机访问
//
//}
//int main()
//{
//	test1();
//}