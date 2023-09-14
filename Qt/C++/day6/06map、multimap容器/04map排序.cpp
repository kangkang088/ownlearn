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
//class CompareMap
//{
//public:
//	bool operator() (int v1,int v2) const
//	{
//		return v1 > v2;
//	}
//};
//void printMap(map<int, int,CompareMap>& m)
//{
//	for (map<int,int,CompareMap>::iterator it = m.begin(); it != m.end(); it++)
//	{
//		cout << "key = " << (*it).first << ",value = " << (*it).second << endl;
//	}
//	cout << endl;
//}
//void test1()
//{
//	//默认从小到大排序(key)
//	map<int, int,CompareMap> m1;
//	m1.insert(make_pair(1, 10));
//	m1.insert(make_pair(2, 20));
//	m1.insert(make_pair(3, 30));
//	m1.insert(make_pair(4, 40));
//	m1.insert(make_pair(5, 50));
//
//	printMap(m1);
//}
//int main()
//{
//	test1();
//}