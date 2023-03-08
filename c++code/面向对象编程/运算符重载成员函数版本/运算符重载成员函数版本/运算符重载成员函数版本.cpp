#include <iostream>
using namespace std;
class CGirl
{
	friend CGirl& operator + (CGirl& g, int score);
	friend CGirl& operator + (int score, CGirl& g);
	friend CGirl& operator + (CGirl& g1, CGirl& g2);
private:
	int m_xw;
	int m_score;
public:
	string m_name;
	CGirl() { m_name = "西施"; m_xw = 87; m_score = 30; }
	~CGirl() { cout << "调用了析构函数"; }
	void show() { cout << "姓名：" << m_name << "，胸围：" << m_xw << "，分数：" << m_score << endl; }
	/*CGirl& operator - (int score)
	{
		m_score = m_score - score;
		return *this;
	}*/
};
CGirl& operator + (CGirl& g, int score)
{
	g.m_score = g.m_score + score;
	return g;
}
CGirl& operator + (int score,CGirl& g)
{
	g.m_score = g.m_score + score;
	return g;
}
CGirl& operator + (CGirl& g1, CGirl& g2)
{
	g1.m_score = g1.m_score + g2.m_score;
	return g1;
}
int main()
{
	CGirl g;
	//g = g - 20 - 5;
	g = g + 20;
	g = 20 + g;
	g.show();
	g = g + 20 + g;//180
	g.show();
}
