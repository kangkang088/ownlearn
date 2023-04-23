#include <iostream>
using namespace std;
class CGirl
{
public:
    int m_bh;
    string m_name;
    double m_weight;
    CGirl() { m_bh = 0; m_name.clear(); m_weight = 0; cout << "调用了默认构造函数\n"; }
    void show() { cout << "bh=" << m_bh << " ,name=" << m_name << ",weight=" << m_weight << endl; }
    explicit CGirl(int bh) { m_bh = bh; m_name.clear(); m_weight = 0; cout << "调用了bh参数的构造函数\n"; }
    //CGirl(double weight) { m_bh = 0; m_name.clear(); m_weight = weight; cout << "调用了weight参数的构造函数\n"; }

};
int main()
{
    //CGirl g1(8);//常规写法

    //CGirl g1 = CGirl(8);//显示转换

    CGirl g1 = (CGirl)8;//隐式转换
    //CGirl g1;//先创建对象g1
    //g1 = 8;//用CGirl(8)创建临时对象，再赋值给g1。

    //CGirl g1 = 8.7;
    g1.show();
}