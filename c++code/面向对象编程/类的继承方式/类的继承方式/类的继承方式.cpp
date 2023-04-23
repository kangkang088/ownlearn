#include <iostream>
using namespace std;
class CALLComers
{
protected:
	int m_a;
private:
	int m_b;
public:
	string m_name;
	string m_tel;
	CALLComers() { m_name = "未知"; m_tel = "不详"; }
	CALLComers(string name,string tel) :m_name(name),m_tel(tel) {}
	void sing() { cout << "我是一只小小鸟" << endl; }
	void setname(const string& name) { m_name = name; }
	void settel(const string& tel) { m_tel = tel; }
	CALLComers& operator=(const CALLComers& cc)
	{
		m_name = cc.m_name;
		m_tel = cc.m_tel;
		return *this;
	}
};
class CGirl:private CALLComers
{
public:
	using CALLComers::m_a;
	int m_bh;
	CGirl() { m_bh = 8; }
	CGirl(int bh, const CALLComers& CC) :m_bh(bh) 
	{
		m_name = CC.m_name;
		m_tel = CC.m_tel;
	}
	/*{
		m_bh = bh;
		m_name = CC.m_name;
		m_tel = CC.m_tel;
	}*/
	CGirl(int bh, string& name, string &tel) :m_bh(bh),CALLComers(name,tel) {}
	void show() 
	{ 
		setname("西施");
		cout <<"编号：" << m_bh << "," << "姓名：" << m_name << "，" << "联系方式：" << m_tel << "。" << endl; 
	}

};
int main()
{
	CGirl g;
}