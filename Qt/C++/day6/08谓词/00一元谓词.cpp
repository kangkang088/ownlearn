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
////�º��� ����ֵ������bool���� ��Ϊν��
////һԪν��
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
//	//������������û�д����������
//	//GreaterFive()��������������
//	vector<int>::iterator it = find_if(v.begin(), v.end(), GreaterFive());
//	if (it == v.end())
//	{
//		cout << "δ�ҵ������������" << endl;
//	}
//	else {
//		cout << "�ҵ��˴���������֣�Ϊ��" << *it << endl;
//	}
//}
//int main()
//{
//	test1();
//}