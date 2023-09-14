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
//
////仿函数 返回值类型是bool类型 称为谓词
////一元谓词
//
//class GreaterFive
//{
//public:
//	bool operator() (int val) const
//	{
//		return val > 5;
//	}
//
//};
//
//void test1()
//{
//	vector<int> v;
//	for (int i = 0; i < 10; i++)
//	{
//		v.push_back(i);
//	}
//
//	//查找容器中有没有大于五的数字
//	//GreaterFive()：匿名函数对象
//	vector<int>::iterator it = find_if(v.begin(), v.end(), GreaterFive());
//	if (it == v.end())
//	{
//		cout << "未找到大于五的数字" << endl;
//	}
//	else {
//		cout << "找到了大于五的数字，为：" << *it << endl;
//	}
//}
//int main()
//{
//	test1();
//}