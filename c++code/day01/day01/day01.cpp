// day01.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
//

#include <iostream>
using namespace std;
int main()
{
	/*int a;
	char b;
	bool c;
	string d;
	int *pa = &a;
	char *pb = &b;
	bool *pc = &c;
	string *pd = &d;
	cout << &a << endl;
	cout << &b << endl;
	cout << &c << endl;
	cout << &d << endl;
	cout << endl;
	cout << (void*)  pa << endl;
	cout << (void*)  pb << endl;
	cout << (void*)  pc << endl;
	cout << (void*)  pd << endl;
	cout << endl;
	cout << (long long) & a << endl;
	cout << (long long) & b << endl;
	cout << (long long) & c << endl;
	cout << (long long) & d << endl;*/


	int a = 3;
	int* p = &a;
	int* p1 = &a;

	cout << a << endl;
	cout << *p << endl;
	cout << *p1 << endl;
	*p1 = 8;
	cout << a << endl;
	cout << *p << endl;
	cout << *p1 << endl;

	cout << &a << endl;
	cout << p << endl;
	cout << p1 << endl;
}

// 运行程序: Ctrl + F5 或调试 >“开始执行(不调试)”菜单
// 调试程序: F5 或调试 >“开始调试”菜单

// 入门使用技巧: 
//   1. 使用解决方案资源管理器窗口添加/管理文件
//   2. 使用团队资源管理器窗口连接到源代码管理
//   3. 使用输出窗口查看生成输出和其他消息
//   4. 使用错误列表窗口查看错误
//   5. 转到“项目”>“添加新项”以创建新的代码文件，或转到“项目”>“添加现有项”以将现有代码文件添加到项目
//   6. 将来，若要再次打开此项目，请转到“文件”>“打开”>“项目”并选择 .sln 文件
