#include <iostream>
#include <fstream>
#include "08MyArray.hpp"
using namespace std;

void printIntArray(MyArray<int>& arr)
{
	for (int i = 0; i < arr.getSize(); i++)
	{
		cout << arr[i] << endl;
	}
}
void test1()
{
	MyArray<int> arr1(5);
	for (int i = 0; i < 5; i++)
	{
		//����β�巨�������в�������
		arr1.pushBack(i);
	}
	cout << "arr1�������е����ݣ�" << endl;
	printIntArray(arr1);
	cout << "arr1�������ǣ�" << arr1.getCapacity() << endl;
	cout << "arr1�Ĵ�С�ǣ�" << arr1.getSize() << endl;
	
	MyArray<int> arr2(arr1);
	cout << "arr2�������е����ݣ�" << endl;
	printIntArray(arr2);

	//βɾ
	arr2.popBack();
	cout << "arr2βɾ��" << endl;
	cout << "arr2�������ǣ�" << arr2.getCapacity() << endl;
	cout << "arr2�Ĵ�С�ǣ�" << arr2.getSize() << endl;
	/*MyArray<int> arr3(100);
	arr3 = arr2;*/
}
//�����Զ�����������
class Person
{

public:
	Person() {}
	Person(string name, int age)
	{
		this->m_name = name;
		this->m_age = age;
	}
	string m_name;
	int m_age;
};
void printPerson(MyArray<Person>& arr)
{
	for (int i = 0; i < arr.getSize(); i++)
	{
		cout << "������" << arr[i].m_name << endl;
		cout << "���䣺" << arr[i].m_age << endl;
	}
}
void test2()
{
	MyArray<Person> arr(10);
	Person p1("�����", 10000);
	Person p2("����", 20);
	Person p3("槼�", 2000);
	Person p4("����", 25);
	Person p5("����", 35);

	//����
	arr.pushBack(p1);
	arr.pushBack(p2);
	arr.pushBack(p3);
	arr.pushBack(p4);
	arr.pushBack(p5);
	//��ӡ
	printPerson(arr);
	//����
	cout << "�Զ������͵�arr������" << arr.getCapacity() << endl;
	cout << "�Զ������͵�arr��С��" << arr.getSize() << endl;
	//��С
}
int main()
{

	//test1();
	test2();
}