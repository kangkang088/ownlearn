#define _CRT_SECURE_NO_WARNINGS 1
#include <stdio.h>
#include <string.h>
#include <windows.h>
#include <stdlib.h>
//int main()
//{
//	int i = 0;
//	for (i = 1; i <= 10; i++)
//	{
//
//		if (i == 5)
//		{
//			break;
//		}
//		printf("%d\n", i);
//	}
//	return 0;
//}
// 

//int main()
//{
//	int i = 0;
//	for (i = 1; i <= 10; i++)   //��ʼ��  �жϣ�    ����
//	{
//		if (i == 5)
//			continue;    //���ʱ�򲻻���ѭ����continue����������������i++��������������while��ͬ
//		printf("%d\n", i);
//	}
//	return 0;
//}


//int main()
//{
//	int i = 1;
//	while (i <= 10)
//	{
//		if (i == 5)
//			continue;   //���ʱ�����ѭ���������˰���i++���޷�����
//		printf("%d\n", i);
//		i++;
//	}
//	return 0;
//}


//int main()    
//{
//	int i = 0;
//	for (i = 0; i < 10; i++)
//	{
//		if (i = 5)
//			printf("hehe\n");    //��ѭ��
//		printf("hhah\n");
//	}
//	return 0;
//}
//
//i=0��i<10,ǰ�պ�


//int main()
//{
//	for (;;)             //forѭ���ĳ�ʼ�� ����  �ж϶�����ʡ�ԡ����жϲ��ֱ�ʡ�ԣ���˵���ж�������Ϊ�棬һֱ��ѭ����
//	{
//
//		printf("haha\n");
//	}
//		return 0;
//}



//int main()
//{
//	int i = 0;
//	int j = 0;
//	for (i = 0; i < 10; i++)
//	{
//		
//		for (j = 0; j < 10; j++)   //i=0;j=0ʡ�ԵĻ���ֻ�����10����10��֮��j��Ϊ10��i = 2�����ʱ��j��Ȼ��10���������ڶ���for
//		{
//			printf("hehe\n");
//		}
//	}
//	return 0;
//}


//int main()
//{
//	int i = 1;
//	do
//	{
//		printf("%d "; i);
//		i++;
//	}
//	while (i<=10)
//
//
//
//	return 0;
//}

//1*2*3*...*n
//int main()
//{
//	int i= 0;
//	int n = 0;
//	int ret = 1;
//	scanf("%d", &n);
//	
//	for (i = 1; i <= n; i++)
//	{
//		ret = ret*i;
//	}
//	printf("%d\n", ret);
//	return 0;
//}


//1!+2!+...+!10
//int main()
//{
//	int i = 0;
//	int n = 0;
//	int ret = 1;
//	int sum = 0;
//	for (n = 1; n <= 10; n++)
//	{
//		ret = 1;
//		for (i = 1; i <= n; i++)
//		{
//			ret = ret*i;
//		}
//		sum = sum + ret;
//	}
//	printf("%d\n", sum);
//	return 0;
//}

//�Ż�
//int main()
//{
//	int i = 0;
//	int n = 0;
//	int ret = 1;
//	int sum = 0;
//	for (n = 1; n <= 10; n++)
//	{
//		ret = ret*n;
//		sum = sum + ret;
//	}
//	printf("%d\n", sum);
//	return 0;
//}



//int main()
//{
//	int i = 1;
//	int sum = 1;
//	int n = 0;
//	scanf("%d", &n);
//	for (i = 1; i <= n; i++)
//	{
//		sum = sum*i;
//		
//	}
//	printf("%d\n", sum);
//
//	return 0;
//}

//int main()
//{
//	int i = 1;
//	int n = 1;
//	int sum = 1;
//	int sum1 = 0;
//	for (n = 1; n <= 3; n++)
//	{
//		sum = 1;
//		for (i = 1; i <= n; i++)
//		{
//			sum = sum*i;
//		}
//		sum1 = sum1 + sum;
//	}
//	printf("%d\n", sum1);
//	return 0;
//}


//int main()
//{
//	int arr[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//	int k = 7;
//	//дһ�����룬��arr���飨����ģ����ҵ�7��
//	int i = 0;
//	int sz = sizeof(arr) / sizeof(arr[0]);
//
//	for (i = 0; i < sz; i++)
//	{
//		if (k == arr[i])
//		{
//			printf("�ҵ��ˣ��±��ǣ�%d\n", i);
//			break;
//		}
//	}
//	if (i == sz)
//		printf("�Ҳ���\n");
//	return 0;
//}

//int main()
//{
//	int arr[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//	int sz = sizeof(arr) / sizeof(arr[0]);
//	int lefet = 0;//���±�
//	int right = sz - 1;//���±�
//	int k = 8;
//
//
//
//	while (lefet<=right)
//	{
//		int mid = (lefet + right) / 2;
//		if (arr[mid] > k)
//		{
//			right = mid - 1;
//		}
//		else if (arr[mid] < k)
//		{
//			lefet = mid + 1;
//		}
//		else
//		{
//			printf("�ҵ��ˣ��±��ǣ�%d\n", mid);
//			break;
//		}
//	}
//	if (lefet>right)
//	{
//		printf("�Ҳ���\n");
//	}
//
//	return 0;
//}



//int main()
//{
//	//welcome to bit!!!!!
//	//###########
//	//w#########!
//	//we#######!!
//		//...
//	//welcome to bit!!!!!
//	char arr1[] = "welcome to bit!!!!!";
//	char arr2[] ="###################";
//	int left = 0;
//	/*int right = sizeof(arr1) / sizeof(arr1[0]) - 2;*/    //�ַ���������\0
//	int right = strlen(arr1)-1;
//	while (left<=right)
//	{
//		arr2[right] = arr1[right];
//		arr2[left] = arr1[left];
//		printf("%s\n", arr2);
//		Sleep(1000);   //��Ϣ1�룻ͷ�ļ�#include <windows.h>
//		system("cls"); //ִ��ϵͳ�����һ������  - cls-�����Ļ��  #include <stdlib.h>
//		left++;
//		right--;
//	}
//	return 0;
//
//}


