#include "workerManager.h"
WorkerManager::WorkerManager()
{
	//1.�ļ�������
	ifstream ifs;
	ifs.open(FILENAME, ios::in);
	if (!ifs.is_open())
	{
		cout << "�ļ�������" << endl;
		//��ʼ��
		this->m_EmpNum = 0;
		this->m_EmpArray = NULL;
		this->m_fileIsEmpty = true;
		ifs.close();
		return;
	}
	//2.�ļ����ڣ�������Ϊ��
	char ch;
	ifs >> ch;
	if (ifs.eof())
	{
		//�ļ�Ϊ��
		cout << "�ļ�Ϊ��" << endl;
		//��ʼ��
		this->m_EmpNum = 0;
		this->m_EmpArray = NULL;
		this->m_fileIsEmpty = true;
		ifs.close();
		return;
	}
	//3.�ļ���Ϊ��
	int num = this->get_empNum();
	cout << "��ǰְ��������" << num << endl;
	this->m_EmpNum = num;

	//���ٿռ�
	this->m_EmpArray = new Worker * [this->m_EmpNum];
	//���ļ��е����ݴ浽������
	this->init_emp();

	//����
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
	cout << "*********  ��ӭʹ��ְ������ϵͳ�� **********" << endl;
	cout << "*************  0.�˳��������  *************" << endl;
	cout << "*************  1.����ְ����Ϣ  *************" << endl;
	cout << "*************  2.��ʾְ����Ϣ  *************" << endl;
	cout << "*************  3.ɾ����ְְ��  *************" << endl;
	cout << "*************  4.�޸�ְ����Ϣ  *************" << endl;
	cout << "*************  5.����ְ����Ϣ  *************" << endl;
	cout << "*************  6.���ձ������  *************" << endl;
	cout << "*************  7.��������ĵ�  *************" << endl;
	cout << "********************************************" << endl;
	cout << endl;
}
void WorkerManager::ExitSystem()
{
	cout << "��ӭ�´�ʹ�ã�" << endl;
	system("pause");
	//system("cls");
	exit(0);
}
void WorkerManager::add_emp()
{
	cout << "���������ְ��������" << endl;

	int addNum = 0;
	cin >> addNum;

	if (addNum > 0)
	{
		//���
		//��������¿ռ�Ĵ�С

		//������
		int newSize = this->m_EmpNum + addNum;

		//�����¿ռ�
		Worker** newSpace = new Worker * [newSize];

		//��ԭ���Ŀռ����ݿ������¿ռ���
		if (this->m_EmpArray != NULL)
		{
			for (int i = 0; i < this->m_EmpNum; i++)
			{
				newSpace[i] = this->m_EmpArray[i];
			}
		}

		//���������
		for (int i = 0; i < addNum; i++)
		{
			int id;
			string name;
			int dSelect;

			cout << "�������" << i + 1 << "����ְ���ı�ţ�" << endl;
			cin >> id;
			cout << "�������" << i + 1 << "����ְ����������" << endl;
			cin >> name;
			cout << "��ѡ��" << i + 1 << "����ְ���ĸ�λ��" << endl;
			cout << "1����ͨԱ��" << endl;
			cout << "2������" << endl;
			cout << "3���ϰ�" << endl;
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
			//��ӵ���������
			newSpace[this->m_EmpNum + i] = worker;

		}

		//�ͷ�ԭ�еĿռ�
		delete[] this->m_EmpArray;

		//�����¿ռ��ָ��
		this->m_EmpArray = newSpace;

		//����ְ������
		this->m_EmpNum = newSize;

		//�ɹ���Ӻ󱣴浽�ļ��У�����ֻ�Ǹó�����ڴ��У�
		this->save();

		//��ʾ
		cout << "�ɹ������" << addNum << "��ְ��" << endl;

	}
	else
	{
		cout << "������������" << endl;
	}

	system("pause");
	system("cls");
}
void WorkerManager::save()
{
	ofstream ofs;
	ofs.open(FILENAME, ios::out);//����ķ�ʽ���ļ� -д�ļ�

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
		//ͳ������
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
	//�ж��ļ��Ƿ�Ϊ��
	if (this->m_fileIsEmpty)
	{
		cout << "�ļ������ڻ����ļ�Ϊ��" << endl;
	}
	else
	{
		for (int i = 0; i < this->m_EmpNum; i++)
		{
			//���ö�̬
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
		cout << "�ļ������ڻ�Ϊ��" << endl;
	}
	else
	{
		//��ְ�����ɾ��ְ��
		cout << "��������Ҫɾ����ְ�����" << endl;
		int id = 0;
		cin >> id;

		int index = this->isExist(id);

		if (index != -1)//���ڣ�����ɾ��
		{
			for (int i = index; i < this->m_EmpNum - 1; i++)
			{
				this->m_EmpArray[i] = this->m_EmpArray[i + 1];
			}
			//���������е���Ա����
			this->m_EmpNum--;
			//���µ��ļ���
			this->save();
			cout << "ɾ���ɹ�" << endl;
		}
		else
		{
			cout << "��Ա��������,ɾ��ʧ��" << endl;
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
			//�ҵ�ְ��
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
		cout << "�ļ������ڻ�Ϊ��" << endl;
	}
	else
	{
		cout << "������Ҫ�޸ĵ�ְ���ı��" << endl;
		int id = 0;
		cin >> id;
		int ret = this->isExist(id);
		if (ret != -1)
		{
			//���ҵ��˸ñ�ŵ�ְ��
			delete this->m_EmpArray[ret];

			int newId;
			string newName = "";
			int newDeptId = 0;

			cout << "���ҵ���" << id << "��ְ�����������¹��ţ�" << endl;
			cin >> newId;
			cout << "�������µ�������" << endl;
			cin >> newName;
			cout << "�������µĸ�λ��" << endl;
			cout << "1����ͨԱ��" << endl;
			cout << "2������" << endl;
			cout << "3���ϰ�" << endl;
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

			//��������
			this->m_EmpArray[ret] = worker;

			cout << "�޸ĳɹ�" << endl;

			//���浽�ļ���
			this->save();
		}
		else
		{
			cout << "δ�ҵ���ְ�����޸�ʧ��" << endl;
		}
	}

	system("pause");
	system("cls");
}
void WorkerManager::find_emp()
{
	if (this->m_fileIsEmpty)
	{
		cout << "�ļ������ڻ�Ϊ��" << endl;
	}
	else
	{
		cout << "��������ҷ�ʽ��" << endl;
		cout << "1������ְ����Ų���" << endl;
		cout << "2������ְ����������" << endl;

		int select;
		cin >> select;

		if (select == 1)
		{
			int id;
			cout << "��������ҵ�ְ����ţ� " << endl;
			cin >> id;

			int ret = this->isExist(id);

			if (ret != -1)
			{
				//�ҵ�ְ��
				cout << "�ҵ�ְ������Ϣ���£�" << endl;
				this->m_EmpArray[ret]->showInfo();
			}
			else
			{
				cout << "���޴���" << endl;
			}
		}
		else if(select == 2)
		{
			string name = "";
			cout << "��������ҵ�������" << endl;
			cin >> name;

			bool flags = false;
			for (int i = 0; i < this->m_EmpNum; i++)
			{
				if (this->m_EmpArray[i]->m_name == name)
				{
					cout << "���ҳɹ���ְ�����Ϊ��" << this->m_EmpArray[i]->m_id
						<< "����Ϣ���£�" << endl;
					this->m_EmpArray[i]->showInfo();
					flags = true;
				}
			}

			if (flags == false)
			{
				cout << "����ʧ�ܣ����޴���" << endl;
			}
		}
		else
		{
			cout << "�������" << endl;
		}
	}
	system("pause");
	system("cls");
}
void WorkerManager::sort_emp()
{
	if (this->m_fileIsEmpty)
	{
		cout << "�ļ������ڻ�Ϊ��" << endl;
		system("pause");
		system("cls");
	}
	else
	{
		cout << "��ѡ������ʽ��" << endl;
		cout << "1������ְ�������������" << endl;
		cout << "2������ְ����Ž�������" << endl;

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
			//�ж�һ��ʼ�϶�����Сֵ�����ֵ�ǲ��Ǽ�������ֵ����Сֵ��������ǣ�����
			if (i != minOrMax)
			{
				Worker* temp = this->m_EmpArray[i];
				this->m_EmpArray[i] = this->m_EmpArray[minOrMax];
				this->m_EmpArray[minOrMax] = temp;
			}
		}

		cout << "����ɹ��������Ľ����" << endl;
		//�����Ľ���浽�ļ���
		this->save();
		this->show_emp();
	}
}
void WorkerManager::clean_file()
{
	cout << "ȷ����գ�" << endl;
	cout << "1��ȷ��" << endl;
	cout << "2������" << endl;


	int select = 0;
	cin >> select;

	if (select == 1)
	{
		ofstream ofs(FILENAME, ios::trunc);//ɾ���ļ������´���
		ofs.close();

		if (this->m_EmpArray != NULL)
		{
			//ɾ��������ÿ��ְ������
			for (int i = 0; i < this->m_EmpNum; i++)
			{
				delete this->m_EmpArray[i];
				this->m_EmpArray[i] = NULL;
			}
			//ɾ����������ָ��
			delete[] this->m_EmpArray;
			this->m_EmpArray = NULL;
			this->m_EmpNum = 0;
			this->m_fileIsEmpty = true;
		}

		cout << "��ճɹ�" << endl;
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