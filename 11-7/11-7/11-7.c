#define _CRT_SECURE_NO_WARNINGS 1
#include<stdio.h>
#include<string.h>
#include<stdlib.h>
#include<math.h>
#include<time.h>
//int add(int x ,int y );//�������д����������У�����������������棬��ô�����Ҫ����һ�������������Ȼ�ᱨ��
//int main()
//{
//	int a = 10;
//	int b = 20;
//	int sum = 0;
//	sum = add(a, b);
//	printf("%d\n", sum);
//	return 0;
//}
//int add(int x, int y)
//{
//	int z = x + y;
//	return z;
//}


//����ʹ�õķ����ǰ���������ͷ�ļ��������ʵ�ַ�����һ��Դ�ļ���ڵ�ǰ�ļ����á�.h��.c��ͬ����һ���ӷ��ļ�
//#include"add.h"   //�����Լ�д��ͷ�ļ�����""��
//int main()
//{
//	int a = 10;
//	int b = 20;
//	int sum = 0;
//	//��������
//	sum = add(a, b);
//	printf("%d\n", sum);
//	return 0;
//}


//ʵ�ʹ�����
//#include"add.h"
//int main()
//{
//	int a = 10;
//	int b = 20;
//	int sum = 0;
//	//��������
//	sum = add(a, b);
//	printf("%d\n", sum);
//	return 0;
//}



//ʷ����򵥵ĵݹ�
//int main()
//{
//	printf("hehe\n");
//	main();
//		return 0;
//}


 //����һ�����������δ�ӡ������ĸ�λ
//void print(int n)
//{
//	if (n > 9)
//	{
//		print(n / 10);
//	}
//	printf("%d ", n % 10);
//}
//int main()
//{
//	unsigned int num = 0;
//	scanf("%d", &num);
//	print(num);
//}


//��д��������������ʱ���������ַ�������
//����ʱ����
//int my_strlen(char* str)
//{
//	 int count = 0;
//	 while(*str != '\0')
//	 {
//		 count++;
//		 str++;
//	 }
//	 return count;
//}
//int main()
//{
//	char arr[] = "bit";
//	int len = my_strlen(arr);
//	printf("len = %d\n", len);
//	return 0;
//}


//����ʱ����
//int my_strlen(char* str)
//{
//	if (*str != '\0')
//		return 1 + my_strlen(str + 1);
//	else
//		return 0;
//}
//int main()
//{
//	char arr[] = "bit";
//	int len = my_strlen(arr);
//	printf("len = %d\n", len);
//	return 0;
//}



//n�Ľ׳�    ѭ��
//int Fac(int n)
//{
//	int i = 0;
//	int ret = 1;
//	for (i = 1; i <= n; i++)
//	{
//		ret *= i;
//	}
//	return ret;
//}
//int main()
//{
//	int n = 0;
//	int ret = 0;
//	scanf("%d", &n);
//	ret = Fac1(n);
//	printf("%d\n", ret);
//	return 0;
//}
//�ݹ�ķ�ʽ
//int Fac2(int n)
//{
//	if (n <= 1)
//	{
//		return 1;
//	}
//	else
//	{
//		return n*Fac2(n - 1);
//	}
//}
//int main()
//{
//	int n = 0;
//	int ret = 0;
//	scanf("%d", &n);
//	ret = Fac2(n);
//	printf("%d\n", ret);
//	return 0;
//}


//쳲�����������  ������������ǰ������֮��

//�ݹ���쳲��������������쳲����������ڿ���Ч�ʼ��ͣ��ظ�����ܶࡣ
//int count = 0; //ȫ�ֱ���
//int Fib(int n) 
//{
//	if (n == 3)//���Ե�����쳲��������ļ���������������ʮ��ʱ�����ظ���������ǧ�Űٶ���Ρ�
//	{
//		count++;
//	}
//	if (n <= 2)
//		return 1;
//	else
//	{
//		return Fib(n - 1) + Fib(n - 2);
//	}
//}
//int main()
//{
//	int n = 0;
//	int ret = 0;
//	scanf("%d", &n);
//	ret = Fib(n);
//	printf("ret = %d\n", ret);
//	printf("%d\n", count);
//	return 0;
//}


//�����ķ���
//int Fib(int n)
//{
//	int a = 1;
//	int b = 1;
//	int c = 1;
//	while (n > 2)
//	{
//		c = a + b;
//		a = b;
//		b = c;
//		n--; //��һ�Σ�����һ�Σ�n��һ�Ρ�
//	}
//	return c;
//}
//int main()
//{
//	int n = 0;
//	int ret = 0;
//	scanf("%d", &n);
//	ret = Fib(n);
//	printf("ret = %d\n", ret);
//	return 0;
//}



//�����������ݹ������������������Ȼ��ջ�����
void test(int n)
{
	if (n < 10000)
	{
		test(n + 1);
	}
}
int main()
{
	test(1);
	return 0;
}