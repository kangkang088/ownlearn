#include <iostream>
using namespace std;
class CGirl
{
public:
    string m_name;
    int m_age;
    //构造函数
    CGirl()
    {
        m_name.clear(); m_age = 0;
        cout << "运行了CGirl()\n" << endl;
    }
    //析构函数
    ~CGirl()
    {
        cout << "运行了~CGirl()\n" << endl;;
    }
    //拷贝构造函数
    CGirl(const CGirl& g)
    {
        m_name = "漂亮的" + g.m_name; m_age = g.m_age - 1;
        cout << "调用了拷贝构造函数\n" << endl;
    }
    //拷贝构造函数的重载
    //参数可以有默认值，但一定要有原来类的常引用，否则就变成了构造函数
    CGirl(const CGirl& g,int i)
    {
        m_name = "漂亮的" + g.m_name; m_age = g.m_age - i;
        cout << "调用了重载的拷贝构造函数\n" << endl;
    }
    void setvalue(string name, int age);
    void show() { cout << "姓名：" << m_name << "，年龄：" << m_age << endl; }
};
void CGirl::setvalue(string name, int age)
{
    m_name = name;
    m_age = age;
}
CGirl func()
{
    CGirl g;
    g.setvalue("西瓜", 13);
    cout << &g << endl;
    return g;
}
int main()
{
    CGirl gg = func();
    gg.show();
    cout << &gg << endl;

    CGirl g1;
    g1.setvalue("曹芬", 23);
    //CGirl g2(g1);//调用了拷贝构造函数
    CGirl g2(g1,3);//调用了重载的拷贝构造函数
    g2.show();
    //定义了重载拷贝构造函数却没有定义默认拷贝构造函数，调用CGirlg2(g1)时，编辑器会提供一个默认的拷贝构造函数
}

