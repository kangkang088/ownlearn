#include <iostream>
using namespace std;
class CBoy
{
public:
	string m_xm;
	CBoy()
	{ m_xm.clear(); cout << "调用了CBoy\n"; }
	CBoy(string xm)
	{ m_xm = xm; cout << "调用了有参数CBoy\n"; }
	CBoy(const CBoy& b)
	{ m_xm = b.m_xm; cout << "调用了拷贝构造函数\n"; }
	/*~CBoy()
	{
		cout << "调用了CB析构函数\n";
	}*/
};
class CGirl
{
public:
	string m_name;
	int m_age;
	int* m_ptr;
	CBoy m_boy;
	CGirl() //:m_name("西施"), m_age(23)
	{
		//m_name.clear(); m_age = 0; m_ptr = nullptr; 
		cout << "调用了CGirl()\n";
	}
	//CGirl(string name, int age,int* p,CBoy boy):m_name("漂亮的" + name), m_age(age), m_ptr(p)
	//{
	//	m_boy.m_xm = boy.m_xm;
	//	//m_name.clear(); m_age = 0; m_ptr = nullptr;
	//	//m_name = name; m_age = age; m_ptr = p;
	//	cout << "调用了有参数的CGirl()\n";

	//}
	CGirl(string name, int age, int* p, CBoy& boy) :m_name("漂亮的" + name), m_age(age), m_ptr(p),m_boy(boy)
	{
		//m_boy.m_xm = boy.m_xm;
		//m_name.clear(); m_age = 0; m_ptr = nullptr;
		//m_name = name; m_age = age; m_ptr = p;
		cout << "调用了有参数的CGirl()\n";

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
	void show() { cout << "姓名：" << m_name << "，年龄：" << m_age << "m_ptr的地址是：" << m_ptr << "值是：" << *m_ptr << "，男朋友：" << m_boy.m_xm <<  endl; }
};
int main()
{
	int* p = new int(5);
	CBoy boy("子都");
	CGirl g1("曹芬", 25, p, boy);
	g1.show();
}