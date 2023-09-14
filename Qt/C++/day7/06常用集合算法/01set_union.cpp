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
////set_union 两个容器的并集
//// 必须是有序序列
//void myPrint(int val)
//{
//	cout << val << " ";
//}
//void test1()
//{
//	vector<int> v1;
//	vector<int> v2;
//
//	for (int i = 0; i < 10; i++)
//	{
//		v1.push_back(i);
//		v2.push_back(i + 5);
//	}
//
//	vector<int> vTarget;
//	//提前开辟空间
//	vTarget.resize(v1.size() + v2.size());
//
//	vector<int>::iterator itEnd = set_union(v1.begin(), v1.end(), v2.begin(), v2.end(), vTarget.begin());
//	for_each(vTarget.begin(), itEnd, myPrint);
//	cout << endl;
//
//}
//int main()
//{
//	test1();
//}