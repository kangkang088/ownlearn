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
	//��һ�ַ�ʽ
	pair<string, int> p1("Tom", 20);
	cout << "������" << p1.first << "�����䣺" << p1.second << endl;

	//�ڶ��ַ�ʽ
	pair<string, int> p2 = make_pair("Jerry", 30);
	cout << "������" << p2.first << "�����䣺" << p2.second << endl;
}
int main()
{
	test1();
}