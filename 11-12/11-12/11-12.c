#define _CRT_SECURE_NO_WARNINGS 1
#include<stdio.h>
//int main()
//{
//	int* pa;
//	char* pc;
//	float* pf;
//	printf("%d\n", sizeof(pa));
//	printf("%d\n", sizeof(pc));
//	printf("%d\n", sizeof(pf));
//	return 0;
//}


//指针类型的意义
//1.指针类型决定了指针解引用时的访问权限
//2.指针类型决定了指针走一步的距离
//int main()
//{
//	//一个16进制表示4个二进制位；
//	int a = 0x11223344;
//	//int* pa=&a;
//	//*pa = 0;//改四个字节
//	char* pc = &a;
//	*pc = 0;//改一个字节
//	return 0;
//}
//int main()
//{
//	int arr[10] = { 0 };
//	int* p = arr;
//	char* pc = arr;
//	printf("%p\n", p);
//	printf("%p\n", p + 1);//差4
//	printf("%p\n", pc);
//	printf("%p\n", pc + 1);//差1
//	return 0;
//}


//int main()
//{
//	int arr[10] = {0};
//	int* p = &arr;
//	int i = 0;
//	for (i = 0; i < 10; i++)  //char一个字节一个字节的变，int四个字节四个字节的变
//	{
//		*(p + i)=1;
//	}
//	return 0;
//}


//
//int main()
//{
//	//野指针
//	//1.指针未初始化
//	int* p;//局部指针变量，局部变量不初始化，默认是随机值。则现在p存的是随机地址。
//	*p = 20;//通过随机地址访问随机空间，非法访问内存
//	return 0;
//}



//int main()
//{
//	//2.指针越界
//	int arr[10] = { 0 };
//	int* p = arr;
//	int i = 0;
//	for (i = 0; i <= 10; i++)
//	{
//		*p = i;
//		p++;
//	}
//	return 0;
//}


//int* test()
//{
//	int a = 10;//局部变量，进入函数创建a的空间
//	return &a;//返回a的地址给p，a的空间立即释放，a的生命周期结束
//}
//int main()
//{
//	//3.指针指向空间释放
//	int* p=test();
//	*p = 20;//出问题，a的空间已经被释放，还给系统，这时候再访问属于非法访问。
//	return 0;
//}



//如何避免野指针
//1.指针初始化
//int main()
//{
//	int* p = NULL;//当不知道指针初始化什么地址的时候，就初始化为NULL；
//	return 0;
//}
//int main()
//{
//	int a = 10;
//	int* p = &a;//明确知道指针初始化地址
//	return 0;
//}



//int main()
//{
//	int arr[10] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//	int* p = arr;
//	int* pen = arr + 9;
//	while (p <= pen)
//	{
//		printf("%d\n", *p);
//		p++;
//	}
//	return 0;
//}



//指针相减的前提是两个指针指向同一个空间，类型一样，
//int main()
//{
//	int arr[10] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//	int* a=&arr[9];
//	int* b=&arr[0];
//	printf("%d\n",&arr[9] - &arr[0]); //指针-指针等于两个指针之间的元素个数
//	return 0;
//}




#include<string.h>
//计数的方法
//int my_strlen(char* str)
//{
//	int count = 0;
//	while (*str != '\0')
//	{
//		count++;
//		str++;
//	}
//	return count;
//}

//递归
//int my_strlen(char* str)
//{
//	if (*str != '\0')
//	{
//		str++;
//		return 1 + my_strlen(str);
//	}
//		return 0;
//}

//指针-指针
//int my_strlen(char* str)
//{
//	char* strat = str;//先把起始位置地址存起来
//	while (*str != '\0')//str='\0'的时候，不满足，则用当前str指的\0的地址减去初始位置
//	{
//		str++;
//	}
//	return str - strat;   
//}
//int main()
//{
//	int len = my_strlen("abc");
//	printf("%d\n", len);
//	return 0;
//}


