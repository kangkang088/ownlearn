#define _CRT_SECURE_NO_WARNINGS 1
#include <stdio.h>
//int main()
//{
//	int ch = 0;
//	//EOF end of file 文件结束标志
//	while ((ch = getchar()) != EOF)
//	{
//		putchar(ch);
//	}
//	return 0;
//}


//int main()
//{
//	int ret = 0;
//	int ch = 0;                       //输入函数：先检测输入缓冲区，在输入缓冲区里面取值，我们输入以后，scanf拿走一部分，我们按回车，也会产生一个转移字符\n;
//	char password[] = { 0 };
//	printf("请输入密码： ");
//	scanf("%s", password);         //输入123456，缓冲区里面会有123456\n,输入123456 ABCD,输入缓冲区里面会剩下  空格ABCD\n，scanf只会读取空格前面的字符。
//	while (ch = getchar() != '\n');   //此循环的作用是一直读取输入缓冲区里面的字符并取走，直到全部拿走，避免下面的getchar在输入缓冲区里面得到任何值，
//	{
//		;       //为什么用循环？因为getchar只能获取字符，不能获取字符串；
//	}
//	printf("请确认（Y/N）:");
//	ret = getchar();  //如果没有上面的循环，我们输入123456之后，回车，依然会产生一个字符  \n(换行)，那么输入缓冲区里面还有一个转移字符\n,此时ret会读取其值，结果是我们没有机会输入Y/N，直接跳到else，放弃确认
//	if (ret = 'Y')   
//		printf("确认成功\n");
//	else
//		printf("放弃确认\n");
//	return 0;
//}
int main()
{
	int ch = 0;
	while ((ch = getchar()) != EOF)
	{

		if (ch<'0' || ch>'9')
			continue;
		putchar(ch);
	}
	return 0;
}