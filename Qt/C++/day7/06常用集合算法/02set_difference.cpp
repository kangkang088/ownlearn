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
//set_difference 两个集合的差集
//必须是有序序列


void myPrint(int val)
{
	cout << val << " ";
}
void test1()
{
	vector<int> v1;
	vector<int> v2;

	for (int i = 0; i < 10; i++)
	{
		v1.push_back(i);
		v2.push_back(i + 5);
	}
	vector<int> vTarget;
	vTarget.resize(max(v1.size(),v2.size()));

	cout << "v1和v2的差集：" << endl;

	//v1和v2的差集，看v1
	vector<int>::iterator itEnd = set_difference(v1.begin(), v1.end(), v2.begin(), v2.end(), vTarget.begin());
	
	for_each(vTarget.begin(), itEnd, myPrint);
	cout << endl;
	
	cout << "v2和v1的差集：" << endl;
	
	//v2和v1的差集，看v2
	itEnd = set_difference(v2.begin(), v2.end(), v1.begin(), v1.end(), vTarget.begin());
	
	for_each(vTarget.begin(), itEnd, myPrint);
	cout << endl;
}
int main()
{
	test1();
}