#include <iostream>
#include <fstream>
#include <vector>
#include <algorithm>
#include <string>
#include <deque>
#include <stack>
#include <queue>
#include <list>
#include <set>
#include <map>

using namespace std;

//��Ԫν��

class MyCompare
{
public:
	bool operator() (int val1, int val2)
	{
		return val1 > val2;
	}
};

void test1()
{
	vector<int> v;
	v.push_back(10);
	v.push_back(40);
	v.push_back(20);
	v.push_back(30);
	v.push_back(50);

	sort(v.begin(),v.end());
	for (vector<int>::iterator it = v.begin(); it != v.end(); it++)
	{
		cout << *it << " ";
	}
	cout << endl;

	//ʹ�ú������󣬸ı��㷨������򣬱�Ϊ����
	sort(v.begin(), v.end(), MyCompare());
	cout << "-------------------" << endl;
	cout << "�����" << endl;
	for (vector<int>::iterator it = v.begin(); it != v.end(); it++)
	{
		cout << *it << " ";
	}
	cout << endl;

}
int main()
{
	test1();
}