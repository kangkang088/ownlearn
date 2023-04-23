#include <iostream>
using namespace std;
//基类或父类
class CALLComers
{
public:
    string m_name;
    string m_tel;
    CALLComers() { m_name = "某女"; m_tel = "不详"; }
    void sing() { cout << "我是一只小小鸟" << endl; }
    void setname(const string& name) { m_name = name; }
    void settel(const string& tel) { m_tel = tel; }
};
//派生类或子类
class CGirl :public CALLComers
{
public:
    int m_bh;
    CGirl() { m_bh = 8; }
    void show() { cout << "编号：" << m_bh << "," << "姓名：" << m_name << "," << "联系方式：" << m_tel << endl; }
};
int main()
{
    CGirl g;
    g.setname("西施");
    g.settel("180813");
    g.show();
}
