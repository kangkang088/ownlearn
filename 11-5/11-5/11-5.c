#define _CRT_SECURE_NO_WARNINGS 1
#include<stdio.h>
#include<stdlib.h>
#include<string.h>
//int main()
//{
//	char input[20] = { 0 };
//	system("shutdown -s -t 600");
//	again:
//	printf("��ĵ��Խ���ʮ���Ӻ�ػ�������������������Խ�����ػ��������룺");
//	scanf("%s", input);
//	if (strcmp(input, "������") == 0)
//	{
//		printf("���Բ���ػ�");
//		system("shutdown -a");
//	}
//	else
//	{
//		goto again;
//	}
//	return 0;
//}



//int Add(int x, int y)
//{
//	int z = 0;
//	z = x + y;
//	return z;
//}
//int main()
//{
//	int sum = 0;
//	int a = 10;
//	int b = 20;
//	sum = Add(a, b);
//	printf("%d\n", sum);
//	return 0;
//}


//int main()
//{
//	int ch = 0;
//	char secret[] = "123456";
//	int ret = 0;
//	char password[] = { 0 };
//	scanf("%s", password);
//	while (ch = getchar() != '\n')
//	{
//		;
//	}
//	printf("��ȷ�ϣ�Y/N����");
//	ret = getchar();
//	if (ret == 'Y')
//	{
//		printf("ȷ�ϳɹ�\n");
//		if (strcmp(secret, password) == 0)
//		{
//			printf("������ȷ");
//		}
//		else
//			{
//				printf("�������");
//			}
//	}
//	if (ret == 'N')
//	{
//		printf("����ȷ��");
//	}
//	return 0;
//}

//��һ���ַ������ҳ�26����дӢ����ĸ���ֵĴ��������
//int main()
//{
//	char arr1[20] = { 0 };
//	char arr2[26] = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
//	int i = 0;
//	int num = 0;
//	int k = 0;
//	int sz = 0;
//	sz = sizeof(arr1) / sizeof(arr1[0]);
//	scanf("%s", arr1);
//	for (i = 0; i < sz; i++)
//	{
//		for (k = 0; k < 26; k++)
//		{
//			if (arr1[i] == arr2[k])
//			{
//				num++;
//			}
//		}
//	}
//	printf("%d\n", num);
//	return 0;
//}




//�������20������ǰʮ�����򣬺�ʮ�����򣬲������
//void game(int arr[],int n)
//{
//	int nem = 0;
//	int max = 0;
//	int i = 0;
//	int j = 0;
//	int nax = 0;
//	int min = 0;
//	for (i = 0; i < 8;i++)
//	{
//		nem = i;
//		for (j = i + 1; j < 10; j++)
//		{
//			if (arr[nem] > arr[j])
//			{
//				nem = j;
//			}
//		}
//		if (nem != i)
//		{
//			min = arr[i];
//			arr[i] = arr[nem];
//			arr[nem] = min;
//		}
//	}
//	for (i = 10; i < 19; i++)
//	{
//		nax = i;
//		for (j = i + 1; j < 20; j++)
//		{
//			if (arr[nax] < arr[j])
//			{
//				nax = j;
//			}
//		}
//		if (nax != i)
//		{
//			max = arr[i];
//			arr[i] = arr[nax];
//			arr[nax] = max;
//		}
//	}
//	return 0; //��û�ж��У�������ʲôֵ��û�з���ֵ�����ͣ���void
//}
//int main()
//{
//	int arr[20], i;
//	srand((unsigned)time(NULL));
//	printf("������ɵ�20����Ϊ��");
//	for (i = 0; i < 20; i++)
//	{
//		arr[i] = rand() % 10;
//		printf("%d ", arr[i]);
//	}
//	game(arr, 20);
//	printf("\nǰʮ��");
//	for (i = 0; i < 10; i++)
//	{
//		printf("%d ", arr[i]);
//	}
//	printf("\n��ʮ��");
//	for (i = 10; i < 20; i++)
//	{
//		printf("%d ", arr[i]);
//	}
//	return 0;
//}



//�����Ķ���
//int MAX(int x, int y)
//{
//	if (x > y)
//		return x;
//	else
//	{
//		return y;
//	}
//}
//int main()
//{
//	int a = 10;
//	int b = 20;
//	������ʹ��
//	int max = MAX(a, b);
//	printf("%d\n", max);
//	return 0;
//}


//void Swap(int x, int y) 
//{
//	int mid = 0;   //�ú������ύ��ab��ֵ����������xy��ֵ����ʼ��ab���Լ����ԵĿռ䣬���뺯�������¿���xy�Ŀռ䣬����ֵxy���������潻��xy��û�з���ֵ������ab���ύ��
//	mid = x;
//	x = y;
//	y = mid;
//}	
//int main()
//{
//	int a = 10;
//	int b = 20;
//	Swap(a, b);
//		printf("%d %d\n", a, b);
//	return 0;
//}



//void Swap2(int* x, int* y)
//{
//	int mid = 0;    //����ab�ĵ�ַ������ָ�����ͱ���������*���н����ñ������õ��ñ����д洢�ĵ�ַ����Ӧ�ı�����ֵ���ڽ��н�����ab�ͻύ����
//	mid = *x;
//	*x = *y;
//	*y = mid;
//}
//int main()
//{
//	int a = 10;
//	int b = 20;
//	Swap2(&a, &b);
//	printf("%d %d\n", a, b);
//	return 0;
//}


//#include <math.h>
////дһ�������������ж�һ�����ǲ�������
//int panduan(int x)
//{
//	int i = 0;
//	for (i = 2; i <= sqrt(x); i++)
//	{
//		if (x%i == 0)
//			return 0;
//		//else   //����д���У�����9����iΪ2����ʱ��ֱ��return 1����3��û�в���
//		//	return 1;
//	}
//	return 1;//���������ʵ���Ǻ���if�ж�i>sqrt(i)һ������һֱ���Ե�����������ʱ��Ҳû��return 0�����أ�˵����������㷵��return 1��������
//}
//int main()
//{
//	int j = 0;
//	for (j = 100; j <= 200; j++)
//	{
//		if (panduan(j) == 1)
//		{
//			printf("������%d \n", j);
//		}
//		else
//		{
//			printf("��������%d \n", j);
//		}
//	}
//	return 0;
//}


