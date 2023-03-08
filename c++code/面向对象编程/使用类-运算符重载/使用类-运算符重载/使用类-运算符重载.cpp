#include <iostream>
using namespace std;
class CGirl
{
	//friend void add(CGirl& g, int score);//C语言
	friend void operator + (CGirl& g, int score);//C++
	friend CGirl& operator - (CGirl& g, int score);//C++
private:
	int m_xw;
	int m_score ;
public:
	string m_name;
	CGirl() { m_name = "西施"; m_xw = 87; m_score = 30; }
	~CGirl() { cout << "调用了析构函数"; }
	void show() { cout << "姓名：" << m_name << "，胸围：" << m_xw << "，分数：" << m_score << endl; }
};
//利用友元全局函数的方法给超女加分（C语言）
//void add(CGirl& g,int score)
//{
//	g.m_score = g.m_score + 30;
//}

//（C++）
void operator + (CGirl& g, int score)
{
	g.m_score = g.m_score + score;
}
CGirl& operator - (CGirl& g, int score)
{
	g.m_score = g.m_score - score;
	return g;
}
int main()
{
	CGirl g;
	//operator + (g, 30);
	g + 30;//函数的实参在运算符的两边，代替了传统的函数书写方式
	g.show();
	g = g - 20 - 5;
	g.show();
}
