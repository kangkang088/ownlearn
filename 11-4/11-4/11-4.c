#define _CRT_SECURE_NO_WARNINGS 1
#include <stdio.h>
#include <math.h>
#include <windows.h>
#include <stdlib.h>
#include <string.h>
//int main()
//{
//	int i = 0;
//	printf("Hello World\n");
//	return 0;
//}


//��1-100֮��9�ĸ���
//int main()
//{
//	int i = 0;
//	for (i = 1; i <= 100; i++)
//	{
//		if (i % 10 == 9)
//		{
//			printf("%d\n", i);
//		}
//		if (i/10 == 9)
//		{
//			printf("%d\n", i);
//		}
//	}
//	return 0;
//}


//1/1-1/2+1/3-1/4+...+1/99-1/100

//int main()
//{
//	int i = 0;
//	double sum = 0.0;
//	int flag = 1;
//	for (i = 1; i <= 100; i++)
//	{
//		sum += flag * 1.0 / i;  //Ҫ��õ�������/���߱���Ӵһ������������Ȼ���������Ļ���ֻ��õ���
//		flag = -flag;
//	}
//	printf("%lf\n", sum);
//	return 0;
//}
//int main()
//{
//	int i = 0;
//	double sum1 = 0.0;
//	double sum2 = 0.0;
//	double sum = 0.0;
//	int k = 0;
//	for (i = 1; i <= 99; i += 2)
//	{
//		sum1+= 1.0 / i;
//	}
//	for (k = 2; k <= 100; k += 2)
//	{
//		sum2 += 1.0 / k;
//	}
//	sum = sum1 - sum2;
//	printf("%lf\n", sum);
//	return 0;
//}


//ʮ��������������

//10�������е����ֵ
//int main()
//{
//	int arr[10] = { 1.2,3,4,5,6,7,8,9,10 };
//	int i = 0;
//	int max = arr[0];  //�����������������ģ������������ȫ�Ǹ�������max = 0�����������0�������������������
//	int sz = sizeof(arr) / sizeof(arr[0]);
//	for (i = 1; i < sz; i++)   //����󣬴ӵڶ�����ʼ�Ƚ�
//	{
//		if (arr[i]>max)
//		{
//			max = arr[i];
//		}
//	}
//	printf("%d\n", max);
//	return 0;
//}

//���9*9�˷��ھ���

//int main()
//{
//	int i = 0;
//	for (i = 1; i <= 9; i++)
//	{
//		int j = 1;
//		for (j = 1; j <= i; j++)
//		{
//			printf("%d*%d=%-2d ", i, j, i*j);//%2d,�Ҷ��룬%-2d�������  2d���治�ӿո�һ�������š�
//		}
//		printf("\n");
//	}
//	return 0;
//}

//���ֲ���
//int main()
//{
//	int arr[10] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//	int k = 58;
//	int sz = sizeof(arr) / sizeof(arr[0]);
//	int right = sz - 1;
//	int left = 0;
//	int mid = 0;	
//	while (left<=right)
//	{
//		mid = (left + right) / 2;
//		if (arr[mid] < k)
//		{
//			left++;
//		}
//		if (arr[mid]>k)
//		{
//			right--;
//		}
//		if (arr[mid] == k)
//		{
//			printf("�ҵ��ˣ��±��ǣ�%d\n", mid);
//			break;
//		}
//	}
//	if (left > right)
//	{
//		printf("�Ҳ���\n");
//	}
//	return 0;
//}

//��������Ϸ
//��������������һ�������
//������
#include<time.h>
//void menu()
//{
//	printf("*******************\n");
//	printf("** 1.play 0.exit **\n"); 
//	printf("*******************\n");
//}
//
//void game()
//{
//	//1.����һ������� 
//	//2.������
//	//rand();ר�������������
//	int ret = 0 ;
//	int guess = 0;
//	int num = 0;
//	
//		ret = rand()%100+1;//1-100֮�䣻
//		while (1)
//		{
//			printf("������");
//				scanf("%d", &guess);
//				getchar();//��ֹ������ĸ������ѭ����
//				if (guess > ret)
//				{
//					num++;
//					printf("�´���\n");
//				}
//				else if (guess < ret)
//				{
//					num++;
//					printf("��С��\n");
//				}
//				else
//				{
//					printf("�¶���\n");
//					break;
//				}
//				if (num >= 10)
//				{
//					printf("���ź������������꣬��Ϸ����\n");
//					break;
//				}
//		}
//
//}
//int main()
//{
//	srand((unsigned int)time(NULL));//����rand()�����������������rand����Ϊ�˳������������ǰ��ʹ��srand������ȥ���������������
//	//srand���������һ����㣬��������ѭ�����棬��Ȼ���ÿ�ζ����á����������Ҫһֱ�䣬�����ֵ��������Ϊ���������������srand��������������Ҫ���������ѭ��������ֻҪһ��һֱ�仯�����͡���ʱ�����������
//	//��ʱ����������������������㣻
//	//time_t   time(time_t* timer)
//	//time_t  //��long�ض���õ��ģ�ʱ��������ǳ�����
//	//ʱ���  ��ǰ�������ʱ�䣬��ȥ���������ʼʱ�䣨1970.1.1  0��0��00��=���룻
//	int input = 0;
//	do
//	{
//		menu();
//		printf("��ѡ��");
//		scanf("%d", &input);
//		switch (input)
//		{
//		case 1:
//			game();
//			break;
//		case 0:
//			printf("�˳���Ϸ\n");
//			break;
//		default:
//			printf("ѡ�����\n");
//			break;
//		}
//	} while (input);
//	return 0;
//}

void menu()
{
	printf("*****************************\n");
	printf("**     1.��ʼ 0. ����      **\n");
	printf("*****************************\n");
}
void game()
{
	int guess = 0;
	int ret = 0;
	ret = rand() % 100 + 1;	
	printf("��ʼ�����֣�");
	while (1)
	{
		scanf("%d", &guess);  //ÿ�β¶�Ҫ����һ�Σ�������ѭ�����棬��������棬ֻ������һ�Ρ�
		if (guess < ret)
		{
			printf("��С��\n");
		}
		else if (guess>ret)
		{
			printf("�´���\n");
		}
		else
		{
			printf("��ϲ�����¶���\n");
			break;
		}
	}
	}
int main()
{
	srand((unsigned)time(NULL));
	int input = 0;	
	do
	{
		menu();
		scanf("%d", &input);//Ҫ��ѭ�����棬��������棬�����һ������1�������������Ϸ��ֱ����¶ԣ�����ֱ������������һ�ֲ����֣�����ѯ�����Ƿ���1/0ȷ���Ƿ������Ϸ��
		switch (input)
		{
		case 1:
			game();
			break;
		case 0:
			printf("�˳���Ϸ\n");
			break;
		default:
		{
				   printf("�������\n");
				   break;
		}
		}
	} while (input);
	return 0;
}

// goto���
