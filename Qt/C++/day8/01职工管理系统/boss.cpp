#include "boss.h"

using namespace std;

Boss::Boss(int id, string name, int deptId)
{
	this->m_id = id;
	this->m_name = name;
	this->m_deptId = deptId;
}

void Boss::showInfo()
{
	cout << "ְ����ţ�" << this->m_id
		<< "\tְ��������" << this->m_name
		<< "\t��λ��" << this->getDeptName()
		<< "\t��λְ�𣺹���˾" << endl;
}

string Boss::getDeptName()
{
	return string("�ϰ�");
}
