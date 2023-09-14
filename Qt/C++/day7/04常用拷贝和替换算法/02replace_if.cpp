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
//class MyPrint
//{
//public:
//	void operator() (int val)
//	{
//		cout << val << " ";
//	}
//};
//class Greater30
//{
//public:
//	bool operator()(int val)
//	{
//		return val >= 30;
//	}
//};
//void test1()
//{
//	vector<int> v;
//	v.push_back(10);
//	v.push_back(40);
//	v.push_back(20);
//	v.push_back(40);
//	v.push_back(30);
//	v.push_back(50);
//	v.push_back(20);
//	v.push_back(30);
//
//	cout << "Ìæ»»Ç°£º" << endl;
//	for_each(v.begin(), v.end(), MyPrint());
//	cout << endl;
//
//	cout << "Ìæ»»ºó£»" << endl;
//	replace_if(v.begin(), v.end(), Greater30(), 3000);
//	for_each(v.begin(), v.end(), MyPrint());
//	cout << endl;
//}
//int main()
//{
//	test1();
//}