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
#include <numeric>
#include "workerManager.h"
#include "worker.h"
#include "employee.h"
#include "manager.h"
#include "boss.h"

using namespace std;

int main()
{
	//����
	//WorkerManager wm;
	//Worker* worker = NULL;
	//worker = new Employee(1, "����", 1);
	//worker->showInfo();
	//Worker* worker2 = NULL;
	//worker2 = new Manager(2, "����", 2);
	//worker2->showInfo();
	//Worker* worker3 = NULL;
	//worker3 = new Boss(3, "����", 3);
	//worker3->showInfo();
	//delete worker;
	//delete worker2;
	//delete worker3;

	while (true)
	{
		WorkerManager wm;
		wm.show_Menu();
		int choice = 0;
		cout << "����������ѡ��" << endl;
		cin >> choice;

		switch (choice)
		{
		case 0://�˳�����
			wm.ExitSystem();
			break;
		case 1://����ְ��
			wm.add_emp();
			break;
		case 2://��ʾְ��
			wm.show_emp();
			break;
		case 3://ɾ��ְ��

		//{//����
		//	int ret = wm.isExist(5);
		//	if (ret != -1)
		//	{
		//		cout << "ְ������" << endl;
		//	}
		//	else
		//	{
		//		cout << "ְ��������" << endl;
		//	}
		//	break;
		//}

			wm.del_emp();
			break;
		case 4://�޸�ְ��
			wm.mod_emp();
			break;
		case 5://����ְ��
			wm.find_emp();
			break;
		case 6://����ְ��
			wm.sort_emp();
			break;
		case 7://����ĵ�
			wm.clean_file();
			break;
		default:
			//����
			system("cls");
			break;
		}
	}


	system("pause");
	return 0;
}