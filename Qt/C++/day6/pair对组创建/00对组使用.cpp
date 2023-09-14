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
void test1()
{
	//第一种方式
	pair<string, int> p1("Tom", 20);
	cout << "姓名：" << p1.first << "，年龄：" << p1.second << endl;

	//第二种方式
	pair<string, int> p2 = make_pair("Jerry", 30);
	cout << "姓名：" << p2.first << "，年龄：" << p2.second << endl;
}
int main()
{
	test1();
}