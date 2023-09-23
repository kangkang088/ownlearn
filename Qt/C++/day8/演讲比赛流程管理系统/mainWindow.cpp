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
#include "speechManager.h"
#include <ctime>

using namespace std;

int main()
{
	//���������
	srand((unsigned int)time(NULL));
	//���������
	SpeechManager sm;

	//���Դ���ѡ��
	/*for (map<int,Speaker>::iterator it = sm.m_Speaker.begin(); it != sm.m_Speaker.end(); it++)
	{
		cout << "ѡ�ֱ�ţ�" << (*it).first << "������" << (*it).second.m_name << "�÷֣�" << (*it).second.m_score[0] << endl;
	}*/

	int choice = 0;
	while (true)
	{
		sm.show_menu();

		cout << "����������ѡ��" << endl;
		cin >> choice;
		switch (choice)
		{			
		case 0://�˳�ϵͳ
			sm.exitSystem();
			break;
		case 1://��ʼ����
			sm.startSpeech();
			break;
		case 2://�鿴�����¼
			sm.showRecord();
			break;
		case 3://��ձ�����¼
			sm.clearRecord();
			break;
		default:
			system("cls");
			break;
		}
	}
	
}