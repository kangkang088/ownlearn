//#include <iostream>
//#include <fstream>
//#include <vector>
//#include <algorithm>
//#include <string>
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
////����ʹ��
//void test1()
//{
//    vector<int> v1;
//	for (int i = 0; i < 10; i++)
//	{
//		v1.push_back(i);
//	}
//	cout << "����ǰ��" << endl;
//	printVector(v1);
//
//	vector<int> v2;
//	for (int i = 10; i > 0; i--)
//	{
//		v2.push_back(i);
//	}
//	printVector(v2);
//
//	cout << "������" << endl;
//	v1.swap(v2);
//	printVector(v1);
//	printVector(v2);
//
//}
//
////ʵ����;
////����swap���������ڴ�ռ�
//void test2()
//{
//	vector<int> v;
//	for (int i = 0; i < 100000; i++)
//	{
//		v.push_back(i);
//	}
//	cout << "v��������" << v.capacity() << endl;
//	cout << "v�Ĵ�С��" << v.size() << endl;
//
//	v.resize(3);//����ָ����С�������������
//	cout << "v��������" << v.capacity() << endl;
//	cout << "v�Ĵ�С��" << v.size() << endl;
//
//	//����swap����
//	vector<int>(v).swap(v);
//	//vector<int>(v) :���������ص���ִ���굱ǰ������ɾ����������Ϊx
//	//������������x����v����ʼ������ʱ�����ʹ�С����3.
//	//Ȼ��x.swap(v),x��v���������ﵽ��v resize(3)��Ч�������������ͷ���������
//	cout << "v��������" << v.capacity() << endl;
//	cout << "v�Ĵ�С��" << v.size() << endl;
//}
//int main()
//{
//	//test1();
//	test2();
//}