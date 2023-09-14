//#include <iostream>
//#include <fstream>
//#include <vector>
//#include <algorithm>
//#include <string>
//#include <deque>
//using namespace std;
//
//void printDeque(const deque<int>& d)
//{
//	for (deque<int>::const_iterator it = d.begin(); it != d.end(); it++)
//	{
//		cout << *it << " ";
//	}
//	cout << endl;
//}
//void test1()
//{
//	deque<int> d;
//	d.push_back(10);
//	d.push_back(20);
//	d.push_back(30);
//	d.push_front(100);
//	d.push_front(200);
//	d.push_front(300);
//	printDeque(d);
//
//	//排序
//	//默认 从小到大 升序
//	//对支持随机访问的迭代器的容器，都可以用sort()来进行排序
//	sort(d.begin(), d.end());
//	printDeque(d);
//}
//int main()
//{
//	test1();
//}