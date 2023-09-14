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
////merge 两个容器元素合并，并存储到一个新的容器中，
////两个容器必须是有序的
////新容器也将会是有序的
//
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
//		v2.push_back(i+1);
//	}
//
//	vector<int> vTarget;
//	vTarget.resize(v1.size() + v2.size());
//	merge(v1.begin(), v1.end(), v2.begin(), v2.end(), vTarget.begin());
//	for_each(vTarget.begin(), vTarget.end(), myPrint);
//}
//int main()
//{
//	test1();
//}