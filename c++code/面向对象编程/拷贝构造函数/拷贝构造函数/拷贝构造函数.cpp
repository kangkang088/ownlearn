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
    void setvalue(string name, int age);
    void show() { cout << "姓名：" << m_name << "，年龄：" << m_age << endl; }
};
void CGirl::setvalue(string name, int age)
{
    m_name = name;
    m_age = age;
}
int main()
{
    //四种常用的创建对象的方法
    CGirl girl;
    /*CGirl girl1 = CGirl();
    CGirl* girl2 = new CGirl;
    CGirl* girl3 = new CGirl();*/

    girl.setvalue("曹芬", 25);
    girl.show();
    //用已存在的对象创建新的对象
    //类中有自己定义的拷贝构造函数，按自己的要求拷贝
    //没有就按编辑器自己提供的默认拷贝构造函数拷贝
    CGirl girl1(girl); //或者 CGirl girl1 = girl;
    girl1.show();
    /*delete girl2;
    delete girl3;*/

}
