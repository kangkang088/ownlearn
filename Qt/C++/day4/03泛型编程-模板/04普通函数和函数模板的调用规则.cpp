//#include <iostream>
//#include <fstream>
//using namespace std;
//
////1.�������ģ�����ͨ����������ʵ�֣����ȵ�����ͨ����
//void myPrint(int a, int b)
//{
//	cout << "������ͨ����" << endl;
//}
//template <typename T>
//void myPrint(T a, T b)
//{
//	cout << "���ú���ģ��" << endl;
//}
//template <typename T>
//void myPrint(T a, T b, T c)
//{
//	cout << "�������غ���ģ��" << endl;
//}
//
////2.����ͨ����ģ������б�ķ�ʽ�����ȵ��ú���ģ��
////3.����ģ���������
////4.�������ģ����Բ������õ�ƥ�䣬���ȵ��ú���ģ��
//
//int main()
//{
//	int a = 10;
//	int b = 10;
//	int c = 100;
//	//������ͨ����
//	myPrint(a, b);
//	//ͨ����ģ������б����ú���ģ��
//	myPrint<>(a, b);
//	//����ģ����Է�������
//	myPrint(a, b, c);
//	//����ģ��������õ�ƥ��
//	char c1 = 'a';		
//	char c2 = 'b';
//	myPrint(c1, c2);
//
//}