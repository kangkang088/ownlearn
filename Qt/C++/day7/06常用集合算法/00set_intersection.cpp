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
//#include <numeric>
//
//using namespace std;
////set_intersection ���������Ľ���
////��������������
//void myPrint(int val)
//{
//	cout << val << " ";
//}
//void test1()
//{
//	vector<int> v1;
//	vector<int> v2;
//
//	vector<int> vTarget;
//	for (int i = 0; i < 10; i++)
//	{
//		v1.push_back(i);
//		v2.push_back(i+5);
//	}
//
//	//Ŀ������Ҫ��ǰ���ٿռ�
//	//���������գ�������������С��������СȡΪС�����Ĵ�С
//	vTarget.resize(min(v1.size(), v2.size()));
//
//	//���ؽ��������һ��Ԫ�ص���һ��λ�õĵ�����
//	vector<int>::iterator itEnd = set_intersection(v1.begin(), v1.end(), v2.begin(), v2.end(), vTarget.begin());
//	//cout << *itEnd << endl;//0 ˵�����ص��ǽ��������һ��Ԫ�ص���һ��λ��
//	
//	//Ҫ��itEnd,������ǽ����Ľ���λ�ã������������Ľ���λ��
//	for_each(vTarget.begin(), itEnd, myPrint);
//	cout << endl;
//}
//int main()
//{
//	test1();
//}