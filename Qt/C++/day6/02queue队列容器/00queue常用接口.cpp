#include <iostream>
#include <fstream>
#include <vector>
#include <algorithm>
#include <string>
#include <deque>
#include <stack>
#include <queue>
using namespace std;

class Person
{
public:
	Person(string name, int age)
	{
		this->m_name = name;
		this->m_age = age;
	}
	string m_name;
	int m_age;
};
void test1()
{
	queue<Person> q;

	Person p1("唐僧", 30);
	Person p2("孙悟空", 1000);
	Person p3("猪八戒", 900);
	Person p4("沙僧", 800);

	//入队 先进先出
	q.push(p1);
	q.push(p2);
	q.push(p3);
	q.push(p4);

	cout << "队列大小：" << q.size() << endl;

	//只要队列不为空，查看队头和队尾
	while (!q.empty())
	{
		cout << "队头：" << "姓名：" << q.front().m_name << "年龄：" << q.front().m_age << endl;
		cout << "队尾：" << "姓名：" << q.back().m_name << "年龄：" << q.back().m_age << endl;
		

		//出队
		q.pop();
	}

	cout << "队列大小：" << q.size() << endl;
}
int main()
{
	test1();
}