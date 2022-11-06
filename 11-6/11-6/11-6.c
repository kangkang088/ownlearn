#define _CRT_SECURE_NO_WARNINGS 1
#include <stdio.h>
#include <string.h>

// int Run(int x)
//{
//	if (x % 4 == 0 && x % 100 != 0)
//	{
//		return 1;
//	}
//	else if (x % 400 == 0)
//	{
//		return 1;
//	}
//	else
//	{
//		return 0;
//	}
//}


 //判断输入的是否为闰年
//int main()
//{
//	int i = 0;
//	printf("请输入所要判断的年份：");
//	scanf("%d", &i);
//	if (1 == Run(i))
//	{
//		printf("是闰年\n", i);
//	}
//	else
//	{
//		printf("不是闰年\n", i);
//	}
//	return 0;
//}


//判断1000-2000年的闰年并打印
//int main()
//{
//	int year = 0;
//	for (year = 1000; year <= 2000; year++)
//	{
//		if (1 == Run(year))
//		{
//			printf("%d\n", year);
//		}
//	}
//	return 0;
//}


				//地址传过来，本质上这里的arr[]是个指针
//int binary_search(int arr[],int x,int sz)
//{
//	int left = 0;
//	int right = 0;
//	//int sz = 0;
//	int mid = 0;
//	//sz = sizeof(arr) / sizeof(arr[0]);  //传数组的时候，其实传的是数组首元素的地址，就是传过去一个指针，32位指针大小是4字节，整型也是4字节，则sz=1.
//	left = 0;
//	right = sz - 1;
//	while (left<=right)
//	{
//		mid = (left + right) / 2;   //不能放到循环外面，每一次二分查找都要求一次中间下标。
//		if (arr[mid] < x)
//		{
//			mid++;
//			left = mid;
//
//		}
//		else if (arr[mid]>x)
//		{
//			right--;
//			right = mid;
//
//		}
//		else
//		{
//			return mid;
//		}
//	}
//	if (right < left)
//	{
//		return -1;
//	}
//}
//int main()
//{
//	int  arr[] = {1,2,3,4,5,6,7,8,9,10};
//	int sz = 0;
//	int k = 7;
//	sz = sizeof(arr) / sizeof(arr[0]); //注意先在外面求出数组的大小即可。
//	int ret = binary_search(arr,k,sz);//传递过去的arr是数组首元素的地址
//	if (ret == -1)
//	{
//		printf("找不到");
//	}
//	else
//	{
//		printf("找到了，下标是：%d\n", ret);
//	}
//	return 0;
//}


//写一个函数，用该函数一次，num值加一
//void add(int* x)
//{
//	*x=(*x)++;  //必须加括号，因为++的优先级比*高。
//}
//int main()
//{
//	int num = 0;
//		add(&num);//num是函数外部变量，要在函数内部改变并输出，即将形参和实参建立起联系，用传址调用。
//		printf("%d\n", num);
//		add(&num);
//		printf("%d\n", num);
//		add(&num);
//		printf("%d\n", num);
//		add(&num);
//		printf("%d\n", num);
//		add(&num);
//		printf("%d\n", num);
//		add(&num);
//		printf("%d\n", num);
//	return 0;
//}


//嵌套调用
//void add2()
//{
//	printf("hehe\n");
//}
//void add1()
//{
//	int i = 0;
//	for (i = 0; i < 3; i++)
//	{
//		add2();
//	}
//}
//int main()
//{
//	add1();
//	return 0;
//}


//int main()
//{
//	int len = 0;
//	//1
//	len = strlen("abc");
//	printf("%d\n", len);
//	//2  链式访问
//	printf("%d\n", strlen("abc"));
//
//	return 0;
//}
int main()
{
	printf("%d", printf("%d", printf("%d", 43)));
//结果是4321.函数接收的是返回值，不是打印的值，printf函数的返回值是打印的字符的个数。
//最内层打印43，返回值为2，则中间层打印2，返回值为1，最左打印1，最终结果为4321.
	return 0;
}