//int main()
//{
//	int arr[10] = { 0 };
//	printf("%p\n", arr);
//	printf("%p\n", &arr[0]);
//	return 0;
//}



//int main()
//{
//	int arr[10] = { 0 };
//	int* p = arr;
//	int i = 0;
//	for (i = 0; i < 10; i++)
//	{
//		*(p + i) = i;
//	}
//	for (i = 0; i < 10; i++)
//	{
//		printf("%d\n", *(p + i));
//	}
//	return 0;
//}


//int main()
//{
//	int arr[10] = { 1,2,3,4,5,6,7,8,9,10 };
//	int* p = arr;
//	//arr[2] == *(p+2) ==*(2+p) == *(2+arr) == *(arr+2) == 2[arr] == 2[p] == p[2]
//	printf("%d\n",arr[2] );
//	printf("%d\n", *(p+2));
//	printf("%d\n", *(2+p));
//	printf("%d\n", *(2+arr));
//	printf("%d\n", *(arr+2));
//	printf("%d\n", 2[arr]);
//	printf("%d\n", 2[p]);
//	printf("%d\n", p[2]);
//	return 0;
//}



//二级指针
//int main()
//{
//	int a = 10;
//	int* pa = &a;//pa是指针变量，一级指针
//
//	//pa也是个变量，也是在内存中开辟空间
//	//&pa是取出pa在内存中的起始地址；
//	 int* * ppa = &pa; //二级指针
//	 //前面的*（其实是int*），代表是pa的类型是int*  ；第二个，说明ppa是指针变量
//
//	 //继续取
//	 int** * pppa = &ppa; //三级指针
//	return 0;
//}



//指针数组
//int main()
//{
//	int arr[10];//整型数组 - 存放整型的数组
//	char ch[5];//字符数组 - 存放字符的数组
//
//	//推演
//	//指针数组 - 存放指针
//	int* parr[5] = {0};//整型指针数组
//	char* cpl[5] = {0};//字符指针数组
//
//	return 0;
//}



//结构体
//struct A
//{
//	char c;
//	int a;
//	double d;
//};
//struct Stu
//{
//	//成员变量
//	struct A sb; //嵌套结构体
//	char name[20];
//	int age;
//	char id[20];
//};
//int main()
//{
//	struct Stu s = { {'w',4,3.14},"李明", 25, "190611323" }; //初始化，嵌套初始化
//	return 0;
//}



//结构体成员的访问
//struct A
//{
//	char c;
//	int a;
//	double d;
//};
//struct Stu
//{
//	//成员变量
//	struct A sb; //嵌套结构体
//	char name[20];
//	int age;
//	char id[20];
//};
//int main()
//{
//	struct Stu s = { { 'w', 4, 3.14 }, "李明", 25, "190611323" }; //初始化，嵌套初始化
//	printf("%c\n", s.sb.c);
//	struct  Stu* ps = &s;
//	printf("%c\n", (*ps).sb.c); //. 
//	printf("%c\n", ps->sb.c); //-> 指针用
//	return 0;
//}



//结构体传参
//struct A
//{
//	char c;
//	int a;
//	double d;
//};
//struct Stu
//{
//	//成员变量
//	struct A sb; //嵌套结构体
//	char name[20];
//	int age;
//	char id[20];
//};
//void print1(struct Stu t)
//{
//	printf("%c %d %lf %s %d %s\n", t.sb.c, t.sb.a, t.sb.d, t.name, t.age, t.id);
//}
//void print2(struct Stu* ps)
//{
//	printf("%c %d %lf %s %d %s\n", ps->sb.c, ps->sb.a, ps->sb.d, ps->name, ps->age, ps->id);
//}
//int main()
//{
//		struct Stu s = { { 'w', 4, 3.14 }, "李明", 25, "190611323" }; //初始化，嵌套初始化
//		//写一个函数打印s的内容；
//		print1(s);//传值调用  产生额外空间，函数不可改变参数
//		print2(&s);//传址调用  省空间，函数可改变参数，效率高
//		return 0;
//}





//实用调试技巧
