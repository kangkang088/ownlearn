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
//void printSet(set<int>& s)
//{
//	for (set<int>::iterator it = s.begin(); it != s.end(); it++)
//	{
//		cout << *it << " ";
//	}
//	cout << endl;
//}
//void test1()
//{
//	set<int> s1;
//
//	//����
//	s1.insert(30);
//	s1.insert(10);
//	s1.insert(20);
//	s1.insert(40);
//
//	//����
//	printSet(s1);
//
//	//ɾ��
//	s1.erase(s1.begin());//����������˳��ɾ��
//	printSet(s1);
//
//	//ɾ�������ذ汾
//	s1.erase(30);
//	printSet(s1);
//
//	//���
//	s1.erase(s1.begin(), s1.end());
//	printSet(s1);
//}
//int main()
//{
//	test1();
//}