#define _CRT_SECURE_NO_WARNINGS 1
#include<stdio.h>

//调用堆栈
//void test2()
//{
//	printf("hehe\n");
//}
//void test1()
//{
//	test2();
//}
//void test()
//{
//	test1();
//}
//int main()
//{
//	test();
//	return 0;
//}


//int main()
//{
//	int arr[10] = { 0 };
//	int sz = sizeof(arr) / sizeof(arr[0]);
//	int i = 0;
//	for (i = 0; i < sz; i++)
//	{
//		arr[i] = i + 1;
//	}
//	return 0;
//}


//int main()
//{
//	int n = 0;
//	scanf("%d", &n);
//	int i = 0;
//	int sum = 0;
//	int ret = 1;
//	int j = 0;
//	for (j = 1; j <= n; j++)
//	{
//		ret = 1;
//		for (i = 1; i <= j; i++)
//		{
//			ret = ret*i;
//		}
//		sum += ret;
//	}
//	printf("%d\n", sum);
//	return 0;
//}



//int main()
//{
//	
//	int arr[10] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//	int i = 0;
//	for (i = 0; i <= 12; i++)
//	{
//		arr[i] = 0;
//		printf("hehe\n");
//	}
//	return 0;
//}


//strcpy的模拟
//字符串拷贝
#include<string.h>


//不好
//void my_strcpy(char* dest, char* src)
//{
//	while (*src != '\0')
//	{
//		*dest = *src;
//		dest++;
//		src++;
//	}
//	*dest = *src;
//}
//int main()
//{
//	char arr1[20] = "xxxxxxxxx";
//	char arr2[] = "hello";
//	strcpy(arr1, arr2);
//	my_strcpy(arr1, arr2);
//	printf("%s\n", arr1);
//	return 0;
//}


//改造1
//void my_strcpy(char* dest, char* src)
//{
//	while (*src != '\0')
//	{
//		*dest++ = *src++;
//	}
//	*dest = *src;
//}
//int main()
//{
//	char arr1[20] = "xxxxxxxxx";
//	char arr2[] = "hello";
//	strcpy(arr1, arr2);
//	my_strcpy(arr1, arr2);
//	printf("%s\n", arr1);
//	return 0;
//}


//改造2
//void my_strcpy(char* dest, char* src)
//{
//	while (*dest++ = *src++)//既拷贝了\0，又停下来了。
//	{
//		;
//	}
//
//}
//int main()
//{
//	char arr1[20] = "xxxxxxxxx";
//	char arr2[] = "hello";
//	strcpy(arr1, arr2);
//	my_strcpy(arr1, arr2);
//	printf("%s\n", arr1);
//	return 0;
//}


//改造3(传空指针的可能性）
//#include<assert.h>
//void my_strcpy(char* dest, char* src)
//{
//	assert(src != NULL);//断言
//	assert(dest!= NULL);
//	while (*dest++ = *src++)//既拷贝了\0，又停下来了。
//	{
//		;
//	}
//
//}
//int main()
//{
//	char arr1[20] = "xxxxxxxxx";
//	char arr2[] = "hello";
//	strcpy(arr1, arr2);
//	my_strcpy(arr1, arr2);
//	printf("%s\n", arr1);
//	return 0;
//}


//改造4 char * strcpy ( char * destination, const char * source )
//#include<assert.h>
//void my_strcpy(char* dest, const char* src)
//{
//	assert(src != NULL);//断言
//	assert(dest != NULL);
//	while (*dest++ = *src++)//万一这里写反了，成了*src++ = *dest++，程序会编译运行，但会报错
//	{						//用const修饰，src（地址）变成常变量，无法修改，万一写反，就会无法编译运行，提示有错误。
//		;					
//	}
//
//}
//int main()
//{
//	char arr1[20] = "xxxxxxxxx";
//	char arr2[] = "hello";
//	strcpy(arr1,arr2);
//	my_strcpy(arr1, arr2);
//	printf("%s\n", arr1);
//	return 0;
//}


//const
//int main()
//{
//	const int a = 10;
//	int* p = &a;
//	*p = 20; 
//	//我们用const修饰变量，是想让它不可更改，但a可以通过把地址传给p的方式，对p进行解引用改值。此时输出a变为20，没达到const的效果。正门不能进，翻窗户进。
//	return 0;
//}
////我们对指针const
//int main()
//{
//	const int a = 10;
//	const int* p = &a;
//	int n = 100;
//	//*p = 20;  //这个时候const作用的其实时*p，并没有限制p，表示指针指向的内容，是不会改变的，这个时候就会无法编译。窗户锁死。
//	p = &n;
//	int* pp = p;
//	*pp = 20;//这个时候，我们可以改变p，让p本来时a的地址，变成n的地址，新建一个指针pp存放p也就是n的地址，对n进行修改
//	return 0;
//}
////当我们用const修饰*后面的p的时候
//int main()
//{
//	int a = 10;
//	int* const p = &a;
//	int n = 100;
//	//p = &n; //这里报错，说明const这个时候修饰的是指针p无法被更改，
//	*p = 20;//这里正常，说明可以通过*p来改变a的值，const没有限制*p
//	return 0;
//}


int main()
{

	return 0;
}