
#include <iostream>
using namespace std;
class CGirl
{
public:
	int m_bh;
	string m_name;
	int* p;
	void show() { cout << "编号：" << m_bh << "，姓名：" << m_name << "p的地址是：" << p << endl; }
	CGirl() { p = nullptr; }
	~CGirl() { if (p) delete p; p = nullptr; }
	CGirl& operator = (const CGirl& g)
	{
		if (&g == this) return *this;
		if (g.p == nullptr)//如果源对象指针为空，则清空目标对象指针
		{
			if (p != nullptr) { delete p; p = nullptr; }
		}
		else//如果源对象指针不为空，则为目标对象指针分配空间并赋值
		{
			if (p == nullptr)
			{
				p = new int;
			}
			memcpy(p, g.p, sizeof(int));
		}
		this->m_bh = g.m_bh; this->m_name = g.m_name;
		cout << "调用了重载赋值函数\n";
		return *this;
	}
};
int main()
{
	CGirl g1, g2;
	g1.m_bh = 8; g1.m_name = "西施"; g1.p = new int(3);
	g1.show();
	g2.show();
	g2 = g1;
	g2.show();
	cout << *g1.p << " " << *g2.p << endl;
}
