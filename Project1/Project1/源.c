#define _CRT_SECURE_NO_WARNINGS 1



#include <stdio.h>
#include <string.h>
//int main()
//{
//	int sum1 = 0;
//	int sum2 = 0;
//	int sum = 0;
//	scanf("%d%d", &sum1, &sum2);
//	sum = sum1 + sum2;
//	printf("sum = %d\n", sum);
//
//	return 0;
//}
//int main()
//{
//	printf("%d\n", sizeof(char));
//	printf("%d\n", sizeof(short));
//	printf("%d\n", sizeof(int));
//	printf("%d\n", sizeof(long));
//	printf("%d\n", sizeof(long long));
//	printf("%d\n", sizeof(float));
//	printf("%d\n", sizeof(double));
//	return 0;
//}
//int main()
//{
//	char arr[] = "asdb";
//	printf("%s\n",arr);
//	return 0;
//}
//int main()
//{
//	char arr =  'A';
//	printf("%d\n", arr);//����A��ASCII��ֵ��%s\n�������κΡ�
//	return 0;
//}
//int main()
//{
//	char arr = 'A';
//	printf("%c\n", arr);//����A
//	return 0;
//%c��ʾ���һ���ַ���

//%d��ʾ��������ŵ�ʮ������������

//%s��ʾ���һ���ַ�����֪��������\0����
//int main()		
//{
//	int age = 0;
//	scanf("%d", &age);
//	if (age<18)
//	{
//		printf("����С��18��δ����\n");
//	}
//	else
//	{
//		printf("����\n");
//	}
//	return 0;
//}
//int main()
//{
//	int arr[10] = { 1, 2, 3, 4, 5, 6, 7, 8, 9,10 };
//	printf("%d\n", arr[0]);
//	int i = 0;
//	while (i < 10)
//	{
//
//		printf("%d", arr[i]);
//		i++;
//	}
//
//	return 0;
//}

//int MAX(int x, int y)
//{
//	if (x > y)
//	{
//
//		return x;
//	}
//	else
//	{
//		return y;
//	}
//	}
//int main()
//{
//	int a = 10;
//	int b = 20;
//	int max = 0;
//	max = MAX(a, b);
//	printf("%d\n", max);
//
//	return 0;
//}	
//int ADD(int x, int y)
//{
//	int sum = x + y;
//	return sum;
//}
//int main()
//{
//	int a = 50;
//	int b = 50;
//	int c = 0;
//	c = ADD(a, b);
//	printf("%d\n", c);
//	return 0;
//}
//int main()
//{
//	int a = 0;// 00000000000000000000000000000000;
//	int b = ~a;//11111111111111111111111111111111;��ʾһ���������������ڴ��д洢��ʱ����һ�������ƵĲ���
//	//������ԭ�뷴�벹�붼��ͬ��������ԭ�롣���룺��ʾ������λ���䣬����ȡ�������룺����+1.
//	//11111111111111111111111111111110��
//	//10000000000000000000000000000001;
//	printf("%d\n", b);
//	return 0;
//}
//int main()
//{
//	printf("%d\n", strlen("abcdef"));
//	// \62��������һ��ת���ַ�
//	printf("%d\n", strlen("c:\test\628\test.c"));
//	return 0;
//}
//int main()
//{
//	int a = 50;
//	int b = 78;
//	int c = 0;
//		c = (a > b ? a : b);
//		printf("%d\n", c);
//	return 0;
//}
int main()
{
	printf("��н100��,��Ҫ�ô���ʮ����\n");
	int i = 0;
	while (i <100000)
	{
		i++;
		printf("%d\n", i);
		
	}
	printf("�ɹ�ʵ��Ŀ��");
	return 0;
}