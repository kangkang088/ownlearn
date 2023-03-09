#include <iostream>
using namespace std;
class CGirl
{
    //friend ostream& operator << (ostream& cout, const CGirl& g);
    string m_name;
    int m_xw;
    int m_score;
public:
    CGirl() { m_name = "西施"; m_xw = 87; m_score = 30; }
    void show() { cout << "姓名:" << m_name << "，胸围：" << m_xw << ",分数：" << m_score << endl; }
    ostream& operator << (ostream& cout)
    {
        cout << "姓名:" << this->m_name << "，胸围：" << this->m_xw << ",分数：" << this->m_score << endl;
        return cout;
    }
};
//ostream& operator << (ostream& cout, const CGirl& g)
//{
//    cout << "姓名:" << g.m_name << "，胸围：" << g.m_xw << ",分数：" << g.m_score << endl;
//    return cout;
//}
int main()
{
    CGirl g;
    g << cout << endl;//重载用成员函数的方式时，不建议用成员函数重载左移运算符
}
