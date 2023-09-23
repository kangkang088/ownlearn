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
	//测试
	//WorkerManager wm;
	//Worker* worker = NULL;
	//worker = new Employee(1, "张三", 1);
	//worker->showInfo();
	//Worker* worker2 = NULL;
	//worker2 = new Manager(2, "李四", 2);
	//worker2->showInfo();
	//Worker* worker3 = NULL;
	//worker3 = new Boss(3, "王五", 3);
	//worker3->showInfo();
	//delete worker;
	//delete worker2;
	//delete worker3;

	while (true)
	{
		WorkerManager wm;
		wm.show_Menu();
		int choice = 0;
		cout << "请输入您的选择：" << endl;
		cin >> choice;

		switch (choice)
		{
		case 0://退出程序
			wm.ExitSystem();
			break;
		case 1://增加职工
			wm.add_emp();
			break;
		case 2://显示职工
			wm.show_emp();
			break;
		case 3://删除职工

		//{//测试
		//	int ret = wm.isExist(5);
		//	if (ret != -1)
		//	{
		//		cout << "职工存在" << endl;
		//	}
		//	else
		//	{
		//		cout << "职工不存在" << endl;
		//	}
		//	break;
		//}

			wm.del_emp();
			break;
		case 4://修改职工
			wm.mod_emp();
			break;
		case 5://查找职工
			wm.find_emp();
			break;
		case 6://排序职工
			wm.sort_emp();
			break;
		case 7://清空文档
			wm.clean_file();
			break;
		default:
			//清屏
			system("cls");
			break;
		}
	}


	system("pause");
	return 0;
}