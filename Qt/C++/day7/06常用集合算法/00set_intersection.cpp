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
//#include <numeric>
//
//using namespace std;
////set_intersection 两个容器的交集
////必须是有序序列
//void myPrint(int val)
//{
//	cout << val << " ";
//}
//void test1()
//{
//	vector<int> v1;
//	vector<int> v2;
//
//	vector<int> vTarget;
//	for (int i = 0; i < 10; i++)
//	{
//		v1.push_back(i);
//		v2.push_back(i+5);
//	}
//
//	//目标容器要提前开辟空间
//	//最特殊的清空，大容器包含了小容器，大小取为小容器的大小
//	vTarget.resize(min(v1.size(), v2.size()));
//
//	//返回交集的最后一个元素的下一个位置的迭代器
//	vector<int>::iterator itEnd = set_intersection(v1.begin(), v1.end(), v2.begin(), v2.end(), vTarget.begin());
//	//cout << *itEnd << endl;//0 说明返回的是交集的最后一个元素的下一个位置
//	
//	//要用itEnd,代表的是交集的结束位置，而不是容器的结束位置
//	for_each(vTarget.begin(), itEnd, myPrint);
//	cout << endl;
//}
//int main()
//{
//	test1();
//}