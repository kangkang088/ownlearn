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
	//随机数种子
	srand((unsigned int)time(NULL));
	//管理类对象
	SpeechManager sm;

	//测试创建选手
	/*for (map<int,Speaker>::iterator it = sm.m_Speaker.begin(); it != sm.m_Speaker.end(); it++)
	{
		cout << "选手编号：" << (*it).first << "姓名：" << (*it).second.m_name << "得分：" << (*it).second.m_score[0] << endl;
	}*/

	int choice = 0;
	while (true)
	{
		sm.show_menu();

		cout << "请输入您的选择：" << endl;
		cin >> choice;
		switch (choice)
		{			
		case 0://退出系统
			sm.exitSystem();
			break;
		case 1://开始比赛
			sm.startSpeech();
			break;
		case 2://查看往届记录
			sm.showRecord();
			break;
		case 3://清空比赛记录
			sm.clearRecord();
			break;
		default:
			system("cls");
			break;
		}
	}
	
}