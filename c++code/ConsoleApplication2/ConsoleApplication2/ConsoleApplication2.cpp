#include <iostream>
using namespace std;
int main()
{
	int a = 5;
	int b = 4;
	cout << (double)a / b << endl;
	cout << a + b << endl;

	//c++规定只有整数才可以进行取模运算(分母不能为零)
	cout << a % b << endl;

	int c = a + b;
	cout << c << endl;

	c = (double)a / b;
	cout << c << endl;//输出1

	double d = (double)a / b;
	cout << d << endl;//输出1.25

	int i = 10;

	i = i + 1;
	cout << "i的值为" << i << endl;//11

	int m = 10;
	int s;
	s = m++;//先使用表达式，再把变量的值加一
	cout << "s的值为" << s << endl;//10
	cout << "m的值为" << m << endl;

	int n = 10;
	int o;
	o = ++n;//先把变量的值加一，再使用表达式
	cout << "o的值为" << o << endl;//11
	cout << "n的值为" << n << endl;

}

