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
//1.���������ڵ���ʱ����������ͨ�����������ã������в����������з���ֵ
void test1()
{
	MyAdd myAdd;
	cout << myAdd(10, 10) << endl;
}
//2.�������󳬳���ͨ�����ĸ����������������Լ���״̬
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
	//Ҫ����ͨ��������¼�Լ������ö��ٴΣ�����Ҫһ��ȫ�ֱ�����ͳ�Ƶ��ô���
	//�����������ͨ���ڲ�����¼
	int count; //�ڲ��Լ���״̬
};
void test2()
{
	MyPrint myPrint;
	myPrint("hello world");
	myPrint("hello world");
	myPrint("hello world");
	myPrint("hello world");

	cout << "myPrint()���õĴ�����" << myPrint.count << endl;
}

//3.�������������Ϊ��������
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