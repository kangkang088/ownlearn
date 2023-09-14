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
class Transform
{
public:
	int operator() (int val)
	{
		return val + 100;
	}
};
class MyPrint
{
public:
	void operator() (int val)
	{
		cout << val << " ";
	}
};
void test1()
{
	vector<int> v;
	for (int i = 0; i < 10; i++)
	{
		v.push_back(i);
	}

	vector<int> vTarget;
	vTarget.resize(v.size());//必须要先开辟空间
	transform(v.begin(), v.end(), vTarget.begin(), Transform());

	for_each(vTarget.begin(), vTarget.end(), MyPrint());
	cout << endl;
}
int main()
{
	test1();
}