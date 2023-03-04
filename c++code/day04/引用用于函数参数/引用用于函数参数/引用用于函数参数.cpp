// 引用用于函数参数.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
//

#include <iostream>
using namespace std;
void func1(int no, string str)
{
	no = 8;
	str = "我有一只小小鸟";
	cout << "亲爱的" << no << "号：" << str << endl;
}
void func2(int* no, string* str)
{
	*no = 8;
	*str = "我有一只小小鸟";
	cout << "亲爱的" << *no << "号：" << *str << endl;
}
void func3(int& no, string& str)
{
	no = 8;
	str = "我有一只小小鸟";
	cout << "亲爱的" << no << "号：" << str << endl;
}
void weiwei(int a)
{
	cout << "我喜欢你" << a << endl;
}
void biaobaishenqi(void(*p)(int))
{
	int a = 4;
	p(a);
}
int main()
{
	int bh = 3;
	string message = "我是一只傻傻鸟";
	//func1(bh, message);  传值
	//func2(&bh, &message);  传地址
	func3(bh,message);  //传引用
	cout << "亲爱的" << bh << "号：" << message << endl;
	biaobaishenqi(weiwei);
	void(*p)(int);
	p = weiwei;
	(*p)(bh);
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
