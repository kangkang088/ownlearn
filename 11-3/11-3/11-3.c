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
//	for (i = 1; i <= 10; i++)   //初始或，  判断，    调整
//	{
//		if (i == 5)
//			continue;    //这个时候不会死循环，continue结束后面语句后，跳到i++，继续调整，与while不同
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
//			continue;   //这个时候会死循环，结束了包括i++；无法调整
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
//			printf("hehe\n");    //死循环
//		printf("hhah\n");
//	}
//	return 0;
//}
//
//i=0，i<10,前闭后开


//int main()
//{
//	for (;;)             //for循环的初始化 调整  判断都可以省略。但判断部分被省略，则说明判断条件恒为真，一直死循环。
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
//		for (j = 0; j < 10; j++)   //i=0;j=0省略的话，只会输出10个，10次之后，j变为10，i = 2进入的时候，j依然是10，不会进入第二个for
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

//优化
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
//	//写一个代码，在arr数组（有序的）中找到7；
//	int i = 0;
//	int sz = sizeof(arr) / sizeof(arr[0]);
//
//	for (i = 0; i < sz; i++)
//	{
//		if (k == arr[i])
//		{
//			printf("找到了，下标是：%d\n", i);
//			break;
//		}
//	}
//	if (i == sz)
//		printf("找不到\n");
//	return 0;
//}

//int main()
//{
//	int arr[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//	int sz = sizeof(arr) / sizeof(arr[0]);
//	int lefet = 0;//左下标
//	int right = sz - 1;//右下标
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
//			printf("找到了，下标是：%d\n", mid);
//			break;
//		}
//	}
//	if (lefet>right)
//	{
//		printf("找不到\n");
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
//	/*int right = sizeof(arr1) / sizeof(arr1[0]) - 2;*/    //字符串后面有\0
//	int right = strlen(arr1)-1;
//	while (left<=right)
//	{
//		arr2[right] = arr1[right];
//		arr2[left] = arr1[left];
//		printf("%s\n", arr2);
//		Sleep(1000);   //休息1秒；头文件#include <windows.h>
//		system("cls"); //执行系统命令的一个函数  - cls-清空屏幕；  #include <stdlib.h>
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
//		printf("请输入密码：");
//		scanf("%s", password);
//		if (strcmp(password, "123456") == 0)  //等号不能用来判断两个字符串是否相等，应该用库函数strcmp
//		{
//			printf("登陆成功\n");
//			break;
//		}
//		else
//			printf("密码错误");
//	}
//	if (i == 3)
//		printf("三次密码，均错误，退出程序");
//	return 0;
//}


//int main()
//{
//	int i = 0;
//	char password[20] = { 0 };
//	for (i = 0; i < 5; i++)
//	{
//		printf("请输入密码：");
//		scanf("%s", password);
//		if (strcmp(password, "123456") == 0)
//		{
//			printf("密码正确\n");
//			break;
//		}
//		else
//		{
//			printf("密码错误\n");
//		}
//	}
//	if (i == 5)
//		printf("五次密码均错误，程序退出。\n");
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


//写三个数，从大到小输出
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


//打印三的倍数（1-100）

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


//最大公约数 （给两个数，求最大公约数）  辗转相除法

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


//打印1000 - 2000之间的闰年

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


//打印1000-2000之间的素数

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
//			printf("素数：%d\n", i);
//		}
//	}
//	printf("%d\n", count);
//	return 0;
//}



//优化
//优化
//一个数 m = a*b  ，那么a b中必定有一个是小于m的开平方，一个大于m的开平方
//判断素数，从2到n-1一直判断能不能整除，很麻烦
//判断素数，可以只判断2-开平方该数这个范围，如果这个范围没有，那开平方该数-n-1之间也一定没有
//开平方函数sqrt（）   库函数#include <math.h>
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
//			printf("素数：%d\n", i);
//		}
//	}
//	printf("%d\n", count);
//	return 0;
//}


//继续优化
//偶数不可能是素数
//只求奇数
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
//			printf("素数：%d\n", i);
//		}
//	}
//	printf("%d\n", count);
//	return 0;
//}


//《素数求解n中境界》




