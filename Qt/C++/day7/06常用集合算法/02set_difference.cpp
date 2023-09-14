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
//set_difference �������ϵĲ
//��������������


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

	cout << "v1��v2�Ĳ��" << endl;

	//v1��v2�Ĳ����v1
	vector<int>::iterator itEnd = set_difference(v1.begin(), v1.end(), v2.begin(), v2.end(), vTarget.begin());
	
	for_each(vTarget.begin(), itEnd, myPrint);
	cout << endl;
	
	cout << "v2��v1�Ĳ��" << endl;
	
	//v2��v1�Ĳ����v2
	itEnd = set_difference(v2.begin(), v2.end(), v1.begin(), v1.end(), vTarget.begin());
	
	for_each(vTarget.begin(), itEnd, myPrint);
	cout << endl;
}
int main()
{
	test1();
}