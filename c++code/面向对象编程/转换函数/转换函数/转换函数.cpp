#include <iostream>
#include <cstdlib>
using namespace std;
class CGirl
{
public:
	int m_bh;
	string m_name;
	double m_weight;
	CGirl() { m_bh = 8; m_name = "西施"; m_weight = 50.7; }
	//默认隐式转换
	//explicit会关闭隐式转换特性，变成显示转换，表达式必须强制类型转换
	explicit operator int() { return m_bh; }
	explicit operator string() { return m_name; }
	explicit operator double() { return m_weight; }
	int to_int() { return m_bh; }
};
int main()
{
	CGirl g;
	int a = g.to_int(); cout << a << endl;
	string b = (string)g; cout << b << endl;
	double c = (double)g; cout << c << endl;
	short d = (int)g;//如果没有explicit，short d = g存在二义性，d没有自身的short转化函数，既可以找int，也可以找double

}