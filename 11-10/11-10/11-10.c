#define _CRT_SECURE_NO_WARNINGS 1
#include<stdio.h>
//算术操作符 + - * / %
//int main()
//{
//	int a = 3 / 5; //0.6
//	printf("%d\n", a);//得到的是0，/ 只会得到整数
//	return 0;
//}
//int main()
//{
//	float a = 3.0f / 5; //0.6
//	printf("%f\n", a);
//	return 0;
//}
//int main()
//{
//	int  a = 7 % 3; //两端必须是整数
//	printf("%d\n", a);
//	return 0;
//}



//左移操作符
//int main()
//{
//	int a = 2;
//	//把a的二进制位向左移动一位
//	//00000000000000000000000000000010  变成  00000000000000000000000000000100
//	int b = a << 1;
//	printf("%d\n", b);
//	return 0;
//}
//右移操作符
//右移1.算术右移  左边补原符号位
//2.逻辑右移  左边补零
//int main()
//{
//	int a = -1;
//	//把a的二进制位向左移动一位
//	//10000000000000000000000000000001  反码  11111111111111111111111111111110  补码  11111111111111111111111111111111
//  算术右移则：11111111111111111111111111111111（补码）    逻辑右移则：01111111111111111111111111111111（补码）
//	int b = a >> 1;
//	printf("%d\n", b);
//	输出的是-1，说明是算术右移
//	return 0;
//}
//移位不会改变原变量的值



//位操作符  & | ^
//二进制位操作（补码）
//int main()
//{
//	int a = 3;
//	int b = 5;
//	int c = a&b;
//	//00000000000000000000000000000011	3
//	//00000000000000000000000000000101	5
//	//00000000000000000000000000000001  1
//	printf("%d\n", c);
//	return 0;
//}
//int main()
//{
//	int a = 3;
//	int b = 5;
//	int c = a | b;
//	//00000000000000000000000000000011	3
//	//00000000000000000000000000000101	5
//	//00000000000000000000000000000111  7
//	printf("%d\n", c);
//	return 0;
//}
//int main()
//{
//	int a = 3;
//	int b = 5;
//	int c = a^b;
//	//00000000000000000000000000000011	3
//	//00000000000000000000000000000101	5
//	//00000000000000000000000000000110  6
//	printf("%d\n", c);
//	return 0;
//}
//a^a=0, a^0=a



//给一个数，打印其二进制中一的个数
//int main()
//{
//	int i = 3;
//	int j = 0;
//	int num = 0;
//	for (j = 0; j < 32; j++)
//	{
//		int s = i >> j;
//		if (s & 1 == 1)
//		{
//			num++;
//		}
//	}
//	printf("%d\n", num);
//	return 0;
//}


//int main()
//{
//	short j =5;
//	int a = 10;
//	printf("%d\n", sizeof(j=a+2));
//	printf("%d\n", j);
//	return 0;
//
//}



//取地址操作符  &
//int main()
//{
//	int a = 10;
//	printf("%p\n", &a);
//	int* pa = &a; //pa是用来存放地址的，所以pa是一个指针变量，类型用int*
//	*pa = 20;  //* - 解引用操作符，又叫间接访问操作符
//	printf("%d\n", a);
//	return 0;
//}



//强制类型转换
//int main()
//{
//	int a = (int)3.14;
//	printf("%d\n", a);
//	return 0;
//}



//int main()
//{
//	int arr[] = { 1, 2, 3, 4, 5, 6, 7 };
//	printf("%d\n", *arr);
//	return 0;
//}


//int main()
//{
//	int a = 3;
//	int b = 5;
//
//	return 0;
//}



//int main()
//{
//	int a = 0, b = 1, c = 2, d = 3,e = 4;
//	int i =  a++ && ++b && e++;
//	printf("a=%d\nb=%d\nc=%d\nd=%d\ne=%d\n", a, b, c, d,e);  //a&&b，如果a为假，后面的不用算，a++是先使用，后++，所以输出11234  
//	return 0;												//a||b，如果a为真，后面也不用算
//}




//三目操作符
//int main()
//{
//	int a = 3;
//	int b = 0;
//	if (a > 5)
//	{
//		b = 1;
//	}
//	else
//	{
//		b = -1;
//	}
//	//三目操作符
//	b = (a > 5 ? 1 : -1); //表达式1：a>5为真，表达式2：1;
//						//表达式1：a>5为假，表达式3：-1;
//	return 0;
//}



//逗号表达式
//从左向右依次计算，但整个表达式是最后一个表达式的结果
int main()
{
	int a = 3;
	int b = 5;
	int c = 0;
	int d = (c = 5, a = c + 3, b = a - 4, c += 5);
			//c=5,  a=8,       b=4,       c=10
	printf("%d\n", d);//打印出来是10
	return 0;
}