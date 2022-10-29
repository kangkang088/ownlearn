#define _CRT_SECURE_NO_WARNINGS 1



#include <stdio.h>
#include <string.h>
//int main()
//{
//	int sum1 = 0;
//	int sum2 = 0;
//	int sum = 0;
//	scanf("%d%d", &sum1, &sum2);
//	sum = sum1 + sum2;
//	printf("sum = %d\n", sum);
//
//	return 0;
//}
//int main()
//{
//	printf("%d\n", sizeof(char));
//	printf("%d\n", sizeof(short));
//	printf("%d\n", sizeof(int));
//	printf("%d\n", sizeof(long));
//	printf("%d\n", sizeof(long long));
//	printf("%d\n", sizeof(float));
//	printf("%d\n", sizeof(double));
//	return 0;
//}
//int main()
//{
//	char arr[] = "asdb";
//	printf("%s\n",arr);
//	return 0;
//}
//int main()
//{
//	char arr =  'A';
//	printf("%d\n", arr);//出现A的ASCII码值；%s\n不出现任何。
//	return 0;
//}
//int main()
//{
//	char arr = 'A';
//	printf("%c\n", arr);//出现A
//	return 0;
//%c表示输出一个字符；

//%d表示输出带符号的十进制整型数；

//%s表示输出一个字符串，知道遇到“\0”。
//int main()		
//{
//	int age = 0;
//	scanf("%d", &age);
//	if (age<18)
//	{
//		printf("年龄小于18是未成年\n");
//	}
//	else
//	{
//		printf("成年\n");
//	}
//	return 0;
//}
//int main()
//{
//	int arr[10] = { 1, 2, 3, 4, 5, 6, 7, 8, 9,10 };
//	printf("%d\n", arr[0]);
//	int i = 0;
//	while (i < 10)
//	{
//
//		printf("%d", arr[i]);
//		i++;
//	}
//
//	return 0;
//}

//int MAX(int x, int y)
//{
//	if (x > y)
//	{
//
//		return x;
//	}
//	else
//	{
//		return y;
//	}
//	}
//int main()
//{
//	int a = 10;
//	int b = 20;
//	int max = 0;
//	max = MAX(a, b);
//	printf("%d\n", max);
//
//	return 0;
//}	
//int ADD(int x, int y)
//{
//	int sum = x + y;
//	return sum;
//}
//int main()
//{
//	int a = 50;
//	int b = 50;
//	int c = 0;
//	c = ADD(a, b);
//	printf("%d\n", c);
//	return 0;
//}
//int main()
//{
//	int a = 0;// 00000000000000000000000000000000;
//	int b = ~a;//11111111111111111111111111111111;表示一个负数。负数在内存中存储的时候是一个二进制的补码
//	//正数的原码反码补码都相同，负数的原码。反码：表示正负的位不变，其他取反；补码：反码+1.
//	//11111111111111111111111111111110；
//	//10000000000000000000000000000001;
//	printf("%d\n", b);
//	return 0;
//}
//int main()
//{
//	printf("%d\n", strlen("abcdef"));
//	// \62被解析成一个转义字符
//	printf("%d\n", strlen("c:\test\628\test.c"));
//	return 0;
//}
//int main()
//{
//	int a = 50;
//	int b = 78;
//	int c = 0;
//		c = (a > b ? a : b);
//		printf("%d\n", c);
//	return 0;
//}
int main()
{
	printf("年薪100万,我要敲代码十万行\n");
	int i = 0;
	while (i <100000)
	{
		i++;
		printf("%d\n", i);
		
	}
	printf("成功实现目标");
	return 0;
}