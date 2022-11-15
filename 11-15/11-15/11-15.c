#define _CRT_SECURE_NO_WARNINGS 1
#include<stdio.h>
//int main()
//{
//	int arr[] = { 1, 2, 3, 4, 5 };
//	short* p = (short*)arr;//p是短整型指针，每次访问两个字节
//	//1的int型在内存中的形式是00000000000000000000000000000001  转换成16进制就是00 00 00 01，在内存中小端存储，即01 00 00 00，
//	//同理  02 00 00 00    03 00 00 00    04 00 00 00  05 00 00 00
//	int i = 0;
//	for (i = 0; i < 4; i++)
//	{
//		*(p + i) = 0;//注意是short型的指针变量，每次访问两个字节，变成 00 00 00 00 00 00 00 00 00 03 00 00 00 04 00 00 00 05 00 00 00
//	}
//	for (i = 0; i < 5; i++)
//	{
//		printf("%d ", arr[i]);
//	}
//	return 0;
//}
//
//
//输入两个整数，交换并输出
//int main()
//{
//	int a,b;
//	scanf("%d%d", &a, &b);
//	a = a + b;
//	b = a - b;
//	a = a - b;
//	printf("a=%d,b=%d\n", a, b);
//
//	return 0;
//}
//
//输入一个字符，输出对应的ASCII码值
//int main()
//{
//	char c = 0;	//char型变量，它是在这个编译器里面是一个字节的长度，也就是8位二进制。
//				//而%d是指的int类型的转换规则，也就是4个字节，想要正确的显示char类型的话需要在%后面，d的前面加上一个长度指示符。
//	scanf("%c", &c);
//	printf("%hhd\n",c); //%hhd = char、%hd = short、%d = int、%ld = long、%lld = long long。
//						//printf这个函数会将int类型等级以下的类型自动转换为int类型
//						//
//	return 0;
//}
//
//
//进行大于等于100的正整数的计算时，规则如下：
//
//1.       只保留该数的最后两位，例如：对KiKi来说1234等价于34；
//
//2.       如果计算结果大于等于 100， 那么KIKI也仅保留计算结果的最后两位，如果此两位中十位为0，则只保留个位。
//
//例如：45 + 80 = 25
//
//要求给定非负整数 a和 b，模拟KiKi的运算规则计算出 a + b 的值。
//int main()
//{
//	unsigned int a = 0;
//	unsigned int b = 0;
//	unsigned int c = 0;
//	scanf("%d %d", &a, &b);
//	c = a + b;
//	if (a >= 100)
//	{
//		a = a % 100;
//	}
//	else
//	{
//		a = a;
//	}
//	if (b >= 100)
//	{
//		b = b % 100;
//	}
//	else
//		b = b;
//	if (c >= 100)
//	{
//		c = c % 100;
//	}
//	else
//		c = c;
//	printf("%d\n", c);
//	return 0;
//}
//
//
//给一个浮点数，要求输出该浮点数的个位
//int main()
//{
//	float a = 0;
//	scanf("%f", &a);
//	int c = 0;
//	c = (int)a % 10;
//	printf("%d\n", c);
//	return 0;
//}
//
//
//
//一年3.156*10^7秒,输入年龄，输出对应的秒数
//int main()
//{
//	int age = 0;
//	scanf("%d", &age);
//	int miao = age * 3156;
//
//	printf("%d0000\n", miao);
//	return 0;
//}
//
//
//给定秒数 seconds ，把秒转化成小时、分钟和秒。
//int main()
//{
//	int seconds = 0;
//	int a = 0;
//	int b = 0;
//	int c = 0;
//	scanf("%d", &seconds);
//	a = seconds / 3600;
//	b = (seconds % 3600) / 60;
//	c = seconds % 3600 % 60;
//	printf("%d %d %d", a, b, c);
//		return 0;
//}
//
//
//计算三角形的周长和面积
//#include<math.h>
//int main()
//{
//	int a = 0;
//	int b = 0;
//	int c = 0;
//	int d = 0;
//	scanf("%d%d%d", &a, &b, &c);
//	if (a + b > c&&a + c > b&&b + c > a)
//	{
//		float circumference = a + b + c;
//		float d = circumference / 2;
//		float area = sqrt(d*(d - a) * (d - b) * (d - c));
//		printf("circumference=%.2f area=%.2f\n", circumference,area);
//	}
//	return 0;
//}
//
//
//
//给定一个球体的半径，计算其体积。其中球体体积公式为 V = 4/3*πr3，其中 π = 3.1415926。
//
//
//数据范围：输入一个浮点值 0 \le n \le 15 \0≤n≤15
//int main()
//{
//	double a = 0;
//	scanf("%lf", &a);//scanf中，double用%lf。float用%f。
//	double v = 0;
//	v = 4.000 / 3.000 * 3.1415926*a*a*a;
//
//	printf("%.3f", v);
//
//	return 0;
//}


//实现字母的大小写转换
//ASCII差32
//int main()
//{
//	char x = 0;
//	while ((x = getchar()) != EOF)//EOF的作用是遇到ctrl+z才停止运行，这样可以多次输入输出，若是‘\n’，只能一次，但不用在{}内部再一次geichar（）了。
//	{
//		getchar();//作用是获取‘\n’，
//		putchar(x + 32);//输出的是x的
//		printf("\n");
//	}
//	return 0;
//}