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
#include <numeric>

using namespace std;
//fill  野割
void myPrint(int val)
{
	cout << val << " ";
}
void test1()
{
	vector<int> v;
	v.resize(10);

	cout << "野割念��" << endl;
	for_each(v.begin(), v.end(), myPrint);
	cout << endl;
	cout << "野割朔:" << endl;
	fill(v.begin(), v.end(),100);
	for_each(v.begin(), v.end(), myPrint);
	cout << endl;

}
int main()
{
	test1();
}