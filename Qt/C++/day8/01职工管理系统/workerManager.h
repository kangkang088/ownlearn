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

	//չʾ�˵�
	void show_Menu();

	//�˳�����
	void ExitSystem();

	//��¼�ļ��е���������
	int m_EmpNum;

	//Ա�������ָ��
	Worker** m_EmpArray;

	//���ְ��
	void add_emp();

	//���浽�ļ�
	void save();

	//�ж��ļ��Ƿ�Ϊ��
	bool m_fileIsEmpty;

	//ͳ���ļ��е�����
	int get_empNum();

	//��ʼ��ְ��
	void init_emp();

	//��ʾְ��
	void show_emp();

	//ɾ��ְ��
	void del_emp();

	//�ж�ְ���Ƿ���ڣ������������е��±꣬����ʵ��ɾ��ְ������
	int isExist(int id);

	//�޸�ְ��
	void mod_emp();

	//����ְ��
	void find_emp();

	//����ְ��
	void sort_emp();

	//����ļ�
	void clean_file();

	~WorkerManager();


};
