#define _CRT_SECURE_NO_WARNINGS 1
#include <stdio.h>
//第一种
//int main()
//{
//	int age = 100;
//	if (age < 18)
//		printf("此时未成年\n");
//	else if (age >= 18 && age < 28)
//		printf("青年\n");
//	else if (age >= 28 && age < 50)
//		printf("此时为壮年\n");
//	else if (age >= 50 && age < 90)
//		printf("此时为老年\n");
//	/*else*/     //这里的else可以去掉
//		printf("此时老不死\n");//也输出老不死
//	return 0;
//}
////第二种
//int main()
//{
//	int age = 18;
//	if (age < 18)
//		printf("此时未成年");
//	else{
//		if (age >= 18 && age < 28)
//			printf("青年\n");
//		else if (age >= 28 && age < 50)
//			printf("此时为壮年\n");
//		else if (age >= 50 && age < 90)
//			printf("此时为老年\n");
//		else
//			printf("老不死\n");
//	    }
//	return 0;
//
//}


//  0为假；非零为真。


//if语句控制多条语句时，要用{}代码块

//if (表达式)
//{
//	yuju1;
//	yuju2;
//}
//else
//{
//	yuju3;
//	yuju4;
//}



//int main()
//{
//	int a = 1;
//	int b = 2;
//	if (a = = 1)
//	   if (b = = 2)
//		printf("hehe\n");
//	   else//else只会和最近的未匹配的if匹配
//		printf("hah\n");
//	return 0;
//}




//int main()
//{
//	int num = 4;
//	if (5 = = num)//判断常量和变量，常量放左边
//		printf("hehe\n");
//	
//	
//	//if (num = 5)
//	//{
//	//	printf("hehe\n");//此时依然会打印呵呵，因为if里面是赋值=;bug
//	//}
//	return 0;
//}


//int main()
//{
//	int i = 0;
//	scanf("%d", &i);
//	if (1 == i % 2)
//	{
//		printf("奇数\n");
//	}
//	else
//	{
//		printf("偶数\n");
//	}
//		return 0;
//}

int main()
{
	int a = 0;
	scanf("%d", &a);
	while (a >= 1 && a <= 100)
	{
		if (a % 2 == 1)
			printf("奇数%d\n",a);
		a++;
		
	}
	return 0;
}