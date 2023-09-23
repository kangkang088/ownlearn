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

	//չʾ�˵�
	void show_menu();

	//�˳�ϵͳ
	void exitSystem();

	//����ѡ�� ����  12�� ���
	vector<int>v1;

	//��һ�ֽ�������  6�� ���
	vector<int>v2;

	//ʤ��ǰ��������  3�� ���
	vector<int>vVictory;

	//��ű�� �Լ���Ӧ�� ����ѡ�� ����
	map<int, Speaker> m_Speaker;

	//��¼��������
	int m_index;

	//��ʼ������
	void inttSpeech();

	//����12��ѡ��
	void creatSpeaker();

	//��ʼ��������
	void startSpeech();

	//��ǩ
	void speechDraw();

	//����
	void speechContest();

	//��ʾ��������
	void show_score();

	//���浽�ļ�
	void saveRecord();

	//�鿴�����¼
	void loadRecord();

	//�ж��ļ��Ƿ�Ϊ��
	bool fileIsEmpty;

	//��������¼������
	map<int, vector<string>> m_record;

	//��ʾ�����¼
	void showRecord();

	//��ռ�¼
	void clearRecord();

	~SpeechManager();
};