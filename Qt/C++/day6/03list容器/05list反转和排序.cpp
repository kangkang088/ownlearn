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
//void printList(const list<int>& l)
//{
//	for (list<int>::const_iterator it = l.begin(); it != l.end(); it++)
//	{
//		cout << *it << " ";
//
//	}
//	cout << endl;
//}
//
//bool myCompare(int v1,int v2)
//{
//	//����
//	return v1 > v2;
//}
//void test1()
//{
//	list<int> l1;
//	l1.push_back(20);
//	l1.push_back(10);
//	l1.push_back(30);
//	l1.push_back(50);
//	l1.push_back(40);
//
//	cout << "��תǰ��" << endl;
//	printList(l1);
//
//	cout << "��ת��" << endl;
//	l1.reverse();
//	printList(l1);
//
//	cout << "����ǰ��" << endl;
//	printList(l1);
//
//	cout << "�����" << endl;
//	//���в�֧��������ʵ�������������������ȫ�ֵı�׼����
//	//sort(l1.begin(), l1.end());//����
//
//	//���в�֧��������ʵ��������������ڲ����ṩһЩ��Ӧ���㷨
//	//Ĭ�����򣬴�С����
//	l1.sort();
//	printList(l1);
//
//	//����
//	l1.sort(myCompare);
//	printList(l1);
//}
//int main()
//{
//	test1();
//}