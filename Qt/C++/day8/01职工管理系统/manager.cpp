#include "manager.h"

using namespace std;


Manager::Manager(int id, string name, int deptId)
{
	this->m_id = id;
	this->m_name = name;
	this->m_deptId = deptId;
}

void Manager::showInfo()
{
	cout << "ְ����ţ�" << this->m_id
		<< "\tְ��������" << this->m_name
		<< "\t��λ��" << this->getDeptName()
		<< "\t��λְ�𣺷�������" << endl;
}

string Manager::getDeptName()
{
	return string("����");
}
