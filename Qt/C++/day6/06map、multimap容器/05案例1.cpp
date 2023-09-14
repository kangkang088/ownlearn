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
		worker.m_name = "Ա��";
		worker.m_name += nameSeed[i];

		worker.m_salary = rand() % 10000 + 10000;

		v.push_back(worker);
	}
}

void setGroup(vector<Worker>& v, multimap<int, Worker>& m)
{
	for (vector<Worker>::iterator it = v.begin(); it != v.end(); it++)
	{
		//�漴���ű��
		int deptId = rand() % 3;

		//��Ա���������������
		//keyΪ���ű�ţ�valueΪԱ��
		m.insert(make_pair(deptId, (*it)));
	}
}

void showWorkerByGroup(multimap<int, Worker>& m)
{
	cout << "�߻����ţ�" << endl;
	multimap<int, Worker>::iterator pos = m.find(CEHUA);
	//ͳ�Ʋ߻����ž�������
	int count = m.count(CEHUA);
	int index = 0;
	for (; pos != m.end() && index < count; pos++, index++)
	{
		cout << "������" << pos->second.m_name << "�����ʣ�" << pos->second.m_salary << endl;
	}

	cout << "----------------------" << endl;
	cout << "�������ţ�" << endl;
	pos = m.find(MEISHU);
	count = m.count(MEISHU);
	index = 0;
	for (; pos != m.end() && index < count; pos++, index++)
	{
		cout << "������" << pos->second.m_name << "�����ʣ�" << pos->second.m_salary << endl;
	}

	cout << "----------------------" << endl;
	cout << "�з����ţ�" << endl;
	pos = m.find(YANFA);
	count = m.count(YANFA);
	index = 0;
	for (; pos != m.end() && index < count; pos++, index++)
	{
		cout << "������" << pos->second.m_name << "�����ʣ�" << pos->second.m_salary << endl;
	}
}
int main()
{
	srand((unsigned int)time(NULL));
	//1.����Ա��
	vector<Worker> vWorker;
	creatWorker(vWorker);
	////���ԷŽ�ȥ��û��
	//for (vector<Worker>::iterator it = vWorker.begin(); it != vWorker.end(); it++)
	//{
	//	cout << "������" << (*it).m_name << "�����ʣ�" << (*it).m_salary << endl;
	//}

	//2.Ա������
	multimap<int, Worker> mWorker;
	setGroup(vWorker, mWorker);

	//3.������ʾԱ��
	showWorkerByGroup(mWorker);
}