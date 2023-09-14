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
#include <ctime>
#define CEHUA 0
#define MEISHU 1
#define YANFA 2
using namespace std;
class Worker
{
public:

	string m_name;
	int m_salary;
};
void creatWorker(vector<Worker>& v)
{
	string nameSeed = "ABCDEFGHIJ";
	for (int i = 0; i < 10; i++)
	{
		Worker worker;
		worker.m_name = "员工";
		worker.m_name += nameSeed[i];

		worker.m_salary = rand() % 10000 + 10000;

		v.push_back(worker);
	}
}

void setGroup(vector<Worker>& v, multimap<int, Worker>& m)
{
	for (vector<Worker>::iterator it = v.begin(); it != v.end(); it++)
	{
		//随即部门编号
		int deptId = rand() % 3;

		//将员工插入随机分组中
		//key为部门编号，value为员工
		m.insert(make_pair(deptId, (*it)));
	}
}

void showWorkerByGroup(multimap<int, Worker>& m)
{
	cout << "策划部门：" << endl;
	multimap<int, Worker>::iterator pos = m.find(CEHUA);
	//统计策划部门具体人数
	int count = m.count(CEHUA);
	int index = 0;
	for (; pos != m.end() && index < count; pos++, index++)
	{
		cout << "姓名：" << pos->second.m_name << "，工资：" << pos->second.m_salary << endl;
	}

	cout << "----------------------" << endl;
	cout << "美术部门：" << endl;
	pos = m.find(MEISHU);
	count = m.count(MEISHU);
	index = 0;
	for (; pos != m.end() && index < count; pos++, index++)
	{
		cout << "姓名：" << pos->second.m_name << "，工资：" << pos->second.m_salary << endl;
	}

	cout << "----------------------" << endl;
	cout << "研发部门：" << endl;
	pos = m.find(YANFA);
	count = m.count(YANFA);
	index = 0;
	for (; pos != m.end() && index < count; pos++, index++)
	{
		cout << "姓名：" << pos->second.m_name << "，工资：" << pos->second.m_salary << endl;
	}
}
int main()
{
	srand((unsigned int)time(NULL));
	//1.创建员工
	vector<Worker> vWorker;
	creatWorker(vWorker);
	////测试放进去了没有
	//for (vector<Worker>::iterator it = vWorker.begin(); it != vWorker.end(); it++)
	//{
	//	cout << "姓名：" << (*it).m_name << "，工资：" << (*it).m_salary << endl;
	//}

	//2.员工分组
	multimap<int, Worker> mWorker;
	setGroup(vWorker, mWorker);

	//3.分组显示员工
	showWorkerByGroup(mWorker);
}