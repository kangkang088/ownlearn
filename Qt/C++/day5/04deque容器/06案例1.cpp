#include <iostream>
#include <fstream>
#include <vector>
#include <algorithm>
#include <string>
#include <deque>
#include <ctime>
using namespace std;

//ѡ����
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
        
        string name = "ѡ��";
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
        //����ί�ķ�������deque������
        deque<int> d;
        for (int i = 0; i < 10; i++)
        {
            int score = rand() % 41 + 60; //60-100
            d.push_back(score);
        }
        
        /*cout << "ѡ�֣�" << it->m_name << "�÷֣�" << endl;
        for (deque<int>::iterator dit = d.begin(); dit != d.end(); dit++)
        {
            cout << *dit << " ";
        }
        cout << endl;*/

        //����
        sort(d.begin(), d.end());

        //ȥ����ߺ����
        d.pop_back();
        d.pop_front();

        //ȡƽ����
        int sum = 0;
        for (deque<int>::iterator dit = d.begin(); dit != d.end(); dit++)
        {
            sum += *dit;
        }

        //ƽ����
        int avg = sum / d.size();

        //��ֵ��ѡ��
        it->m_score = avg;
    }
}
void showScore(vector<Person>& v)
{
    for (vector<Person>::iterator it = v.begin(); it != v.end(); it++)
    {
        cout << "������" << (*it).m_name << "��ƽ���֣�" << (*it).m_score << endl;
    }
}
int main()
{
    //���������
    srand((unsigned int)time(NULL));
    //1.��������ѡ��
    vector<Person> v;
    creatPerson(v);
    /*for (vector<Person>::iterator it = v.begin(); it != v.end(); it++)
    {
        cout << "������" << (*it).m_name << ",������ " << (*it).m_score << endl;
    }*/
    //2.���
    setScore(v);
    //3.��ʾ���÷�
    showScore(v);
}