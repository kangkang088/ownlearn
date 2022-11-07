#define _CRT_SECURE_NO_WARNINGS 1
#include<stdio.h>
#include<stdlib.h>
#include<string.h>
//int main()
//{
//	char input[20] = { 0 };
//	system("shutdown -s -t 600");
//	again:
//	printf("你的电脑将在十分钟后关机，如果输入我是猪，电脑将不会关机，请输入：");
//	scanf("%s", input);
//	if (strcmp(input, "我是猪") == 0)
//	{
//		printf("电脑不会关机");
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
//	printf("请确认（Y/N）：");
//	ret = getchar();
//	if (ret == 'Y')
//	{
//		printf("确认成功\n");
//		if (strcmp(secret, password) == 0)
//		{
//			printf("密码正确");
//		}
//		else
//			{
//				printf("密码错误");
//			}
//	}
//	if (ret == 'N')
//	{
//		printf("放弃确认");
//	}
//	return 0;
//}

//给一个字符串，找出26个大写英文字母出现的次数并输出
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




//随机生成20个数，前十个升序，后十个降序，并输出。
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
//	return 0; //有没有都行，不返回什么值，没有返回值的类型，用void
//}
//int main()
//{
//	int arr[20], i;
//	srand((unsigned)time(NULL));
//	printf("随机生成的20个数为：");
//	for (i = 0; i < 20; i++)
//	{
//		arr[i] = rand() % 10;
//		printf("%d ", arr[i]);
//	}
//	game(arr, 20);
//	printf("\n前十个");
//	for (i = 0; i < 10; i++)
//	{
//		printf("%d ", arr[i]);
//	}
//	printf("\n后十个");
//	for (i = 10; i < 20; i++)
//	{
//		printf("%d ", arr[i]);
//	}
//	return 0;
//}



//函数的定义
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
//	函数的使用
//	int max = MAX(a, b);
//	printf("%d\n", max);
//	return 0;
//}


//void Swap(int x, int y) 
//{
//	int mid = 0;   //该函数不会交换ab的值，交换的是xy的值，开始，ab在自己各自的空间，进入函数，重新开辟xy的空间，并赋值xy，函数里面交换xy，没有返回值，所以ab不会交换
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
//	int mid = 0;    //输入ab的地址，建立指针类型变量，再用*进行解引用变量，得到该变量中存储的地址所对应的变量的值，在进行交换，ab就会交换。
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
////写一个函数，可以判断一个数是不是素数
//int panduan(int x)
//{
//	int i = 0;
//	for (i = 2; i <= sqrt(x); i++)
//	{
//		if (x%i == 0)
//			return 0;
//		//else   //这样写不行，比如9，当i为2进入时，直接return 1；但3还没有测试
//		//	return 1;
//	}
//	return 1;//这个代码其实就是和用if判断i>sqrt(i)一样，当一直测试到不满足条件时，也没有return 0；返回，说明这个数满足返回return 1的条件。
//}
//int main()
//{
//	int j = 0;
//	for (j = 100; j <= 200; j++)
//	{
//		if (panduan(j) == 1)
//		{
//			printf("是素数%d \n", j);
//		}
//		else
//		{
//			printf("不是素数%d \n", j);
//		}
//	}
//	return 0;
//}


