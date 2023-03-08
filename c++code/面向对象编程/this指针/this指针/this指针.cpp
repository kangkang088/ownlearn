#include <iostream>
using namespace std;
class CGirl
{
public:
    string m_name;
    int m_yz;
    CGirl(const string& name, int yz)
    {
        m_name = name;
        m_yz = yz;
    }
    void show() const
    {
        cout << "我是：" << m_name << ",最好看的。" << endl;
    }
    const CGirl& pk(const CGirl& g) const
    {
        if (g.m_yz < m_yz)
        {
            return *this;
        }
        return g;
    }
};
//const CGirl& pk(const CGirl& g1, const CGirl& g2)
//{
//    if (g1.m_yz < g2.m_yz)
//    {
//        return g2;
//    }
//    return g1;
//}
int main()
{
    CGirl girl1("西施",1);
    CGirl girl2("貂蝉",3);
    CGirl girl3("冰冰",5);
    CGirl girl4("暖暖",6);
    CGirl girl5("美美",9);
    const CGirl& girl = girl1.pk(girl2).pk(girl3).pk(girl4).pk(girl5);//谁调用了pk函数，this指针就指向谁
    girl.show();

}
