//#include <iostream>
//#include <fstream>
//#include <vector>
//using namespace std;
//
////vector����Զ�����������
//class Person
//{
//public:
//	Person(string name, int age)
//	{
//		this->m_name = name;
//		this->m_age = age;
//	}
//	string m_name;
//	int m_age;
//};
//void test1()
//{
//	vector<Person> v;
//	Person p1("aaa", 10);
//	Person p2("bbb", 11);
//	Person p3("ccc", 12);
//	Person p4("ddd", 13);
//	Person p5("eee", 14);
//	//���������������
//	v.push_back(p1);
//	v.push_back(p2);
//	v.push_back(p3);
//	v.push_back(p4);
//	v.push_back(p5);
//	//����
//	for (vector<Person>::iterator it = v.begin(); it != v.end(); it++)
//	{
//		/*cout << "������" << (*it).m_name << " ���䣺" << (*it).m_age << endl;*/
//		cout << "������" << it->m_name << " ���䣺" << it->m_age << endl;
//	}
//}
//void test2()
//{
//	vector<Person*> v;
//	Person p1("aaa", 10);
//	Person p2("bbb", 11);
//	Person p3("ccc", 12);
//	Person p4("ddd", 13);
//	Person p5("eee", 14);
//	//���������������
//	v.push_back(&p1);
//	v.push_back(&p2);
//	v.push_back(&p3);
//	v.push_back(&p4);
//	v.push_back(&p5);
//	//����
//	for (vector<Person*>::iterator it = v.begin(); it != v.end(); it++)
//	{
//		cout << "������" << (*it)->m_name << " ���䣺" << (*it)->m_age << endl;
//	}
//}
//int main()
//{
//	test1();
//	test2();
//}