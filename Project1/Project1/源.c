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
//
//%d��ʾ��������ŵ�ʮ������������
//
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
//
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
///*int main()
//{
//	printf("��н100��,��Ҫ�ô���ʮ����\n");
//	int i = 0;
//	while (i <100000)
//	{
//		i++;
//		printf("%d\n", i);
//		
//	}
//	printf("�ɹ�ʵ��Ŀ��");
//	return 0;
//}*/
//register
//signed
//unsigned
//typedef ���Ͷ��壬�ֽ������ض���
//int main()
//{
//	typedef  signed int s_int;
//		int a = 5;
//		s_int b = 5;
//		//typedef unsigned int u_int;
//	//unsigned int num = 20;
//	//u_int num2 = 58;
//	return 0;
//}
//void chance()
//{
//	 static int a = 0;//��ʱ�ֲ�����a���������ڱ䳤��
//	a++;
//	printf("%d\n", a);
//}
//int main()
//{
//static���ξֲ�������ʹ���������ڱ䳤������ȫ�ֱ����������������С��ֻ�����Լ����ڵ��ļ����ڲ�ʹ�á�
//	int i = 0;
//	while (i < 5)
//	{
//		chance();
//		i++;
//	}
//	return 0;
//}
//
//int main()
//{
//	extern int g_val;//extern�������ⲿ���ŵģ�
//	printf("%d\n", g_val);//static ����Դ2�е�ȫ�ֱ�������ʱ����
//	return 0;
//}
///*extern int Add(int, int);*///static ���κ���Ҳ��ı������򣨲�׼ȷ��˵��������ʵ�Ǹı��˺������������ԣ�
//��ͨ���������ⲿ�������ԣ������static���Σ������Ի��Ϊ�ڲ��������ԡ�
//int main()
//{
//	int a = 50;
//	int b = 65;
//	int sum = Add(a, b);
//	printf("%d\n", sum);
//	return 0;
//}
//#define MAX 100//#define����ı�ʶ������
////#define���Զ���ꡪ����
//int main()
//{
//	int a = MAX;
//	return 0;
//}
//�����ķ���
//int MAX(int x, int y)
//{
//	if (x > y)
//		return x;
//	else
//		return y;
//}
////��Ķ��巽ʽ
//#define MAX(X,Y) (X>Y?X:Y)
//int main()
//{
//	int a = 84;
//	int b = 45;
//	//����
//	int c = MAX(a, b);
//	printf("%d\n", c);
//	//��
//	c = MAX(a, b);
//	printf("%d\n", c);
//	return 0;
//}
//int main()
//{
//	int a = 10;
//	printf("%p\n", &a);//���a�ĵ�ַ    &ȡ��ַ������    a&b,��λ��    |��λ��    ^��λ���    ~��λȡ��
//	int *p = &a;
//	printf("%p\n", p);//ָ�����p������ŵ�ַ��*�ǽ����ò�������*p��ָ����p�еĵ�ַ���н����ã��ҵ��õ�ַ��Ӧ�ı���a��
//	//��ʱ*p�ҵ�������*p = 20���������Ϊ20��
//	*p = 20;
//	printf("%d\n", a);//a��Ϊ20
//	char arr = 'A';
//	printf("%p\n", &arr);
//	char *pt = &arr;
//	*pt = 'K';
//	printf("%c\n", arr);
//	return 0;
//}
int main()
{
	int a = 50;
	int* p = &a;
	printf("%p\n", &a);
	*p = 15;
	printf("%d\n", a);
	printf("%d\n", sizeof(p));
	return 0;
}