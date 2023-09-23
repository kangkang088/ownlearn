#pragma once
#include <iostream>
using namespace std;
#include "worker.h"
#include "employee.h"
#include "manager.h"
#include "boss.h"
#include <fstream>
#define FILENAME "empFile.txt"
#include <string>

class WorkerManager
{
public:
	WorkerManager();

	//展示菜单
	void show_Menu();

	//退出功能
	void ExitSystem();

	//记录文件中的人数个数
	int m_EmpNum;

	//员工数组的指针
	Worker** m_EmpArray;

	//添加职工
	void add_emp();

	//保存到文件
	void save();

	//判断文件是否为空
	bool m_fileIsEmpty;

	//统计文件中的人数
	int get_empNum();

	//初始化职工
	void init_emp();

	//显示职工
	void show_emp();

	//删除职工
	void del_emp();

	//判断职工是否存在，返回其数组中的下标，用来实现删除职工功能
	int isExist(int id);

	//修改职工
	void mod_emp();

	//查找职工
	void find_emp();

	//排序职工
	void sort_emp();

	//清空文件
	void clean_file();

	~WorkerManager();


};