//int main()
//{
//	int i = 0;
//	char password[20] = {0};
//	for (i = 0; i < 3; i++)
//	{
//		printf("���������룺");
//		scanf("%s", password);
//		if (strcmp(password, "123456") == 0)  //�ȺŲ��������ж������ַ����Ƿ���ȣ�Ӧ���ÿ⺯��strcmp
//		{
//			printf("��½�ɹ�\n");
//			break;
//		}
//		else
//			printf("�������");
//	}
//	if (i == 3)
//		printf("�������룬�������˳�����");
//	return 0;
//}


//int main()
//{
//	int i = 0;
//	char password[20] = { 0 };
//	for (i = 0; i < 5; i++)
//	{
//		printf("���������룺");
//		scanf("%s", password);
//		if (strcmp(password, "123456") == 0)
//		{
//			printf("������ȷ\n");
//			break;
//		}
//		else
//		{
//			printf("�������\n");
//		}
//	}
//	if (i == 5)
//		printf("�����������󣬳����˳���\n");
//	return 0;
//
//}


//int main()
//{
//	char arr1[] = "welcome to beijing";
//	char arr2[] = "##################";
//	int left = 0;
//	int right = strlen(arr1) - 1;
//	while (left<=right)
//	{
//		arr2[left] = arr1[left];
//		arr2[right] = arr1[right];
//		left++;
//		right--;
//		Sleep(1000);
//		system("cls");
//		printf("%s\n", arr2);
//	}
//	printf("%s\n", arr2);
//	return 0;
//}


//д���������Ӵ�С���
//int main()
//{
//	int a = 0;
//	int b = 0;
//	int c = 0;
//	scanf("%d%d%d", &a, &b, &c);
//	if (a < b)
//	{
//		int mid = a;
//		a = b;
//		b = mid;
//	}
//	if (a < c)
//	{
//		int mid = a;
//		a = c;
//		c = mid;
//	}
//	if (b < c)
//	{
//		int mid = b;
//		b = c;
//		c = mid;
//	}
//	printf("%d %d %d\n", a, b, c);
//	return 0;
//}


//��ӡ���ı�����1-100��

//int main()
//{
//	int i = 1;
//	while (i >= 1 && i <= 100)
//	{
//		if (i % 3 == 0)
//		{
//			printf("%d\n", i);
//			i++;
//		}
//		i++;
//	}
//	return 0;
//}


//���Լ�� �����������������Լ����  շת�����

//int main()
//{
//	int a = 0;
//	int b = 0;
//	int i = 0;
//	scanf("%d%d", &a, &b);
//	while (a%b)
//	{
//		i = a % b;
//		a = b;
//		b = i;
//	}
//	printf("%d\n", b);
//	return 0;
//}


//��ӡ1000 - 2000֮�������

//int main()
//{
//	int count = 0;
//	int i = 0;
//	for (i = 1000; i <= 2000; i++)
//	{
//		if (i % 400 == 0)
//		{
//			printf("%d\n", i);
//			count++;
//		}
//		else if (i % 4 == 0 && i % 100 != 0)
//		{
//			printf("%d\n", i);
//			count++;
//		}
//	}
//	printf("%d\n", count);
//	return 0;
//if ((i % 4 == 0 && i % 100 != 0) || (i % 400 == 0))
//{
//}
//}


//��ӡ1000-2000֮�������

//int main()
//{
//	int i = 0;
//	int s = 0;
//	int t = 0;
//	int count = 0;
//	for (i = 1000; i <= 2000; i++)
//	{
//		for (s = 2; s < i; s++)
//		{
//			t = i%s;
//			if (t == 0)
//			{
//				break;
//			}
//		}
//		if (s == i)
//		{
//			count++;
//			printf("������%d\n", i);
//		}
//	}
//	printf("%d\n", count);
//	return 0;
//}



//�Ż�
//�Ż�
//һ���� m = a*b  ����ôa b�бض���һ����С��m�Ŀ�ƽ����һ������m�Ŀ�ƽ��
//�ж���������2��n-1һֱ�ж��ܲ������������鷳
//�ж�����������ֻ�ж�2-��ƽ�����������Χ����������Χû�У��ǿ�ƽ������-n-1֮��Ҳһ��û��
//��ƽ������sqrt����   �⺯��#include <math.h>
#include <math.h>
//int main()
//{
//	int i = 0;
//	int s = 0;
//	int t = 0;
//	int count = 0;
//	for (i = 1000; i <= 2000; i++)
//	{
//		for (s = 2; s <= sqrt(i); s++)
//		{
//			t = i%s;
//			if (t == 0)
//			{
//				break;
//			}
//		}
//		if (s>sqrt(i) )
//		{
//			count++;
//			printf("������%d\n", i);
//		}
//	}
//	printf("%d\n", count);
//	return 0;
//}


//�����Ż�
//ż��������������
//ֻ������
//int main()
//{
//	int i = 0;
//	int s = 0;
//	int t = 0;
//	int count = 0;
//	for (i = 1001; i <= 2000; i+=2)
//	{
//		for (s = 2; s <= sqrt(i); s++)
//		{
//			t = i%s;
//			if (t == 0)
//			{
//				break;
//			}
//		}
//		if (s>sqrt(i))
//		{
//			count++;
//			printf("������%d\n", i);
//		}
//	}
//	printf("%d\n", count);
//	return 0;
//}


//���������n�о��硷




