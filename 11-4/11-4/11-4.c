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


//求1-100之间9的个数
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
//		sum += flag * 1.0 / i;  //要想得到分数，/两边必须哟一个浮点数，不然都是整数的话，只会得到零
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


//十个数里面的最大数

//10个整数中的最大值
//int main()
//{
//	int arr[10] = { 1.2,3,4,5,6,7,8,9,10 };
//	int i = 0;
//	int max = arr[0];  //必须假设是数组里面的，如果数组里面全是负数，而max = 0；那最后会输出0；而不是数组里面的数
//	int sz = sizeof(arr) / sizeof(arr[0]);
//	for (i = 1; i < sz; i++)   //假设后，从第二个开始比较
//	{
//		if (arr[i]>max)
//		{
//			max = arr[i];
//		}
//	}
//	printf("%d\n", max);
//	return 0;
//}

//输出9*9乘法口诀表

//int main()
//{
//	int i = 0;
//	for (i = 1; i <= 9; i++)
//	{
//		int j = 1;
//		for (j = 1; j <= i; j++)
//		{
//			printf("%d*%d=%-2d ", i, j, i*j);//%2d,右对齐，%-2d，左对齐  2d后面不加空格，一堆数挨着。
//		}
//		printf("\n");
//	}
//	return 0;
//}

//二分查找
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
//			printf("找到了，下表是：%d\n", mid);
//			break;
//		}
//	}
//	if (left > right)
//	{
//		printf("找不到\n");
//	}
//	return 0;
//}

//猜数字游戏
//程序启动，生成一个随机数
//猜数字
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
//	//1.生成一个随机数 
//	//2.猜数字
//	//rand();专门生成随机数的
//	int ret = 0 ;
//	int guess = 0;
//	int num = 0;
//	
//		ret = rand()%100+1;//1-100之间；
//		while (1)
//		{
//			printf("猜数字");
//				scanf("%d", &guess);
//				getchar();//防止输入字母出现死循环。
//				if (guess > ret)
//				{
//					num++;
//					printf("猜大了\n");
//				}
//				else if (guess < ret)
//				{
//					num++;
//					printf("猜小了\n");
//				}
//				else
//				{
//					printf("猜对了\n");
//					break;
//				}
//				if (num >= 10)
//				{
//					printf("很遗憾，机会已用完，游戏结束\n");
//					break;
//				}
//		}
//
//}
//int main()
//{
//	srand((unsigned int)time(NULL));//函数rand()用来生成随机数，但rand（）为了出随机数，必须前面使用srand（），去设置随机数生成器
//	//srand会随机生成一个起点，别设置在循环里面，不然起点每次都重置。里面的整型要一直变，即随机值，但我们为了生成随机数引用srand，但是现在又需要随机数，死循环。我们只要一个一直变化的整型。即时间戳。看上面
//	//拿时间戳来设置随机数的生成起点；
//	//time_t   time(time_t* timer)
//	//time_t  //对long重定义得到的，时间戳本质是长整型
//	//时间戳  当前计算机的时间，减去计算机的起始时间（1970.1.1  0：0：00）=？秒；
//	int input = 0;
//	do
//	{
//		menu();
//		printf("请选择");
//		scanf("%d", &input);
//		switch (input)
//		{
//		case 1:
//			game();
//			break;
//		case 0:
//			printf("退出游戏\n");
//			break;
//		default:
//			printf("选择错误\n");
//			break;
//		}
//	} while (input);
//	return 0;
//}

void menu()
{
	printf("*****************************\n");
	printf("**     1.开始 0. 结束      **\n");
	printf("*****************************\n");
}
void game()
{
	int guess = 0;
	int ret = 0;
	ret = rand() % 100 + 1;	
	printf("开始猜数字：");
	while (1)
	{
		scanf("%d", &guess);  //每次猜都要输入一次，所以在循环里面，如果在外面，只会输入一次。
		if (guess < ret)
		{
			printf("猜小了\n");
		}
		else if (guess>ret)
		{
			printf("猜大了\n");
		}
		else
		{
			printf("恭喜您，猜对了\n");
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
		scanf("%d", &input);//要在循环里面，如果在外面，当你第一次输入1，进入猜数字游戏，直到你猜对，程序直接跳到继续下一轮猜数字，不会询问你是否用1/0确认是否继续游戏。
		switch (input)
		{
		case 1:
			game();
			break;
		case 0:
			printf("退出游戏\n");
			break;
		default:
		{
				   printf("输入错误\n");
				   break;
		}
		}
	} while (input);
	return 0;
}

// goto语句
