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
//
//	}
//	cout << endl;
//}
//
//bool myCompare(int v1,int v2)
//{
//	//降序
//	return v1 > v2;
//}
//void test1()
//{
//	list<int> l1;
//	l1.push_back(20);
//	l1.push_back(10);
//	l1.push_back(30);
//	l1.push_back(50);
//	l1.push_back(40);
//
//	cout << "反转前：" << endl;
//	printList(l1);
//
//	cout << "反转后：" << endl;
//	l1.reverse();
//	printList(l1);
//
//	cout << "排序前：" << endl;
//	printList(l1);
//
//	cout << "排序后：" << endl;
//	//所有不支持随机访问迭代器的容器，不能用全局的标准函数
//	//sort(l1.begin(), l1.end());//错误
//
//	//所有不支持随机访问迭代器的容器，内部会提供一些对应的算法
//	//默认升序，从小到大
//	l1.sort();
//	printList(l1);
//
//	//降序
//	l1.sort(myCompare);
//	printList(l1);
//}
//int main()
//{
//	test1();
//}