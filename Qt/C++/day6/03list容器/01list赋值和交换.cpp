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
//
////赋值
//void test1()
//{
//	list<int> l1;
//
//	//尾插
//	l1.push_back(10);
//	l1.push_back(20);
//	l1.push_back(30);
//	l1.push_back(40);
//	printList(l1);
//
//	//=
//	list<int> l2;
//	l2 = l1;
//	printList(l2);
//
//	//assign
//	list<int> l3;
//	l3.assign(l2.begin(), l2.end());
//	printList(l3);
//
//	//n个elem
//	list<int> l4;
//	l4.assign(10, 100);
//	printList(l4);
//}
//
////交换
//void test2()
//{
//	list<int> l1;
//
//	//尾插
//	l1.push_back(10);
//	l1.push_back(20);
//	l1.push_back(30);
//	l1.push_back(40);
//
//	list<int> l2;
//	l2.assign(10, 100);
//
//	cout << "交换前：" << endl;
//	printList(l1);
//	printList(l2);
//
//	cout << "交换后：" << endl;
//	l1.swap(l2);
//	printList(l1);
//	printList(l2);
//}
//int main()
//{
//	//test1();
//	test2();
//}