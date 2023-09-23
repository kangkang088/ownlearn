#include "speechManager.h"


//构造
SpeechManager::SpeechManager()
{
	//初始化
	this->inttSpeech();
	//创建12名选手
	this->creatSpeaker();

	//加载往届记录
	this->loadRecord();
}
//显示菜单
void SpeechManager::show_menu()
{
	cout << "********************************************" << endl;
	cout << "*************  欢迎参加演讲比赛 ************" << endl;
	cout << "*************  1.开始演讲比赛  *************" << endl;
	cout << "*************  2.查看往届记录  *************" << endl;
	cout << "*************  3.清空比赛记录  *************" << endl;
	cout << "*************  0.退出比赛程序  *************" << endl;
	cout << "********************************************" << endl;
	cout << endl;
}
//退出系统
void SpeechManager::exitSystem()
{
	cout << "欢迎下次使用" << endl;
	system("pause");
	exit(0);
}
//初始化属性
void SpeechManager::inttSpeech()
{
	//容器置空
	this->v1.clear();
	this->v2.clear();
	this->vVictory.clear();
	this->m_Speaker.clear();
	//轮数
	this->m_index = 1;
	//初始化记录容器
	this->m_record.clear();//清空的是内存中的，不是文件中的
}
//创建12名选手
void SpeechManager::creatSpeaker()
{
	string nameSeed = "ABCDEFGHIJKL";
	for (int i = 0; i < nameSeed.size(); i++)
	{
		string name = "选手";
		name += nameSeed[i];

		Speaker sp;
		sp.m_name = name;

		for (int  j = 0; j < 2; j++)
		{
			sp.m_score[j] = 0;
		}

		//创建选手编号放到v1容器中
		v1.push_back(i + 10001);

		//选手编号和选手放到map容器中
		this->m_Speaker.insert(make_pair(i + 10001, sp));
	}
}
//开始比赛的流程
void SpeechManager::startSpeech()
{
	//第一轮比赛
	//抽签
	this->speechDraw();
	//比赛
	this->speechContest();
	//显示晋级结果
	this->show_score();
	//第二轮比赛
	this->m_index++;
	//抽签
	this->speechDraw();
	//比赛
	this->speechContest();
	//显示晋级结果
	this->show_score();
	//保存分数到文件中
	this->saveRecord();

	//重置容器，实时更新
	//初始化
	this->inttSpeech();
	//创建12名选手
	this->creatSpeaker();

	//加载往届记录
	this->loadRecord();

	cout << "本届比赛完毕" << endl;
	system("pause");
	system("cls");
}
//抽签
void SpeechManager::speechDraw()
{
	cout << "第<<" << this->m_index << ">>轮选手正在比赛" << endl;
	cout << "------------------------------" << endl;
	cout << "抽签后的演讲顺序如下：" << endl;
	
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
//比赛
void SpeechManager::speechContest()
{
	cout << "第<<" << this->m_index << ">>轮比赛正式开始" << endl;
	cout << "------------------------------" << endl;

	//准备临时容器。存放小组成绩
	multimap<double, int, greater<double>> groupScore;

	int num = 0;//记录人员个数，6人一组

	vector<int> v_src;//比赛选手的容器
	if (this->m_index == 1)
	{
		v_src = v1;
	}
	else
	{
		v_src = v2;
	}

	//遍历所有选手进行比赛
	for (vector<int>::iterator it = v_src.begin(); it != v_src.end(); it++)
	{
		num++;
		//评委打分
		deque<double> d;

		for (int i = 0; i < 10; i++)
		{
			double score = (rand() % 401 + 600) / 10.f;
			//cout << score << " ";

			d.push_back(score);


		}
		//cout << endl;

		sort(d.begin(), d.end(), greater<double>());

		d.pop_front();//去除最高峰
		d.pop_back();//去除最低分

		double sum = accumulate(d.begin(), d.end(), 0.0f);//总分
		double avg = sum / (double)d.size();//平均分

		//打印平均分
		//cout << "编号：" << *it << "姓名：" << this->m_Speaker[*it].m_name << "获取平均分：" << avg << endl;

		//将平均分放入容器中
		this->m_Speaker[*it].m_score[this->m_index - 1] = avg;

		//将打分数据，放入临时的小组容器中
		groupScore.insert(make_pair(avg, *it));

		//每六个人取出前三名
		if (num % 6 == 0)
		{
			cout << "第" << num / 6 << "小组比赛名次如下：" << endl;
			for (multimap<double,int>::iterator it = groupScore.begin(); it != groupScore.end(); it++)
			{
				cout << "编号：" << (*it).second << "姓名：" << this->m_Speaker[it->second].m_name << "比赛成绩："
					<< this->m_Speaker[it->second].m_score[this->m_index - 1] << endl;
			}

			//取走前三名
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

	cout << "第<<" << this->m_index << ">>轮比赛完毕" << endl;

	system("pause");
}
//显示比赛分数
void SpeechManager::show_score()
{
	cout << "------------------------------" << endl;
	cout << "第<<" << this->m_index << ">>轮的选手的晋级信息如下" << endl;
	
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
		cout << "选手编号：" << *it << " 姓名：" << this->m_Speaker[*it].m_name
			<< " 得分：" << this->m_Speaker[*it].m_score[this->m_index - 1] << endl;
	}
	cout << endl;

	system("pause");
	system("cls");
	this->show_menu();
}
//保存到文件
void SpeechManager::saveRecord()
{
	ofstream ofs;
	ofs.open("speech.csv", ios::out | ios::app);

	//将每个选手数据写入到文件中
	for (vector<int>::iterator it = this->vVictory.begin(); it != this->vVictory.end(); it++)
	{
		ofs << *it << "," << this->m_Speaker[*it].m_score[1] << ",";
	}

	ofs << endl;

	ofs.close();
	cout << "记录已保存" << endl;

	//有记录了，更改文件状态
	this->fileIsEmpty = false;
}
//查看往届记录
void SpeechManager::loadRecord()
{
	ifstream ifs("speech.csv", ios::in);
	if (!ifs.is_open())
	{
		this->fileIsEmpty = true;
		//cout << "文件不存在" << endl;
		ifs.close();
		return;
	}

	//文件清空的清空
	char ch;
	ifs >> ch;
	if (ifs.eof())
	{
		//cout << "文件为空" << endl;
		this->fileIsEmpty = true;
		ifs.close();
		return;
	}

	//文件不为空
	this, fileIsEmpty = false;

	ifs.putback(ch);//将上面读取的单个字符读回来
	string data;

	int index = 0;//第几届

	while (ifs >> data)
	{
		vector<string> v;//存放字符串
		int pos = -1;//查到，的位置的变量
		int start = 0;
		//cout << data << endl;
		while (true)
		{
			
			pos = data.find(",", start);
			if (pos == -1)
			{
				//没有找到
				break;
			}
			//找到
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
		cout << it->first << "冠军编号：" << it->second[0] << "分数：" << it->second[1]
			<< "亚军编号：" << it->second[2] << "分数：" << it->second[3]
			<< "季军编号：" << it->second[4] << "分数：" << it->second[5] << endl;
	}*/
}
//显示往届记录
void SpeechManager::showRecord()
{
	if (this->fileIsEmpty)
	{
		cout << "文件不存在或为空" << endl;
	}
	else
	{
		for (int i = 0; i < this->m_record.size(); i++)
		{
			cout << "第" << i + 1 << "届"
				<< "冠军编号：" << this->m_record[i][0] << "得分：" << this->m_record[i][1]
				<< "亚军编号：" << this->m_record[i][2] << "得分：" << this->m_record[i][3]
				<< "季军编号：" << this->m_record[i][4] << "得分：" << this->m_record[i][5] << endl;
		}
	}
	system("pause");
	system("cls");
}
//清空记录
void SpeechManager::clearRecord()
{
	cout << "确认清空？" << endl;
	cout << "1、确认" << endl;
	cout << "2、返回" << endl;

	int select = 0;
	cin >> select;
	if (select == 1)
	{
		ofstream ofs;
		ofs.open("speech.csv", ios::trunc);
		ofs.close();

		//初始化属性
		this->inttSpeech();
		//创建选手
		this->creatSpeaker();
		//获取往届记录
		this->loadRecord();

		cout << "清空成功" << endl;
	}

	system("pause");
	system("cls");
}
//析构
SpeechManager::~SpeechManager()
{

}
