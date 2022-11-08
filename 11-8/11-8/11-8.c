#define _CRT_SECURE_NO_WARNINGS 1
#include <stdio.h>
#include<string.h>
//int main() {
//	int i = 0;
//	int sum = 0;
//	int arr[] = { 0 };
//	scanf("%d", &i);
//	while (i)
//	{
//		arr[sum] = i % 6;
//		sum++;
//		i = i / 6;
//	}
//	for (sum--; sum >= 0; sum--)
//	{
//		printf("%d", arr[sum]);
//	}
//	return 0;
//}


//int main()
//{
//	//创建一个数组-10个整型
//	int arr[10];
//	//字符型
//	char arr2[5];
//	return 0;
//}



//int main()
//{
//	char arr1[] = "abc";
//	char arr2[] = { 'a', 'b', 'c' };
//	printf("%d\n", sizeof(arr1));
//	printf("%d\n", sizeof(arr2));
//	printf("%d\n", strlen(arr1));
//	printf("%d\n", strlen(arr2));
//	return 0;
//}



//int main()
//{
//	//int i = 0;
//	//char arr[] = "abcdef";
//	//printf("%c\n", arr[3]);
//	/*for (i = 0; i <= 5; i++)
//	{
//		printf("%c\n", arr[i]);
//	}*/
//
//
//
//
//
//	int arr[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//	int i = 0;
//	int sz = sizeof(arr) / sizeof(arr[0]);
//	for (i = 0;i < sz;i++)
//	{
//		printf("%d\n", arr[i]);
//	}
//
//	return 0;
//}





//int main()
//{
//	int i = 0;
//	int arr[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//	int sz = sizeof(arr) / sizeof(arr[0]);
//	for (i = 0; i < sz; i++)
//	{
//		printf("&arr[%d] = %p\n",i, &arr[i]); //每个地址差四。结论：数组在内存中连续存在
//	}
//	return 0;
//}


//int main()
//{
//	int arr[][4] = { { 1, 2, 3 },{ 4, 5 } };//二维数组行可以省略，列不能省略。
//
//	return 0;
//}



//int main()
//{
//	int arr[3][4] = { { 1, 2, 3 }, { 4, 5 } };//二维数组行可以省略，列不能省略。
//	int i = 0;
//	for (i = 0; i < 3; i++)
//	{
//		int j = 0;
//		for (j = 0; j < 4; j++)
//		{
//			printf("%d", arr[i][j]);//访问元素，锁定行列。
//		}
//		printf("\n");
//	}
//	return 0;
//}


//int main()
//{
//	int arr[3][4] = { { 1, 2, 3 }, { 4, 5 } };//二维数组行可以省略，列不能省略。
//	int i = 0;
//	for (i = 0; i < 3; i++)
//	{
//		int j = 0;
//		for (j = 0; j < 4; j++)
//		{
//			printf("&arr[%d][%d]=%p\n",i,j, arr[i][j]);  
//		}
//		printf("\n");
//	}
//	return 0;
//}



//冒泡排序（无论是否本身是升序，都会一次一次的排。不完美，效率低）
//void bubble_sort(int arr[],int sz)
//{
//	//确定冒泡排序的趟数
//	int i = 0;
//	for (i = 0; i < sz - 1; i++)
//	{
//		//每一趟冒泡排序的内容。
//		int j = 0;
//		for (j = 0; j < sz-1-i; j++) //确定每一趟比较的对数。
//		{
//			if (arr[j]> arr[j + 1])
//			{ 
//				int temp = arr[j];
//				arr[j] = arr[j + 1];
//				arr[j + 1] = temp;
//			}
//		}
//	}
//}
//int main()
//{
//	int i = 0;
//	int arr[] = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
//	int sz = sizeof(arr) / sizeof(arr[0]);
//	bubble_sort(arr,sz); //冒泡排序函数
//	for (i = 0; i < sz; i++)
//	{
//		printf("%d ", arr[i]);
//	}
//	return 0;
//}


//冒泡排序（如果已经有序（升序），那么结束。）
//void bubble_sort(int arr[], int sz)
//{
//	//确定冒泡排序的趟数
//	int i = 0;
//	for (i = 0; i < sz - 1; i++)
//	{
//		//每一趟冒泡排序的内容。
//		int j = 0;
//		int flag = 1;//假设已经有序（升序），
//		for (j = 0; j < sz - 1 - i; j++) //确定每一趟比较的对数。
//		{
//			if (arr[j]> arr[j + 1])
//			{
//				int temp = arr[j];
//				arr[j] = arr[j + 1];
//				arr[j + 1] = temp;
//				flag = 0;//本趟排序的数据其实不是完全有序的。
//			}
//		}
//		if (flag == 1)
//		{
//			break;
//		}
//	}
//}
//int main()
//{
//	int i = 0;
//	int arr[] = { 0,1,2,3,4,5,6,7,8,9 };
//	int sz = sizeof(arr) / sizeof(arr[0]);
//	bubble_sort(arr, sz); //冒泡排序函数
//	for (i = 0; i < sz; i++)
//	{
//		printf("%d ", arr[i]);
//	}
//	return 0;
//}


//int main()
//{
//	int arr[] = { 1, 2, 3, 4, 5, 6, 7 };
//	printf("%p\n", arr);
//	printf("%p\n", &arr[0]);
//	//数组名就是首元素地址
//	printf("%d\n", *arr);
//	return 0;
//}


//int main()
//{
//	int arr[] = { 1, 2, 3, 4, 5, 6, 7 };
//	int sz = sizeof(arr) / sizeof(arr[0]);
//	//1.sizeof(数组名)  -数组名表示整个数组，sizeof（数组）计算的是整个数组的大小，单位是字节。
//	
//	
//	
//	
//	printf("%p\n", arr);//arr+1，差4
//	printf("%p\n", &arr[0]); //&arr[0]+1，差4
//	printf("%p\n", &arr);//和第一个元素的地址相同，但有区别。代表的是整个数组的大空间（包括所有数组元素的空间）地址，这里&arr+1,如果数组七个整型元素，则地址+28.
//	//2.&数组名 -数组名代表整个数组，取出的是整个数组的地址
//
//
//	//printf("%p\n", arr);
//	//printf("%p\n", &arr[0]);
//	////数组名就是首元素地址
//	//printf("%d\n", *arr);
//	return 0;
//}


int main()
{

	return 0;
}