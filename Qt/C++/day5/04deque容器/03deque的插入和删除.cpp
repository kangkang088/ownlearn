//#include <iostream>
//#include <fstream>
//#include <vector>
//#include <algorithm>
//#include <string>
//#include <deque>
//using namespace std;
//
////deque容器的插入和删除
//
//void printDeque(const deque<int>& d)
//{
//	for (deque<int>::const_iterator it = d.begin(); it != d.end(); it++)
//	{
//		cout << *it << " ";
//	}
//	cout << endl;
//}
////两端操作
//void test1()
//{
//	deque<int> d1;
//
//	//尾插
//	d1.push_back(10);
//	d1.push_back(20);
//
//	//头插
//	d1.push_front(100);
//	d1.push_front(200);
//
//	printDeque(d1);
//
//	//尾删
//	d1.pop_back();
//	printDeque(d1);
//
//	//头删
//	d1.pop_front();
//	printDeque(d1);
//}
//
////指定位置操作
//void test2()
//{
//	deque<int> d1;
//	d1.push_back(10);
//	d1.push_back(20);
//	d1.push_front(100);
//	d1.push_front(200);
//	printDeque(d1);
//
//	//insert
//	d1.insert(d1.begin(), 1000);
//	printDeque(d1);
//
//	d1.insert(d1.begin(), 2, 10000);
//	printDeque(d1);
//
//	//按区间插入
//	deque<int> d2;
//	d2.push_back(1);
//	d2.push_back(2);
//	d2.push_back(3);
//
//	d1.insert(d1.begin(), d2.begin(), d2.end());
//	printDeque(d1);
//
//}
//void test3()
//{
//	deque<int> d1;
//	d1.push_back(10);
//	d1.push_back(20);
//	d1.push_front(100);
//	d1.push_front(200);
//
//	//删除
//	deque<int>::iterator it = d1.begin();
//	it++;
//	d1.erase(it);
//	printDeque(d1);
//
//	//按区间删除
//	d1.erase(d1.begin(), d1.end()); // = d1.clear(); 
//	printDeque(d1);
//
//}
//int main()
//{
//	//test1();
//	//test2();
//	test3();
//}