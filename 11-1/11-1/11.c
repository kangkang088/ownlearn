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

//int main()
//{
//	int a = 0;
//	scanf("%d", &a);
//	while (a >= 1 && a <= 100)
//	{
//		if (a % 2 == 1)
//			printf("奇数%d\n",a);
//		a++;
//		
//	}
//	return 0;
//}
//int main()
//{
//	int day = 0;
//	scanf("%d", &day);
//	switch (day)
//	{
//	case 1:
//		printf("星期一\n");
//		break;
//	case 2:
//		printf("星期二\n");
//		break;
//	case 3:
//		printf("星期三\n");
//		break;
//	case 4:
//		printf("星期四\n");
//		break;
//	case 5:
//		printf("星期五\n");
//		break;
//	case 6:
//		printf("星期六\n");
//		break;
//	case 7:
//		printf("星期日\n");
//		break;
//	}
//	return 0;
//}

//1-5是工作日，6-7休息日
//写法一（繁琐） 

//int main()
//{
//	int day = 0;
//	scanf("%d", &day);
//	switch (day)
//	{
//	case 1:
//		printf("工作日\n");
//		break;
//	case 2:
//		printf("工作日n");
//		break;
//	case 3:
//		printf("工作日n");
//		break;
//	case 4:
//		printf("工作日n");
//		break;
//	case 5:
//		printf("工作日\n");
//		break;
//	case 6:
//		printf("休息日\n");
//		break;
//	case 7:
//		printf("休息日n");
//		break;
//	}
//	return 0;
//}

//写法2（简单）


//int main()
//{
//	int day = 0;
//	scanf("%d", &day);
//	switch (day)
//	{
//	case 1:		
//	case 2:	
//	case 3:
//	case 4:		
//	case 5:
//		printf("工作日\n");
//		break;
//	case 6:		
//	case 7:
//		printf("休息日n");
//		break;
//  default:   //  可有可无，需要的时候用
//		printf("输入错误\n");  //如果输入的值不在以上集中情况之中，则运行default，  可以放最上面，也可以放下面，和case不分顺序
//	break;
//	}
//	return 0;
//}
//
//int main()
//{
//	/*while (表达式)
//		循环语句：*/
//	/*while (1)
//		printf("hehe\n");*/
//	int i = 1;
//	while (i <= 10)
//	{
//		printf("%d\n", i);
//		i++;
//	}
//	return 0;
//}
//
//int main()
//{
//	/*while (表达式)
//	循环语句：*/
//	/*while (1)
//	printf("hehe\n");*/
//	int i = 1;
//	while (i <= 10)
//	{
//		if (i == 5)
//			continue;  //死循环，作用是中止循环中本次循环后面的代码，当i满足5时，进入if，见到continue，直接终止后面的代码，继续跳到while，而此时i没有改变，继续进入if，继续跳到while。形成死循环
//		printf("%d\n", i);
//		i++;
//	}
//	return 0;
//}


//int main()
//{
//	/*while (表达式)
//	循环语句：*/
//	/*while (1)
//	printf("hehe\n");*/
//	int i = 1;
//	while (i <= 10)
//	{
//		i++;  //改变i++的位置，不会进入死循环，当i=5时，进入if，continue中止后面的语句，跳到while，先进行i++，此时i的值改变，if条件不满足，继续执行后面的语句
//		if (i == 5)
//			continue;
//		printf("%d\n", i);
//		
//	}
//	return 0;
//}
//int main()
//{
//	int ch = 0;
//	// ctrl+z会获取EOF，停止   ch获取到EOF，此时EOF ！= EOF 为假，结束  如果依次一次输入EOF，相当于getchar获取了三次字符，依然会输出EOF，且程序不会停止。
//	//EOF -end of file  文件结束标志
//	while ((ch=getchar()) != EOF)
//	{
//		putchar(ch);
//	}
//
//	/*putchar(ch);
//	printf("%c\n", ch);*/
//	return 0;
//}