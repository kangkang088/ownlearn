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
//	}
//	cout << endl;
//}
//void test1()
//{
//	list<int> l1;
//	l1.push_back(10);
//	l1.push_back(20);
//	l1.push_back(30);
//	l1.push_back(40);
//
//	//list�������������ģ���֧��[]��at() 
//	cout << "��һ��Ԫ�أ�" << l1.front() << endl;
//	cout << "���һ��Ԫ�أ�" << l1.back() << endl;
//
//	//��֤˫��
//	list<int>::iterator it = l1.begin();
//	it++;
//	it--;//����������˫��
//	//��֤�������
//	//it = it + 1;//������֧���������
//
//}
//int main()
//{
//	test1();
//}