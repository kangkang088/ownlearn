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
////查找相邻重复元素
////找到了，返回相邻元素的第一个位置的迭代器
////没有，返回end()；
//void test1()
//{
//	vector<int> v;
//	v.push_back(0);
//	v.push_back(2);
//	v.push_back(0);
//	v.push_back(3);
//	v.push_back(1);
//	v.push_back(4);
//	v.push_back(3);
//	v.push_back(3);
//
//	vector<int>::iterator pos = adjacent_find(v.begin(), v.end());
//	if (pos==v.end())
//	{
//		cout << "没有找到相邻重复元素" << endl;
//	}
//	else
//	{
//		cout << "找到了相邻重复元素：" << *pos << endl;
//	}
//}
//int main()
//{
//	test1();
//}