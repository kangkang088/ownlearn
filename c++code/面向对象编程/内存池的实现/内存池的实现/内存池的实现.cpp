#include <iostream>
using namespace std;
class CGirl
{
public:
	int m_bh;
	int m_age;
	static char* m_pool;//内存池的起始地址
	static bool initpool()//初始化内存池的函数
	{
		m_pool = (char*)malloc(18);//申请内存
		if (m_pool == 0)
		{
			return false;//如果申请失败，返回false
		}
		memset(m_pool, 0, 18);//把内存中的内容初始化为0
		cout << "内存池的起始地址是" << (void*)m_pool << endl;
		return true;
	}
	static void freepool()//释放内存池的函数
	{
		if (m_pool == 0)
		{
			return;
		}
		free(m_pool);
		cout << "内存池已释放。\n";
	}
	CGirl(int bh, int age) { m_bh = bh; m_age = age; cout << "调用了构造函数。\n"; }
	~CGirl() { cout << "调用了析构函数\n"; }
	void* operator new(size_t size)
	{
		if (m_pool[0] == 0)
		{
			cout << "分配了第一块内存：" << (void*)(m_pool + 1) << endl;
			m_pool[0] = 1;
			return m_pool + 1;
		}
		if (m_pool[9] == 0)
		{
			cout << "分配了第二块内存：" << (void*)(m_pool + 10) << endl;
			m_pool[9] = 1;
			return (m_pool + 10);
		}
		//如果以上两个位置都不可用,直接向系统申请内存
		void* ptr = malloc(size);
		cout << "申请到的内存的地址是：" << ptr << endl;
		return ptr;
	}
	void operator delete(void* ptr)
	{
		if (ptr == 0)                return;
		if (ptr == m_pool + 1)
		{
			cout << "释放了第一块内存" << endl;
			m_pool[0] = 0;
			return;
		}
		if (ptr == m_pool + 10)
		{
			cout << "释放了第二块内存。" << endl;
			m_pool[9] = 0;
			return;
		}
		free(ptr);
	}
};
char* CGirl::m_pool = 0;
int main()
{
	if (CGirl::initpool() == false)
	{
		cout << "初始化内存失败。\n" << endl;
		return -1;
	}
	CGirl* p1 = new CGirl(3, 25);//将使用内存池的第一个位置
	cout << "地址：p1=" << p1 << "，编号：" << p1->m_bh << "，年龄：" << p1->m_age << endl;

	CGirl* p2 = new CGirl(4, 24);//将使用内存池的第二个位置
	cout << "地址：p2=" << p2 << "，编号：" << p2->m_bh << "，年龄：" << p2->m_age << endl;

	CGirl* p3 = new CGirl(5, 26);//将使用系统的内存
	cout << "地址：p3=" << p3 << "，编号：" << p3->m_bh << "，年龄：" << p3->m_age << endl;
	delete p1;//释放内存池的第一个位置

	CGirl* p4 = new CGirl(6, 27);//将使用内存池的第一个位置
	cout << "地址：p4=" << p4 << "，编号：" << p4->m_bh << "，年龄：" << p4->m_age << endl;

	delete p2;//释放内存池的第二个位置
	delete p3;//释放系统的内存
	delete p4;//释放内存池的第一个位置
	CGirl::freepool();//释放内存池
}
