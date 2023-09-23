#include "speechManager.h"


//����
SpeechManager::SpeechManager()
{
	//��ʼ��
	this->inttSpeech();
	//����12��ѡ��
	this->creatSpeaker();

	//���������¼
	this->loadRecord();
}
//��ʾ�˵�
void SpeechManager::show_menu()
{
	cout << "********************************************" << endl;
	cout << "*************  ��ӭ�μ��ݽ����� ************" << endl;
	cout << "*************  1.��ʼ�ݽ�����  *************" << endl;
	cout << "*************  2.�鿴�����¼  *************" << endl;
	cout << "*************  3.��ձ�����¼  *************" << endl;
	cout << "*************  0.�˳���������  *************" << endl;
	cout << "********************************************" << endl;
	cout << endl;
}
//�˳�ϵͳ
void SpeechManager::exitSystem()
{
	cout << "��ӭ�´�ʹ��" << endl;
	system("pause");
	exit(0);
}
//��ʼ������
void SpeechManager::inttSpeech()
{
	//�����ÿ�
	this->v1.clear();
	this->v2.clear();
	this->vVictory.clear();
	this->m_Speaker.clear();
	//����
	this->m_index = 1;
	//��ʼ����¼����
	this->m_record.clear();//��յ����ڴ��еģ������ļ��е�
}
//����12��ѡ��
void SpeechManager::creatSpeaker()
{
	string nameSeed = "ABCDEFGHIJKL";
	for (int i = 0; i < nameSeed.size(); i++)
	{
		string name = "ѡ��";
		name += nameSeed[i];

		Speaker sp;
		sp.m_name = name;

		for (int  j = 0; j < 2; j++)
		{
			sp.m_score[j] = 0;
		}

		//����ѡ�ֱ�ŷŵ�v1������
		v1.push_back(i + 10001);

		//ѡ�ֱ�ź�ѡ�ַŵ�map������
		this->m_Speaker.insert(make_pair(i + 10001, sp));
	}
}
//��ʼ����������
void SpeechManager::startSpeech()
{
	//��һ�ֱ���
	//��ǩ
	this->speechDraw();
	//����
	this->speechContest();
	//��ʾ�������
	this->show_score();
	//�ڶ��ֱ���
	this->m_index++;
	//��ǩ
	this->speechDraw();
	//����
	this->speechContest();
	//��ʾ�������
	this->show_score();
	//����������ļ���
	this->saveRecord();

	//����������ʵʱ����
	//��ʼ��
	this->inttSpeech();
	//����12��ѡ��
	this->creatSpeaker();

	//���������¼
	this->loadRecord();

	cout << "����������" << endl;
	system("pause");
	system("cls");
}
//��ǩ
void SpeechManager::speechDraw()
{
	cout << "��<<" << this->m_index << ">>��ѡ�����ڱ���" << endl;
	cout << "------------------------------" << endl;
	cout << "��ǩ����ݽ�˳�����£�" << endl;
	
	if (this->m_index == 1)
	{
		random_shuffle(this->v1.begin(), this->v1.end());

		for (vector<int>::iterator it = this->v1.begin(); it !=this->v1.end(); it++)
		{
			cout << *it << " ";
		}
		cout << endl;
	}
	else
	{
		random_shuffle(this->v2.begin(), this->v2.end());

		for (vector<int>::iterator it = this->v2.begin(); it != this->v2.end(); it++)
		{
			cout << *it << " ";
		}
		cout << endl;
	}

	cout << "------------------------------" << endl;
	system("pause");
	cout << endl;
}
//����
void SpeechManager::speechContest()
{
	cout << "��<<" << this->m_index << ">>�ֱ�����ʽ��ʼ" << endl;
	cout << "------------------------------" << endl;

	//׼����ʱ���������С��ɼ�
	multimap<double, int, greater<double>> groupScore;

	int num = 0;//��¼��Ա������6��һ��

	vector<int> v_src;//����ѡ�ֵ�����
	if (this->m_index == 1)
	{
		v_src = v1;
	}
	else
	{
		v_src = v2;
	}

	//��������ѡ�ֽ��б���
	for (vector<int>::iterator it = v_src.begin(); it != v_src.end(); it++)
	{
		num++;
		//��ί���
		deque<double> d;

		for (int i = 0; i < 10; i++)
		{
			double score = (rand() % 401 + 600) / 10.f;
			//cout << score << " ";

			d.push_back(score);


		}
		//cout << endl;

		sort(d.begin(), d.end(), greater<double>());

		d.pop_front();//ȥ����߷�
		d.pop_back();//ȥ����ͷ�

		double sum = accumulate(d.begin(), d.end(), 0.0f);//�ܷ�
		double avg = sum / (double)d.size();//ƽ����

		//��ӡƽ����
		//cout << "��ţ�" << *it << "������" << this->m_Speaker[*it].m_name << "��ȡƽ���֣�" << avg << endl;

		//��ƽ���ַ���������
		this->m_Speaker[*it].m_score[this->m_index - 1] = avg;

		//��������ݣ�������ʱ��С��������
		groupScore.insert(make_pair(avg, *it));

		//ÿ������ȡ��ǰ����
		if (num % 6 == 0)
		{
			cout << "��" << num / 6 << "С������������£�" << endl;
			for (multimap<double,int>::iterator it = groupScore.begin(); it != groupScore.end(); it++)
			{
				cout << "��ţ�" << (*it).second << "������" << this->m_Speaker[it->second].m_name << "�����ɼ���"
					<< this->m_Speaker[it->second].m_score[this->m_index - 1] << endl;
			}

			//ȡ��ǰ����
			int count = 0;
			for (multimap<double,int>::iterator it = groupScore.begin(); it != groupScore.end()&&count < 3; it++,count++)
			{
				if (this->m_index == 1)
				{
					this->v2.push_back((*it).second);
				}
				else
				{
					this->vVictory.push_back((*it).second);
				}
			}

			groupScore.clear();
			cout << endl;
		}
	}

	cout << "��<<" << this->m_index << ">>�ֱ������" << endl;

	system("pause");
}
//��ʾ��������
void SpeechManager::show_score()
{
	cout << "------------------------------" << endl;
	cout << "��<<" << this->m_index << ">>�ֵ�ѡ�ֵĽ�����Ϣ����" << endl;
	
	vector<int> v;
	if (this->m_index == 1)
	{
		v = this->v2;
	}
	else
	{
		v = this->vVictory;
	}

	for (vector<int>::iterator it = v.begin(); it != v.end(); it++)
	{
		cout << "ѡ�ֱ�ţ�" << *it << " ������" << this->m_Speaker[*it].m_name
			<< " �÷֣�" << this->m_Speaker[*it].m_score[this->m_index - 1] << endl;
	}
	cout << endl;

	system("pause");
	system("cls");
	this->show_menu();
}
//���浽�ļ�
void SpeechManager::saveRecord()
{
	ofstream ofs;
	ofs.open("speech.csv", ios::out | ios::app);

	//��ÿ��ѡ������д�뵽�ļ���
	for (vector<int>::iterator it = this->vVictory.begin(); it != this->vVictory.end(); it++)
	{
		ofs << *it << "," << this->m_Speaker[*it].m_score[1] << ",";
	}

	ofs << endl;

	ofs.close();
	cout << "��¼�ѱ���" << endl;

	//�м�¼�ˣ������ļ�״̬
	this->fileIsEmpty = false;
}
//�鿴�����¼
void SpeechManager::loadRecord()
{
	ifstream ifs("speech.csv", ios::in);
	if (!ifs.is_open())
	{
		this->fileIsEmpty = true;
		//cout << "�ļ�������" << endl;
		ifs.close();
		return;
	}

	//�ļ���յ����
	char ch;
	ifs >> ch;
	if (ifs.eof())
	{
		//cout << "�ļ�Ϊ��" << endl;
		this->fileIsEmpty = true;
		ifs.close();
		return;
	}

	//�ļ���Ϊ��
	this, fileIsEmpty = false;

	ifs.putback(ch);//�������ȡ�ĵ����ַ�������
	string data;

	int index = 0;//�ڼ���

	while (ifs >> data)
	{
		vector<string> v;//����ַ���
		int pos = -1;//�鵽����λ�õı���
		int start = 0;
		//cout << data << endl;
		while (true)
		{
			
			pos = data.find(",", start);
			if (pos == -1)
			{
				//û���ҵ�
				break;
			}
			//�ҵ�
			string temp = data.substr(start, pos - start);
			//cout << temp << endl;
			v.push_back(temp);
			start = pos + 1;
		}
		this->m_record.insert(make_pair(index, v));
		index++;
		
	}

	ifs.close();

	
	/*for (map<int,vector<string>>::iterator it = this->m_record.begin(); it != this->m_record.end(); it++)
	{
		cout << it->first << "�ھ���ţ�" << it->second[0] << "������" << it->second[1]
			<< "�Ǿ���ţ�" << it->second[2] << "������" << it->second[3]
			<< "������ţ�" << it->second[4] << "������" << it->second[5] << endl;
	}*/
}
//��ʾ�����¼
void SpeechManager::showRecord()
{
	if (this->fileIsEmpty)
	{
		cout << "�ļ������ڻ�Ϊ��" << endl;
	}
	else
	{
		for (int i = 0; i < this->m_record.size(); i++)
		{
			cout << "��" << i + 1 << "��"
				<< "�ھ���ţ�" << this->m_record[i][0] << "�÷֣�" << this->m_record[i][1]
				<< "�Ǿ���ţ�" << this->m_record[i][2] << "�÷֣�" << this->m_record[i][3]
				<< "������ţ�" << this->m_record[i][4] << "�÷֣�" << this->m_record[i][5] << endl;
		}
	}
	system("pause");
	system("cls");
}
//��ռ�¼
void SpeechManager::clearRecord()
{
	cout << "ȷ����գ�" << endl;
	cout << "1��ȷ��" << endl;
	cout << "2������" << endl;

	int select = 0;
	cin >> select;
	if (select == 1)
	{
		ofstream ofs;
		ofs.open("speech.csv", ios::trunc);
		ofs.close();

		//��ʼ������
		this->inttSpeech();
		//����ѡ��
		this->creatSpeaker();
		//��ȡ�����¼
		this->loadRecord();

		cout << "��ճɹ�" << endl;
	}

	system("pause");
	system("cls");
}
//����
SpeechManager::~SpeechManager()
{

}
