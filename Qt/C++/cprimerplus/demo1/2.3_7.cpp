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
#include <numeric>

using namespace std;

void show1()
{
	cout << "Three blind mice" << endl;
}
void show2()
{
	cout << "See how they run" << endl;
}

double tep(double a)
{
	return a * 1.8 + 32;
}

double guangNian(double a)
{
	return a * 63240;
}
void showTime(int a,int b)
{
	cout << "Time:  " << a << ":" << b << endl;
}
int main()
{
	show1();
	show1();
	show2();
	show2();

	cout << endl;
	int age;
	cout << "请输入您的年龄：" << endl;
	cin >> age;
	cout << "该年龄包含" << age * 12 << "个月" << endl;

	cout << endl;

	double a = 0;
	cout << "请输入一个摄氏温度" << endl;
	cin >> a;
	double b = tep(a);
	cout << a << " degree Celsius is " << b << " degree Fahrenheit" << endl;


	cout << endl;

	double aa = 0;
	cout << "Enter the number of light years: ";
	cin >> aa;
	int bb = guangNian(aa);
	cout << aa << " light years = " << bb << " astronomical units" << endl;


	int m = 0;
	int n = 0;
	cout << "Enter the number of hours: ";
	cin >> m;
	cout << "Enter the number of minutes: ";
	cin >> n;
	showTime(m,n);
}