#define _CRT_SECURE_NO_WARNINGS 1
#include <stdio.h>
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

int main()
{
	int arr[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
	int sz = sizeof(arr) / sizeof(arr[0]);
	int lefet = 0;//���±�
	int right = sz - 1;//���±�
	int k = 8;



	while (lefet<=right)
	{
		int mid = (lefet + right) / 2;
		if (arr[mid] > k)
		{
			right = mid - 1;
		}
		else if (arr[mid] < k)
		{
			lefet = mid + 1;
		}
		else
		{
			printf("�ҵ��ˣ��±��ǣ�%d\n", mid);
			break;
		}
	}
	if (lefet>right)
	{
		printf("�Ҳ���\n");
	}

	return 0;
}