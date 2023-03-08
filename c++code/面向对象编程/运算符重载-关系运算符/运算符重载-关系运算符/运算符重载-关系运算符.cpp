#include <iostream>
using namespace std;
class CGirl
{
    string m_name;
    int m_yz;
    int m_sc;
    int m_acting;
public:
    CGirl(string name, int yz, int sc, int acting) { m_name = name; m_yz = yz; m_sc = sc; m_acting = acting; }
    bool operator ==(const CGirl& g)
    {
        if ((m_yz + m_sc + m_acting) == (g.m_yz + g.m_sc + g.m_acting)) return true;
        return false;
    }
    bool operator <(const CGirl& g)//小于
    {
        //因为三项和越小，商业价值越大，所以这里用>表示true
        if ((m_yz + m_sc + m_acting) > (g.m_yz + g.m_sc + g.m_acting)) return true;
        return false;
    }
    bool operator >(const CGirl& g)//大于
    {
        if ((m_yz + m_sc + m_acting) < (g.m_yz + g.m_sc + g.m_acting)) return true;
        return false;
    }
        
    
};
int main()
{
    CGirl g1("西施",1,2,1), g2("貂蝉",1,1,1);
    if (g1 == g2)           cout << "商业价值一样的" << endl;
    else if (g1 > g2)       cout << "西施的商业价值大" << endl; //西施的要是大于貂蝉，打印，且西施的要小于貂蝉，函数里面用小于号
           else                    cout << "貂蝉的商业价值大" << endl;
   
        
}
