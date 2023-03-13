#include <iostream>
using namespace std;
class CGirl
{
public:
    string m_name;
    int m_ranking;
    CGirl() { m_name = "西施"; m_ranking = 5; }
    ~CGirl() { cout << "调用了析构函数\n"; }
    void show() const { cout << "姓名：" << m_name << "，排名：" << m_ranking << endl; }
    CGirl& operator++()
    {
        m_ranking++;//没有形参，是前置++
        return *this;
    }
    CGirl operator++(int)
    {
        CGirl tmp = *this;
        m_ranking++;//有一个int形参，是后置++
        return tmp;//临时对象，返回值不能是引用，可能造成野指针
    }
};
int main()
{
    CGirl g1,g2;
    ++(++g1);
    //g2++;
    g1.show();
    CGirl g3 = g2++;//后置是先使用，后++，需要在重载函数中创建一个临时对象保存原来的对象，再后置++
    g3.show();
    g2.show();
}
