#include "workerManager.h"
WorkerManager::WorkerManager()
{
	//1.文件不存在
	ifstream ifs;
	ifs.open(FILENAME, ios::in);
	if (!ifs.is_open())
	{
		cout << "文件不存在" << endl;
		//初始化
		this->m_EmpNum = 0;
		this->m_EmpArray = NULL;
		this->m_fileIsEmpty = true;
		ifs.close();
		return;
	}
	//2.文件存在，但内容为空
	char ch;
	ifs >> ch;
	if (ifs.eof())
	{
		//文件为空
		cout << "文件为空" << endl;
		//初始化
		this->m_EmpNum = 0;
		this->m_EmpArray = NULL;
		this->m_fileIsEmpty = true;
		ifs.close();
		return;
	}
	//3.文件不为空
	int num = this->get_empNum();
	cout << "当前职工人数：" << num << endl;
	this->m_EmpNum = num;

	//开辟空间
	this->m_EmpArray = new Worker * [this->m_EmpNum];
	//将文件中的数据存到数组中
	this->init_emp();

	//测试
	/*for (int i = 0; i < this->m_EmpNum; i++)
	{
		cout << this->m_EmpArray[i]->m_id << " "
			<< this->m_EmpArray[i]->m_name << " "
			<< this->m_EmpArray[i]->m_deptId << endl;
	}*/

	this->m_fileIsEmpty = false;

}
void WorkerManager::show_Menu()
{
	cout << "********************************************" << endl;
	cout << "*********  欢迎使用职工管理系统！ **********" << endl;
	cout << "*************  0.退出管理程序  *************" << endl;
	cout << "*************  1.增加职工信息  *************" << endl;
	cout << "*************  2.显示职工信息  *************" << endl;
	cout << "*************  3.删除离职职工  *************" << endl;
	cout << "*************  4.修改职工信息  *************" << endl;
	cout << "*************  5.查找职工信息  *************" << endl;
	cout << "*************  6.按照编号排序  *************" << endl;
	cout << "*************  7.清空所有文档  *************" << endl;
	cout << "********************************************" << endl;
	cout << endl;
}
void WorkerManager::ExitSystem()
{
	cout << "欢迎下次使用！" << endl;
	system("pause");
	//system("cls");
	exit(0);
}
void WorkerManager::add_emp()
{
	cout << "请输入添加职工的数量" << endl;

	int addNum = 0;
	cin >> addNum;

	if (addNum > 0)
	{
		//添加
		//计算添加新空间的大小

		//新人数
		int newSize = this->m_EmpNum + addNum;

		//开辟新空间
		Worker** newSpace = new Worker * [newSize];

		//将原来的空间数据拷贝到新空间中
		if (this->m_EmpArray != NULL)
		{
			for (int i = 0; i < this->m_EmpNum; i++)
			{
				newSpace[i] = this->m_EmpArray[i];
			}
		}

		//添加新数据
		for (int i = 0; i < addNum; i++)
		{
			int id;
			string name;
			int dSelect;

			cout << "请输入第" << i + 1 << "个新职工的编号：" << endl;
			cin >> id;
			cout << "请输入第" << i + 1 << "个新职工的姓名：" << endl;
			cin >> name;
			cout << "请选择" << i + 1 << "个新职工的岗位：" << endl;
			cout << "1、普通员工" << endl;
			cout << "2、经理" << endl;
			cout << "3、老板" << endl;
			cin >> dSelect;

			Worker* worker = NULL;
			switch (dSelect)
			{
			case 1:
				worker = new Employee(id, name, dSelect);
				break;
			case 2:
				worker = new Employee(id, name, dSelect);
				break;
			case 3:
				worker = new Employee(id, name, dSelect);
				break;
			default:
				break;
			}
			//添加到新数组中
			newSpace[this->m_EmpNum + i] = worker;

		}

		//释放原有的空间
		delete[] this->m_EmpArray;

		//更改新空间的指向
		this->m_EmpArray = newSpace;

		//更新职工人数
		this->m_EmpNum = newSize;

		//成功添加后保存到文件中（而不只是该程序的内存中）
		this->save();

		//提示
		cout << "成功添加了" << addNum << "名职工" << endl;

	}
	else
	{
		cout << "输入数据有误" << endl;
	}

	system("pause");
	system("cls");
}
void WorkerManager::save()
{
	ofstream ofs;
	ofs.open(FILENAME, ios::out);//输出的方式打开文件 -写文件

	for (int i = 0; i < this->m_EmpNum; i++)
	{
		ofs << this->m_EmpArray[i]->m_id << " "
			<< this->m_EmpArray[i]->m_name << " "
			<< this->m_EmpArray[i]->m_deptId << " " << endl;
	}
	ofs.close();
}
int WorkerManager::get_empNum()
{
	ifstream ifs;
	ifs.open(FILENAME, ios::in);
	int id;
	string name;
	int deptId;
	int num = 0;
	while (ifs >> id && ifs >> name && ifs >> deptId)
	{
		//统计人数
		num++;
	}
	return num;
}
void WorkerManager::init_emp()
{
	ifstream ifs;
	ifs.open(FILENAME, ios::in);
	int id;
	string name;
	int deptId;
	int index = 0;
	while (ifs >> id && ifs >> name && ifs >> deptId)
	{
		Worker* worker = NULL;
		if (deptId == 1)
		{
			worker = new Employee(id, name, deptId);
		}
		else if (deptId == 2)
		{
			worker = new Manager(id, name, deptId);
		}
		else if (deptId == 3)
		{
			worker = new Boss(id, name, deptId);
		}

		this->m_EmpArray[index] = worker;
		index++;
	}
	ifs.close();
}
void WorkerManager::show_emp()
{
	//判断文件是否为空
	if (this->m_fileIsEmpty)
	{
		cout << "文件不存在或者文件为空" << endl;
	}
	else
	{
		for (int i = 0; i < this->m_EmpNum; i++)
		{
			//利用多态
			this->m_EmpArray[i]->showInfo();
		}
	}
	system("pause");
	system("cls");
}
void WorkerManager::del_emp()
{
	if (this->m_fileIsEmpty)
	{
		cout << "文件不存在或为空" << endl;
	}
	else
	{
		//按职工编号删除职工
		cout << "请输入想要删除的职工编号" << endl;
		int id = 0;
		cin >> id;

		int index = this->isExist(id);

		if (index != -1)//存在，进行删除
		{
			for (int i = index; i < this->m_EmpNum - 1; i++)
			{
				this->m_EmpArray[i] = this->m_EmpArray[i + 1];
			}
			//更新数组中的人员个数
			this->m_EmpNum--;
			//更新到文件中
			this->save();
			cout << "删除成功" << endl;
		}
		else
		{
			cout << "该员工不存在,删除失败" << endl;
		}
	}
	system("pause");
	system("cls");
}
int WorkerManager::isExist(int id)
{
	int index = -1;
	for (int i = 0; i < this->m_EmpNum; i++)
	{
		if (this->m_EmpArray[i]->m_id == id)
		{
			//找到职工
			index = i;
			break;
		}
	}
	return index;
}
void WorkerManager::mod_emp()
{
	if (this->m_fileIsEmpty)
	{
		cout << "文件不存在或为空" << endl;
	}
	else
	{
		cout << "请输入要修改的职工的编号" << endl;
		int id = 0;
		cin >> id;
		int ret = this->isExist(id);
		if (ret != -1)
		{
			//查找到了该编号的职工
			delete this->m_EmpArray[ret];

			int newId;
			string newName = "";
			int newDeptId = 0;

			cout << "查找到了" << id << "号职工，请输入新工号：" << endl;
			cin >> newId;
			cout << "请输入新的姓名：" << endl;
			cin >> newName;
			cout << "请输入新的岗位：" << endl;
			cout << "1、普通员工" << endl;
			cout << "2、经理" << endl;
			cout << "3、老板" << endl;
			cin >> newDeptId;
			
			Worker* worker = NULL;
			switch (newDeptId)
			{
			case 1:
				worker = new Employee(newId, newName, newDeptId);
				break;
			case 2:
				worker = new Manager(newId, newName, newDeptId);
				break;
			case 3:
				worker = new Boss(newId, newName, newDeptId);
				break;
			default:
				break;
			}

			//更新数据
			this->m_EmpArray[ret] = worker;

			cout << "修改成功" << endl;

			//保存到文件中
			this->save();
		}
		else
		{
			cout << "未找到该职工，修改失败" << endl;
		}
	}

	system("pause");
	system("cls");
}
void WorkerManager::find_emp()
{
	if (this->m_fileIsEmpty)
	{
		cout << "文件不存在或为空" << endl;
	}
	else
	{
		cout << "请输入查找方式：" << endl;
		cout << "1、按照职工编号查找" << endl;
		cout << "2、按照职工姓名查找" << endl;

		int select;
		cin >> select;

		if (select == 1)
		{
			int id;
			cout << "请输入查找的职工编号： " << endl;
			cin >> id;

			int ret = this->isExist(id);

			if (ret != -1)
			{
				//找到职工
				cout << "找到职工，信息如下：" << endl;
				this->m_EmpArray[ret]->showInfo();
			}
			else
			{
				cout << "查无此人" << endl;
			}
		}
		else if(select == 2)
		{
			string name = "";
			cout << "请输入查找的姓名：" << endl;
			cin >> name;

			bool flags = false;
			for (int i = 0; i < this->m_EmpNum; i++)
			{
				if (this->m_EmpArray[i]->m_name == name)
				{
					cout << "查找成功，职工编号为：" << this->m_EmpArray[i]->m_id
						<< "号信息如下：" << endl;
					this->m_EmpArray[i]->showInfo();
					flags = true;
				}
			}

			if (flags == false)
			{
				cout << "查找失败，查无此人" << endl;
			}
		}
		else
		{
			cout << "输入错误。" << endl;
		}
	}
	system("pause");
	system("cls");
}
void WorkerManager::sort_emp()
{
	if (this->m_fileIsEmpty)
	{
		cout << "文件不存在或为空" << endl;
		system("pause");
		system("cls");
	}
	else
	{
		cout << "请选择排序方式：" << endl;
		cout << "1、按照职工编号升序排列" << endl;
		cout << "2、按照职工编号降序排列" << endl;

		int select = 0;
		cin >> select;
		for (int i = 0; i < this->m_EmpNum; i++)
		{
			int minOrMax = i;
			for (int j = i+1; j < this->m_EmpNum; j++)
			{
				if (select == 1)
				{
					if (this->m_EmpArray[minOrMax]->m_id > this->m_EmpArray[j]->m_id)
					{
						minOrMax = j;
					}
				}
				else
				{
					if (this->m_EmpArray[minOrMax]->m_id < this->m_EmpArray[j]->m_id)
					{
						minOrMax = j;
					}
				}
			}
			//判断一开始认定的最小值或最大值是不是计算的最大值或最小值，如果不是，交换
			if (i != minOrMax)
			{
				Worker* temp = this->m_EmpArray[i];
				this->m_EmpArray[i] = this->m_EmpArray[minOrMax];
				this->m_EmpArray[minOrMax] = temp;
			}
		}

		cout << "排序成功！排序后的结果：" << endl;
		//排序后的结果存到文件中
		this->save();
		this->show_emp();
	}
}
void WorkerManager::clean_file()
{
	cout << "确定清空？" << endl;
	cout << "1、确定" << endl;
	cout << "2、返回" << endl;


	int select = 0;
	cin >> select;

	if (select == 1)
	{
		ofstream ofs(FILENAME, ios::trunc);//删除文件后重新创建
		ofs.close();

		if (this->m_EmpArray != NULL)
		{
			//删除堆区的每个职工对象
			for (int i = 0; i < this->m_EmpNum; i++)
			{
				delete this->m_EmpArray[i];
				this->m_EmpArray[i] = NULL;
			}
			//删除堆区数组指针
			delete[] this->m_EmpArray;
			this->m_EmpArray = NULL;
			this->m_EmpNum = 0;
			this->m_fileIsEmpty = true;
		}

		cout << "清空成功" << endl;
	}
	system("pause");
	system("cls");
}
WorkerManager::~WorkerManager()
{
	if (this->m_EmpArray != NULL)
	{
		for (int i = 0; i < this->m_EmpNum; i++)
		{
			if (this->m_EmpArray[i] != NULL)
			{
				delete this->m_EmpArray[i];
				this->m_EmpArray[i] = NULL;
			}
		}
		delete[] this->m_EmpArray;
		this->m_EmpArray = NULL;
	}
}