#include <iostream>
using namespace std;
class CGirl
{
private:
	string m_boys[3];
public:
	string m_name;
	CGirl() { m_boys[0] = "子都"; m_boys[1] = "潘安"; m_boys[2] = "宋玉"; }
	void show() { cout << m_boys[0] << "," << m_boys[1] << "," << m_boys[2] << endl; }
	string& operator [](int i)
	{
		return m_boys[i];
	}
	const string& operator [](int i) const
	{
		return m_boys[i];
	}
};
int main()
{
	CGirl g;
	g[1] = "王麻子";
	cout << "第一任男朋友：" << g[1]<< endl;
	g.show();

	const CGirl g1 = g;
	cout << "第一任男朋友：" << g1[1] << endl;
}

