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

int main()
{
	int arr[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
	int sz = sizeof(arr) / sizeof(arr[0]);
	int lefet = 0;//左下标
	int right = sz - 1;//右下标
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
			printf("找到了，下标是：%d\n", mid);
			break;
		}
	}
	if (lefet>right)
	{
		printf("找不到\n");
	}

	return 0;
}