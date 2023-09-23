#pragma once
#include <iostream>
#include "speaker.h"
#include <vector>
#include <map>
#include <algorithm>
#include <deque>
#include <functional>
#include <numeric>
#include <fstream>
using namespace std;

class SpeechManager
{
public:
	SpeechManager();

	//展示菜单
	void show_menu();

	//退出系统
	void exitSystem();

	//比赛选手 容器  12人 编号
	vector<int>v1;

	//第一轮晋级容器  6人 编号
	vector<int>v2;

	//胜利前三名容器  3人 编号
	vector<int>vVictory;

	//存放编号 以及对应的 具体选手 容器
	map<int, Speaker> m_Speaker;

	//记录比赛轮数
	int m_index;

	//初始化属性
	void inttSpeech();

	//创建12名选手
	void creatSpeaker();

	//开始比赛流程
	void startSpeech();

	//抽签
	void speechDraw();

	//比赛
	void speechContest();

	//显示比赛分数
	void show_score();

	//保存到文件
	void saveRecord();

	//查看往届记录
	void loadRecord();

	//判断文件是否为空
	bool fileIsEmpty;

	//存放往届记录的容器
	map<int, vector<string>> m_record;

	//显示往届记录
	void showRecord();

	//清空记录
	void clearRecord();

	~SpeechManager();
};