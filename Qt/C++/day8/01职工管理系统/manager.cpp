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
	cout << "职工编号：" << this->m_id
		<< "\t职工姓名：" << this->m_name
		<< "\t岗位：" << this->getDeptName()
		<< "\t岗位职责：发布任务" << endl;
}

string Manager::getDeptName()
{
	return string("经理");
}
