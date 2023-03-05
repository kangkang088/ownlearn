#include <iostream>
using namespace std;
//函数重载
void myswap(int& a, int& b)//交换两个整型变量的值
{
	int tmp = a; a = b; b = tmp;
}
void myswap(string& a, string& b)//交换两个字符串变量的值
{
	string tmp = a; a = b; b = tmp;
}
int main()
{
	short a = 3, b = 5;
	myswap((int&)a,(int&)b);
	cout << a << " " << b << endl;
	string c = "西施", d = "貂蝉";
	myswap(c, d);
	cout << c << " " << d << endl;
}
