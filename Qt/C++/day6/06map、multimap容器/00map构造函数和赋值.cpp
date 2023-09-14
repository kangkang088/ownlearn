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
//void printMap(map<int,int>& m)
//{
//	for (map<int,int>::iterator it = m.begin(); it != m.end(); it++)
//	{
//		cout << "key = " << (*it).first << ",value = " << (*it).second << endl;;
//	}
//	cout << endl;
//}
//void test1()
//{
//	map<int, int> m1;
//	m1.insert(pair<int,int>(1,10));
//	m1.insert(pair<int,int>(2,20));
//	m1.insert(pair<int,int>(3,30));
//	m1.insert(pair<int,int>(4,40));
//	
//	printMap(m1);
//
//	//øΩ±¥ππ‘Ï
//	map<int, int> m2(m1);
//	printMap(m2);
//
//	//=
//	map<int, int> m3;
//	m3 = m2;
//	printMap(m3);
//}
//int main()
//{
//	test1();
//}