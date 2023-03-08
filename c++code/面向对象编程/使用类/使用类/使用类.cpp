#include <iostream>
using namespace std;
class CGirl
{
	//friend int main();//声明友元全局函数
	//friend void func();
	friend class CBoy;//友元类
public:
	string m_name;
	CGirl() { m_name = "西施"; m_xw = 87; }
	~CGirl() { cout << "调用了析构函数\n"; }
	void showname() { cout << "姓名：" << m_name << endl; }
private:
	int m_xw;
	void showxw() const { cout << "胸围：" << m_xw << endl; }
};
//友元全局函数，在类中声明
//void func()
//{
//	CGirl g;
//	g.showname();
//	g.showxw();
//}
//友元类
class CBoy
{
public:
	void func(const CGirl& g)
	{
		cout << "我女朋友的姓名是：" << g.m_name << endl;
		cout << "我女朋友的胸围是：" << g.m_xw << endl;
		g.showxw();
	}
};
int main()
{
	//func();
	CGirl g;
	CBoy b;
	b.func(g);
}