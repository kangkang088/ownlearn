//#include <iostream>
//#include <fstream>
//#include <vector>
//#include <algorithm>
//#include <string>
//#include <deque>
//#include <stack>
//#include <queue>
//#include <list>
//
//using namespace std;
//
////list������С����
//
//void printList(const list<int>& l)
//{
//	for (list<int>::const_iterator it = l.begin(); it != l.end(); it++)
//	{
//		cout << *it << " ";
//	}
//	cout << endl;
//}
//
//void test1()
//{
//	list<int> l1;
//	l1.push_back(10);
//	l1.push_back(20);
//	l1.push_back(30);
//	l1.push_back(40);
//	printList(l1);
//
//	if (l1.empty())
//	{
//		cout << "l1Ϊ��" << endl;
//	}
//	else
//	{
//		cout << "l1��Ϊ��" << endl;
//		cout << "l1��Ԫ�ظ�����" << l1.size() << endl;
//	}
//
//	//�����ƶ���С
//	l1.resize(10,10000);
//	printList(l1);
//}
//int main()
//{
//	test1();
//	system("pause");
//}