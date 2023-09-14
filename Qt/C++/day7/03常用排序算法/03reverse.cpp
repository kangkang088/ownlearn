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
void myPrint(int val)
{
	cout << val << " ";
}
void test1()
{
	vector<int> v;
	for (int i = 0; i < 10; i++)
	{
		v.push_back(i);
	}
	cout << "反转前：" << endl;
	for_each(v.begin(), v.end(), myPrint);
	cout << endl;
	cout << "反转后：" << endl;
	reverse(v.begin(), v.end());
	for_each(v.begin(), v.end(), myPrint);
}
int main()
{
	test1();
}