#include <iostream>
#include <fstream>
#include <vector>
#include <algorithm>
#include <string>
//#include <deque>
//#include <stack>
//#include <queue>
//#include <list>
//#include <set>
//#include <map>
//#include <functional>
//
//using namespace std;
//
////内建函数对象 关系仿函数-大于 greater
//
////自己提供的仿函数
////class MyCompare
////{
////public:
////	bool operator() (int v1, int v2)
////	{
////		return v1 > v2;
////	}
////};
//
//void myValue(int val)
//{
//	cout << val << " ";
//}
//void test1()
//{
//	vector<int> v;
//	v.push_back(10);
//	v.push_back(30);
//	v.push_back(40);
//	v.push_back(20);
//	v.push_back(50);
//
//	/*for (vector<int>:: iterator it = v.begin(); it != v.end(); it++)
//	{
//		cout << *it << " ";
//	}*/
//
//	cout << "排序前：" << endl;
//	for_each(v.begin(), v.end(), myValue);
//	cout << endl;
//
//	//降序
//
//	//自己建立的仿函数
//	//sort(v.begin(), v.end(),MyCompare());
//
//	//内建的仿函数
//	sort(v.begin(), v.end(), greater<int>());
//
//
//	cout << "排序后：" << endl;
//	for_each(v.begin(), v.end(), myValue);
//	cout << endl;
//}
//int main()
//{
//	test1();
//}