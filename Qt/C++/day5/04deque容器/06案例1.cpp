#include <iostream>
#include <fstream>
#include <vector>
#include <algorithm>
#include <string>
#include <deque>
#include <ctime>
using namespace std;

//选手类
class Person
{
public:
    Person(string name, int score)
    {
        this->m_name = name;
        this->m_score = score;
    }
    string m_name;
    int m_score;
};
void creatPerson(vector<Person>& v)
{
    string nameSeed = "ABCDE";
    for (int i = 0; i < 5; i++)
    {
        
        string name = "选手";
        name += nameSeed[i];

        int score = 0;

        Person p(name, score);
        v.push_back(p);
    }
}
void setScore(vector<Person>& v)
{
    for (vector<Person>::iterator it =v.begin() ; it != v.end(); it++)
    {
        //将评委的分数放入deque容器中
        deque<int> d;
        for (int i = 0; i < 10; i++)
        {
            int score = rand() % 41 + 60; //60-100
            d.push_back(score);
        }
        
        /*cout << "选手：" << it->m_name << "得分：" << endl;
        for (deque<int>::iterator dit = d.begin(); dit != d.end(); dit++)
        {
            cout << *dit << " ";
        }
        cout << endl;*/

        //排序
        sort(d.begin(), d.end());

        //去除最高和最低
        d.pop_back();
        d.pop_front();

        //取平均分
        int sum = 0;
        for (deque<int>::iterator dit = d.begin(); dit != d.end(); dit++)
        {
            sum += *dit;
        }

        //平均分
        int avg = sum / d.size();

        //赋值给选手
        it->m_score = avg;
    }
}
void showScore(vector<Person>& v)
{
    for (vector<Person>::iterator it = v.begin(); it != v.end(); it++)
    {
        cout << "姓名：" << (*it).m_name << "，平均分：" << (*it).m_score << endl;
    }
}
int main()
{
    //随机数种子
    srand((unsigned int)time(NULL));
    //1.创建无名选手
    vector<Person> v;
    creatPerson(v);
    /*for (vector<Person>::iterator it = v.begin(); it != v.end(); it++)
    {
        cout << "姓名：" << (*it).m_name << ",分数： " << (*it).m_score << endl;
    }*/
    //2.打分
    setScore(v);
    //3.显示最后得分
    showScore(v);
}