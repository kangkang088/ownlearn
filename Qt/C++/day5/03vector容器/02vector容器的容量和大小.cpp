//#include <iostream>
//#include <fstream>
//#include <vector>
//using namespace std;
//
//void printVector(vector<int>& v)
//{
//	for (vector<int>::iterator it = v.begin(); it != v.end(); it++)
//	{
//		cout << *it << " ";
//	}
//	cout << endl;
//}
//void test1()
//{
//    vector<int> v1;
//	for (int i = 0; i < 10; i++)
//	{
//		v1.push_back(i);
//	}
//	printVector(v1);
//
//	if (v1.empty())
//	{
//		cout << "v1Ϊ��" << endl;
//	}
//	else
//	{
//		cout << "v1��Ϊ��" << endl;
//		cout << "v1������Ϊ" << v1.capacity() << endl;
//		cout << "v1�Ĵ�СΪ" << v1.size() << endl;
//	}
//
//	//�����ƶ���С
//	v1.resize(15,6);
//	printVector(v1);
//	v1.resize(5);
//	printVector(v1);
//
//}
//int main()
//{
//	test1();
//}