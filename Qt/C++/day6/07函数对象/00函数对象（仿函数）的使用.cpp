#include <iostream>
#include <fstream>
#include <vector>
#include <algorithm>
#include <string>
#include <deque>
#include <stack>
#include <queue>
#include <list>
#include <set>
#include <map>

using namespace std;

class MyAdd
{
public:
	int operator() (int v1, int v2)
	{
		return v1 + v2;
	}
};
//1.函数对象在调用时，可以像普通函数那样调用，可以有参数，可以有返回值
void test1()
{
	MyAdd myAdd;
	cout << myAdd(10, 10) << endl;
}
//2.函数对象超出普通函数的概念，函数对象可以有自己的状态
class MyPrint
{
public:
	MyPrint()
	{
		this->count = 0;
	}
	void operator() (string test)
	{
		cout << test << endl;
		this->count++;
	}
	//要是普通函数，记录自己被调用多少次，则需要一个全局变量来统计调用次数
	//函数对象可以通过内部来记录
	int count; //内部自己的状态
};
void test2()
{
	MyPrint myPrint;
	myPrint("hello world");
	myPrint("hello world");
	myPrint("hello world");
	myPrint("hello world");

	cout << "myPrint()调用的次数：" << myPrint.count << endl;
}

//3.函数对象可以作为参数传递
void doPrint(MyPrint& mp, string str)
{
	mp(str);
}
void test3()
{
	MyPrint myPrint;
	doPrint(myPrint, "hello c++");
}
int main()
{
	//test1();
	//test2();
	test3();
}