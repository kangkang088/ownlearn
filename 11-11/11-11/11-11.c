#define _CRT_SECURE_NO_WARNINGS 1
#include<stdio.h>
//下标引用操作符
//int main()
//{
//	int arr[10] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//	printf("$d\n", arr[4]);//[]就是下标引用操作符
//	//[]的操作数是两个：arr和[]。
//	return 0;
//}


//函数调用操作符
//函数定义
//int Add(int x, int y)
//{
//	return x + y;
//}
//void test()
//{}
//int main()
//{
//	int a = 10;
//	int b = 20;
//	//函数调用
//	int ret = Add(a, b);//（）就是函数调用操作符。没有就不是函数调用。（）三个操作数，有参数
//	text();//（）操作数只有一个test，无参数
//	return 0;
//}



//结构成员访问操作符
//struct BOOK
//{
//	//结构体成员
//	char name[20];
//	char id[20];
//	int price;
//
//};
//int main()
//{
//	struct BOOK b = {"c语言","05151",55};
//	struct BOOK* pb = &b; //创建一个结构体类型的指针
//	//结构体变量名.成员名
//	printf("书名：%s\n", b.name); //b可以换成（*pb）
//	printf("书号：%s\n", b.id);
//	printf("定价：%d\n", b.price);
//
//	//结构体指针->成员名
//	printf("书名：%s\n", pb->name);
//	printf("书号：%s\n", pb->id);
//	printf("定价：%d\n", pb->price);
//	return 0;
//}



//int main()
//{
//	char a = 3;
//	//00000011
//	char b = 127;
//	//01111111
//	char c = a + b;
//	//a和b都是char类型的，都没有达到一个int的大小
//	//发生整型提升
//	//按变量的数据类型的符号位进行整型提升，有符号数，正数补0，负数补1. 无符号数，看成正数，补0.
//	//00000000000000000000000000000011 -a
//	//00000000000000000000000001111111 -b
//	//00000000000000000000000010000010 -c
//	//截断
//	//10000010 -c（补码）
//
//	//c是有符号char，则最高位是符号位，则c是负数
//	
//	printf("%d\n", c);//-126,
//	//要整型提升为int的大小，再输出
//	//11111111111111111111111110000010（补码）
//	//11111111111111111111111110000001（反码）
//	//10000000000000000000000001111110（原码）
//	//-126
//	return 0;
//}



//int main()
//{
//	char c = 1;
//	printf("%d\n", sizeof(c));//括号内没有参与运算
//	printf("%d\n", sizeof(+c));//参与运算，整型提升，变为int
//	printf("%d\n", sizeof(-c));
//	return 0;
//}



//int main()
//{
//	char a = 0xb6;  
//	short b = 0xb600;//如果是0xb60，在short的取值范围内，则截断的时候不会有影响，会输出b
//	int c = 0xb6000000;
//	if (a == 0xb6)  //运算，整型提升，0xb6超出范围，截断有影响
//	{
//		printf("a");
//	}
//	if (b == 0xb600)//运算，整型提升，0xb600超出范围，截断有影响.如果把b变为无符号类型，则0xb600会进入范围，截断无影响
//	{
//		printf("b");
//	}
//	if (c == 0xb6000000)//运算，无整型提升.如果加几个0超出范围，int类型范围不满足，但也不会整型提升，c不会输出。整型提升只对int大小以下的类型
//	{
//		printf("c");
//	}
//	return 0;
//}

 

//创建一个整型数组，完成对数组的操作
//1.实现函数init（），初始化数组全为0
//2.实现print（），打印数组的每个元素
//3.实现reverse（）函数完成数组元素的逆置
//void init(int arr[],int sz)
//{
//	int i = 1;
//	for (i = 0; i < sz; i++)
//	{
//		arr[i] = 0;
//	}
//}
//void print(int arr[], int sz)
//{
//	int i = 0;
//	for (i = 0; i < sz; i++)
//	{
//		printf("%d ", arr[i]);
//	}
//	printf("\n");
//}
//void reverse(int arr[], int sz)
//{
//	int left = 0;
//	int right = sz-1;	
//	while (left < right)
//	{
//		int tmp = arr[left];
//		arr[left] = arr[right];
//		arr[right] = tmp;
//		left++;
//		right--;
//	}
//}
//int main()
//{
//	int arr[10] = { 1,2,3,4,5,6,7,8,9,10 };
//	int sz = sizeof(arr) / sizeof(arr[0]);
//	reverse(arr, sz);
//	print(arr, sz);
//	init(arr,sz);
//	print(arr, sz);
//	return 0;
//}




//交换数组A和数组B中的内容，假设数组一样大。
//void swap(int A[], int B[], int sz)
//{
//	int i = 0;
//	for (i = 0; i < sz; i++)
//	{
//		int c = A[i];
//		A[i] = B[i];
//		B[i] = c;
//	}
//}
//void print(int A[], int sz)
//{
//	int i = 0;
//	for (i = 0; i < sz; i++)
//	{
//		printf("%d ", A[i]);
//	}
//}
//int main()
//{
//	int A[10] = { 5, 7, 8, 4, 9, 1, 6, 16, 4, 54 };
//	int B[10] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//	int sz = sizeof(A) / sizeof(A[0]);
//	swap(A, B, sz);
//	print(A, sz);
//	printf("\n");
//	print(B, sz);
//	return 0;
//}
//int main()
//{
//	int arr1[] = { 1, 3, 5, 7, 9 };
//	int arr2[] = { 2, 4, 6, 8, 10 };
//	int sz = sizeof(arr1) / sizeof(arr1[0]);
//	int i = 0;
//	for (i = 0; i < sz; i++)
//	{
//		int tmp = arr1[i];
//		arr1[i] = arr2[i];
//		arr2[i] = tmp;
//	}
//	for (i = 0; i < sz; i++)
//	{
//		printf("%d ", arr1[i]);
//	}
//	printf("\n");
//	for (i = 0; i < sz; i++)
//	{
//		printf("%d ", arr2[i]);
//	}
//	return 0;
//}


int main()
{

	return 0;
}