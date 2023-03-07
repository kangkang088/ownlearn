
#include <iostream>
using namespace std;
//深拷贝
//第一个指针指向一块内存，编辑器创建一个大小相同的内存给第二个指针指向
//然后把第一个指针指向的内存的内容拷贝到第二个指针指向的内存
//两个指针各自操作自己的内存，互不影响
//编辑器默认是浅拷贝
class CGirl
{
public:
	string m_name;
	int m_age;
	int* m_ptr;
	CGirl()
	{
		m_name.clear(); m_age = 0; m_ptr = nullptr; cout << "调用了CGirl()\n";
	}
	~CGirl()
	{
		if (m_ptr == nullptr)
		{
			delete m_ptr;
			m_ptr = nullptr;
		}
		cout << "调用了~CGirl()\n";
	}
	CGirl(const CGirl& g)
	{
		m_name = g.m_name; m_age = g.m_age; //m_ptr = g.m_ptr;
		//深拷贝
		m_ptr = new int;
		//简单数据拷贝  *m_ptr = *g.m_ptr;
		memcpy(m_ptr, g.m_ptr, sizeof(int)); //复杂数据拷贝
		cout << "调用了默认拷贝构造函数\n";
	}
	CGirl(const CGirl& g, int i)
	{
		m_name = g.m_name; m_age = g.m_age - i; //m_ptr = g.m_ptr;
		//深拷贝
		m_ptr = new int;
		//简单数据拷贝  *m_ptr = *g.m_ptr;
		memcpy(m_ptr, g.m_ptr, sizeof(int)); //复杂数据拷贝
		cout << "调用了重载拷贝构造函数\n";
	}
	void show() { cout << "姓名：" << m_name << "，年龄：" << m_age << "m_ptr的地址是：" << m_ptr << "值是：" << *m_ptr << endl; }
};
int main()
{
	CGirl g1;
	g1.m_name = "西施"; g1.m_age = 23; g1.m_ptr = new int(3);
	g1.show();
	CGirl g2(g1); *g2.m_ptr = 8;
	g1.show();
	g2.show();
}


