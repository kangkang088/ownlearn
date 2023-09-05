#include <iostream>
using namespace std;
#define MAX 1000
struct People
{
	string m_name;
	string m_gender;
	int m_age;
	string m_phoneNumber;
	string m_address;
};
struct InfoBox
{
	People people[MAX];
	//ͨѶ¼������ʵ�ʸ���
	int m_size;
};
void showMenu()
{
	cout << "***************************" << endl;
	cout << "*****  1�������ϵ��  *****" << endl;
	cout << "*****  2����ʾ��ϵ��  *****" << endl;
	cout << "*****  3��ɾ����ϵ��  *****" << endl;
	cout << "*****  4��������ϵ��  *****" << endl;
	cout << "*****  5���޸���ϵ��  *****" << endl;
	cout << "*****  6�������ϵ��  *****" << endl;
	cout << "*****  0���˳�ͨѶ¼  *****" << endl;
	cout << "***************************" << endl;
}
void addInfo(InfoBox* infoBox)
{
	if (infoBox->m_size == MAX)
	{
		cout << "ͨѶ¼���������޷����";
		return;
	}
	else
	{
		cout << "����������" << endl;
		string name;
		cin >> name;
		cout << "�������Ա�" << endl;
		string gender;

		while (true)
		{
			cin >> gender;
			if (gender == "��" || gender == "Ů")
			{
				infoBox->people[infoBox->m_size].m_gender = gender;
				break;
			}
			cout << "������������������" << endl;
		}
		cout << "����������" << endl;
		int age;
		cin >> age;
		cout << "������绰" << endl;
		string phoneNumber;
		cin >> phoneNumber;
		cout << "�������ַ" << endl;
		string address;
		cin >> address;
		infoBox->people[infoBox->m_size].m_name = name;
		infoBox->people[infoBox->m_size].m_age = age;
		infoBox->people[infoBox->m_size].m_phoneNumber = phoneNumber;
		infoBox->people[infoBox->m_size].m_address = address;
		infoBox->m_size++;
		cout << "��ӳɹ�" << endl;
		system("pause");
		system("cls");
	}
}
void showInfo(InfoBox* infoBox)
{
	if (infoBox->m_size == 0)
	{
		cout << "��ǰͨѶ¼Ϊ�գ��������ϵ��" << endl;
	}
	else
	{
		for (int i = 0; i < infoBox->m_size; i++)
		{
			cout << "������" << infoBox->people[i].m_name << ",";
			cout << "�Ա�" << infoBox->people[i].m_gender << ",";
			cout << "���䣺" << infoBox->people[i].m_age << ",";
			cout << "�绰��" << infoBox->people[i].m_phoneNumber << ",";
			cout << "סַ��" << infoBox->people[i].m_address << endl;
		}
	}
	system("pause");
	system("cls");
}
int testInfo(InfoBox* infoBox, string name)
{
	for (int i = 0; i < infoBox->m_size; i++)
	{
		if (infoBox->people[i].m_name == name)
		{
			return i;
		}
	}
	return -1;
}
void deleteInfo(InfoBox* infoBox)
{
	cout << "����������Ҫɾ������ϵ�˵�����" << endl;
	string name;
	cin >> name;
	if (testInfo(infoBox, name) == -1)
	{
		cout << "���޴���" << endl;
	}
	else
	{
		cout << "�ҵ����ˣ�ִ��ɾ��" << endl;
		for (int i = testInfo(infoBox, name); i < infoBox->m_size; i++)
		{
			infoBox->people[i] = infoBox->people[i + 1];
		}
		infoBox->m_size--;
		cout << "ɾ���ɹ�" << endl;
	}
	system("pause");
	system("cls");

}
void findInfo(InfoBox* infoBox)
{
	cout << "����������Ҫ���ҵ���ϵ�˵�����" << endl;
	string name;
	cin >> name;
	testInfo(infoBox, name);
	if (testInfo(infoBox, name) == -1)
	{
		cout << "���޴���";
	}
	else {
		cout << "������" << infoBox->people[testInfo(infoBox, name)].m_name << ",";
		cout << "�Ա�" << infoBox->people[testInfo(infoBox, name)].m_gender << ",";
		cout << "���䣺" << infoBox->people[testInfo(infoBox, name)].m_age << ",";
		cout << "�绰��" << infoBox->people[testInfo(infoBox, name)].m_phoneNumber << ",";
		cout << "סַ��" << infoBox->people[testInfo(infoBox, name)].m_address << endl;
	}
	system("pause");
	system("cls");
}
void changeInfo(InfoBox* infoBox) 
{
	cout << "����������Ҫ�޸ĵ���ϵ�˵�����" << endl;
	string name;
	cin >> name;
	int ref = testInfo(infoBox, name);
	if (ref == -1)
	{
		cout << "���޴���" << endl;
	}
	else
	{
		cout << "����������" << endl;
		string name;
		cin >> name;
		cout << "�������Ա�" << endl;
		string gender;

		while (true)
		{
			cin >> gender;
			if (gender == "��" || gender == "Ů")
			{
				infoBox->people[ref].m_gender = gender;
				break;
			}
			cout << "������������������" << endl;
		}
		cout << "����������" << endl;
		int age;
		cin >> age;
		cout << "������绰" << endl;
		string phoneNumber;
		cin >> phoneNumber;
		cout << "�������ַ" << endl;
		string address;
		cin >> address;
		infoBox->people[ref].m_name = name;
		infoBox->people[ref].m_age = age;
		infoBox->people[ref].m_phoneNumber = phoneNumber;
		infoBox->people[ref].m_address = address;
		cout << "�޸ĳɹ�" << endl;
		
	}
	system("pause");
	system("cls");
}
void resetInfo(InfoBox* infoBox)
{
	infoBox->m_size = 0;
	cout << "ͨѶ¼�����" << endl;
	system("pause");
	system("cls");
}
int main()
{
	InfoBox infoBox;
	infoBox.m_size = 0;
	int select = 0;
	while (true)
	{
		showMenu();
		cout << "��ѡ����Ҫִ�еĹ���" << endl;
		cin >> select;
		switch (select)
		{
		case 1:addInfo(&infoBox);
			break;
		case 2:showInfo(&infoBox);
			break;
		case 3:deleteInfo(&infoBox);
			break;
		case 4:findInfo(&infoBox);
			break;
		case 5:changeInfo(&infoBox);
			break;
		case 6:resetInfo(&infoBox);
			break;
		case 0:
			cout << "��ӭ�´ι���" << endl;
			return 0;
		default:
			system("pause");
			break;
		}
	}
}