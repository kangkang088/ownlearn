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
	//通讯录人数的实际个数
	int m_size;
};
void showMenu()
{
	cout << "***************************" << endl;
	cout << "*****  1、添加联系人  *****" << endl;
	cout << "*****  2、显示联系人  *****" << endl;
	cout << "*****  3、删除联系人  *****" << endl;
	cout << "*****  4、查找联系人  *****" << endl;
	cout << "*****  5、修改联系人  *****" << endl;
	cout << "*****  6、清空联系人  *****" << endl;
	cout << "*****  0、退出通讯录  *****" << endl;
	cout << "***************************" << endl;
}
void addInfo(InfoBox* infoBox)
{
	if (infoBox->m_size == MAX)
	{
		cout << "通讯录以已满，无法添加";
		return;
	}
	else
	{
		cout << "请输入姓名" << endl;
		string name;
		cin >> name;
		cout << "请输入性别" << endl;
		string gender;

		while (true)
		{
			cin >> gender;
			if (gender == "男" || gender == "女")
			{
				infoBox->people[infoBox->m_size].m_gender = gender;
				break;
			}
			cout << "输入有误，请重新输入" << endl;
		}
		cout << "请输入年龄" << endl;
		int age;
		cin >> age;
		cout << "请输入电话" << endl;
		string phoneNumber;
		cin >> phoneNumber;
		cout << "请输入地址" << endl;
		string address;
		cin >> address;
		infoBox->people[infoBox->m_size].m_name = name;
		infoBox->people[infoBox->m_size].m_age = age;
		infoBox->people[infoBox->m_size].m_phoneNumber = phoneNumber;
		infoBox->people[infoBox->m_size].m_address = address;
		infoBox->m_size++;
		cout << "添加成功" << endl;
		system("pause");
		system("cls");
	}
}
void showInfo(InfoBox* infoBox)
{
	if (infoBox->m_size == 0)
	{
		cout << "当前通讯录为空，请添加联系人" << endl;
	}
	else
	{
		for (int i = 0; i < infoBox->m_size; i++)
		{
			cout << "姓名：" << infoBox->people[i].m_name << ",";
			cout << "性别：" << infoBox->people[i].m_gender << ",";
			cout << "年龄：" << infoBox->people[i].m_age << ",";
			cout << "电话：" << infoBox->people[i].m_phoneNumber << ",";
			cout << "住址：" << infoBox->people[i].m_address << endl;
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
	cout << "请输入你想要删除的联系人的姓名" << endl;
	string name;
	cin >> name;
	if (testInfo(infoBox, name) == -1)
	{
		cout << "查无此人" << endl;
	}
	else
	{
		cout << "找到此人，执行删除" << endl;
		for (int i = testInfo(infoBox, name); i < infoBox->m_size; i++)
		{
			infoBox->people[i] = infoBox->people[i + 1];
		}
		infoBox->m_size--;
		cout << "删除成功" << endl;
	}
	system("pause");
	system("cls");

}
void findInfo(InfoBox* infoBox)
{
	cout << "请输入您想要查找的联系人的姓名" << endl;
	string name;
	cin >> name;
	testInfo(infoBox, name);
	if (testInfo(infoBox, name) == -1)
	{
		cout << "查无此人";
	}
	else {
		cout << "姓名：" << infoBox->people[testInfo(infoBox, name)].m_name << ",";
		cout << "性别：" << infoBox->people[testInfo(infoBox, name)].m_gender << ",";
		cout << "年龄：" << infoBox->people[testInfo(infoBox, name)].m_age << ",";
		cout << "电话：" << infoBox->people[testInfo(infoBox, name)].m_phoneNumber << ",";
		cout << "住址：" << infoBox->people[testInfo(infoBox, name)].m_address << endl;
	}
	system("pause");
	system("cls");
}
void changeInfo(InfoBox* infoBox) 
{
	cout << "请输入您想要修改的联系人的姓名" << endl;
	string name;
	cin >> name;
	int ref = testInfo(infoBox, name);
	if (ref == -1)
	{
		cout << "查无此人" << endl;
	}
	else
	{
		cout << "请输入姓名" << endl;
		string name;
		cin >> name;
		cout << "请输入性别" << endl;
		string gender;

		while (true)
		{
			cin >> gender;
			if (gender == "男" || gender == "女")
			{
				infoBox->people[ref].m_gender = gender;
				break;
			}
			cout << "输入有误，请重新输入" << endl;
		}
		cout << "请输入年龄" << endl;
		int age;
		cin >> age;
		cout << "请输入电话" << endl;
		string phoneNumber;
		cin >> phoneNumber;
		cout << "请输入地址" << endl;
		string address;
		cin >> address;
		infoBox->people[ref].m_name = name;
		infoBox->people[ref].m_age = age;
		infoBox->people[ref].m_phoneNumber = phoneNumber;
		infoBox->people[ref].m_address = address;
		cout << "修改成功" << endl;
		
	}
	system("pause");
	system("cls");
}
void resetInfo(InfoBox* infoBox)
{
	infoBox->m_size = 0;
	cout << "通讯录已清空" << endl;
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
		cout << "请选择您要执行的功能" << endl;
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
			cout << "欢迎下次光临" << endl;
			return 0;
		default:
			system("pause");
			break;
		}
	}
}