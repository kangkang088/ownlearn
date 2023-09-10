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
////基本使用
//void test1()
//{
//    vector<int> v1;
//	for (int i = 0; i < 10; i++)
//	{
//		v1.push_back(i);
//	}
//	cout << "交换前：" << endl;
//	printVector(v1);
//
//	vector<int> v2;
//	for (int i = 10; i > 0; i--)
//	{
//		v2.push_back(i);
//	}
//	printVector(v2);
//
//	cout << "交换后：" << endl;
//	v1.swap(v2);
//	printVector(v1);
//	printVector(v2);
//
//}
//
////实际用途
////巧用swap可以收缩内存空间
//void test2()
//{
//	vector<int> v;
//	for (int i = 0; i < 100000; i++)
//	{
//		v.push_back(i);
//	}
//	cout << "v的容量：" << v.capacity() << endl;
//	cout << "v的大小：" << v.size() << endl;
//
//	v.resize(3);//重新指定大小，但容量不会变
//	cout << "v的容量：" << v.capacity() << endl;
//	cout << "v的大小：" << v.size() << endl;
//
//	//巧用swap收缩
//	vector<int>(v).swap(v);
//	//vector<int>(v) :匿名对象，特点是执行完当前行立即删除，假设它为x
//	//创建匿名对象x，用v来初始化，此时容量和大小都是3.
//	//然后x.swap(v),x和v互换，来达到将v resize(3)的效果，并且立刻释放匿名对象
//	cout << "v的容量：" << v.capacity() << endl;
//	cout << "v的大小：" << v.size() << endl;
//}
//int main()
//{
//	//test1();
//	test2();
//}