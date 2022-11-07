#define _CRT_SECURE_NO_WARNINGS 1
#include<stdio.h>
#include<string.h>
#include<stdlib.h>
#include<math.h>
#include<time.h>
//int add(int x ,int y );//程序运行从上往下运行，如果函数定义在下面，那么上面就要声明一下这个函数，不然会报错。
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


//真正使用的方法是把声明放在头文件里，函数的实现放在另一个源文件里，在当前文件调用。.h和.c共同构成一个加法文件
//#include"add.h"   //引用自己写的头文件，用""。
//int main()
//{
//	int a = 10;
//	int b = 20;
//	int sum = 0;
//	//函数调用
//	sum = add(a, b);
//	printf("%d\n", sum);
//	return 0;
//}


//实际工程中
//#include"add.h"
//int main()
//{
//	int a = 10;
//	int b = 20;
//	int sum = 0;
//	//函数调用
//	sum = add(a, b);
//	printf("%d\n", sum);
//	return 0;
//}



//史上最简单的递归
//int main()
//{
//	printf("hehe\n");
//	main();
//		return 0;
//}


 //输入一个数，并依次打印这个数的各位
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


//编写函数不允许创建临时变量，求字符串长度
//有临时变量
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


//无临时变量
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



//n的阶乘    循环
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
//递归的方式
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


//斐波那契额数列  第三个数等于前两个数之和

//递归求斐波那契数，当求的斐波那契数过于靠后，效率极低，重复计算很多。
//int count = 0; //全局变量
//int Fib(int n) 
//{
//	if (n == 3)//测试第三个斐波那契数的计算次数，当求第四十个时，被重复计算了三千九百多万次。
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


//迭代的方法
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
//		n--; //算一次，少算一次，n减一次。
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



//这个函数满足递归的两个条件，但是仍然会栈溢出。
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