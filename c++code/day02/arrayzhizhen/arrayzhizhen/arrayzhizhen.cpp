// arrayzhizhen.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
//

#include <iostream>
using namespace std;
//int main()
//{
//    char a;     cout << "sizeof（char）=" << sizeof(char) << endl;
//    short b;   cout << "sizeof（short）=" << sizeof(short) << endl;
//    int c;        cout << "sizeof（int）=" << sizeof(int) << endl;
//    double d; cout << "sizeof（double）=" << sizeof(double) << endl;
//    cout << "a的地址是：" << (void*) & a << endl;
//    cout << "a的地址+ 1是：" << (void*) (& a + 1) << endl;
//
//    cout << "b的地址是：" << (void*) & b << endl;
//    cout << "b的地址+ 1是：" << (void*) (& b + 1) << endl;
//
//    cout << "c的地址是：" << (void*)&c << endl;
//    cout << "c的地址+ 1是：" << (void*)(& c + 1) << endl;
//    
//    cout << "d的地址是：" << (void*)&d << endl;
//    cout << "d的地址+ 1是：" << (void*)(& d + 1) << endl;
//}
int main()
{
	int a[5] = {3,6,5,8,9};
	cout << "a的值是 = " << (long long)a << endl;
	cout << "&a的值是 = " << (long long)&a << endl;
	for (int i = 0; i < 5; i++)
	{
		//a[i] = i + 100;
		cout << "a[" << i << "]的是 = " << (long long)a[i] << endl;
		
	}
	
	
	int* p = a;
	for (int i = 0; i < 5; i++)
	{
		cout << "*(p +" << i << ")的值是 = " << (long long)*(p + i) << endl;
		cout << "p[" << i << "]的是 = " << (long long)p[i] << endl;
	}
	/*cout << "p的值是 = " << (long long)*p << endl;
	cout << "*(p +0)的值是 = " << (long long)*(p + 0) << endl;
	cout << "(p +1)的值是 = " << (long long)*(p + 1) << endl;
	cout << "*(p +2)的值是 = " << (long long)*(p + 2) << endl;
	cout << "*(p +3)的值是 = " << (long long)*(p + 3) << endl;
	cout << "*(p +4)的值是 = " << (long long)*(p + 4) << endl;*/
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
