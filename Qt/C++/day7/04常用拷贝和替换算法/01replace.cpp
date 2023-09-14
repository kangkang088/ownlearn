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
//
//};
//void test1()
//{
//	vector<int> v1;
//	v1.push_back(20);
//	v1.push_back(20);
//	v1.push_back(320);
//	v1.push_back(40);
//	v1.push_back(50);
//	v1.push_back(60);
//	v1.push_back(230);
//	v1.push_back(260);
//	v1.push_back(220);
//	v1.push_back(210);
//	v1.push_back(280);
//
//	cout << "Ìæ»»Ç°£º" << endl;
//	for_each(v1.begin(), v1.end(), MyPrint());
//	cout << endl;
//
//	cout << "Ìæ»»ºó£º" << endl;
//	replace(v1.begin(), v1.end(), 20, 2000);
//	for_each(v1.begin(), v1.end(), MyPrint());
//	cout << endl;
//}
//int main()
//{
//	test1();
//}