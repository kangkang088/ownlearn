#include <iostream>
using namespace std;
//友元成员函数
//第一步，把超女类声明前置
class CGirl;
//第二步，把男朋友类的定义放在超女类之前
class CBoy
{
public:
	void func1(const CGirl& g);
	void func2(const CGirl& g);
};
class CGirl
{
	//第四步，把男朋友类的成员函数声明为超女类的友元函数	
	friend void CBoy::func1(const CGirl& g);
	friend void CBoy::func2(const CGirl& g);

public:
	string m_name;
	CGirl() { m_name = "西施"; m_xw = 87; }
	~CGirl() { cout << "调用了析构函数\n"; }
	void showname() { cout << "姓名：" << m_name << endl; }
private:
	int m_xw;
	void showxw() const { cout << "胸围：" << m_xw << endl; }
};
//第三步，把男朋友类的成员函数的函数体从类的定义中拿出来,放在超女类的定义的后面
void CBoy::func1(const CGirl& g) { cout << "我女朋友的胸围是：" << g.m_xw << endl; }
void CBoy::func2(const CGirl& g) { cout << "我女朋友的胸围是：" << g.m_xw << endl; }
int main()
{
	//func();
	CGirl g;
	CBoy b;
	b.func1(g);
	b.func2(g);
}