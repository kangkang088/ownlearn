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
//把src指向的内容拷贝放进dest中
//本质上，就是希望dest指向的内容可以修改，src指向的内容不应该被修改，加const。
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



//改造5 char * strcpy ( char * destination, const char * source )
//把src指向的内容拷贝放进dest中
//本质上，就是希望dest指向的内容可以修改，src指向的内容不应该被修改，加const。
//#include<assert.h>
//strcpy函数返回的其实是目标空间的起始地址
//char* my_strcpy(char* dest, const char* src)
//{
//	assert(src != NULL);//断言
//	assert(dest != NULL);
//	char* ret = dest;//存起始地址
//	while (*dest++ = *src++)//万一这里写反了，成了*src++ = *dest++，程序会编译运行，但会报错
//	{						//用const修饰，src（地址）变成常变量，无法修改，万一写反，就会无法编译运行，提示有错误。
//		;
//	}
//	return ret;
//}
//int main()
//{
//	char arr1[20] = "xxxxxxxxx";
//	char arr2[] = "hello";
//
//	printf("%s\n", my_strcpy(arr1, arr2));//链式访问
//	return 0;
//}



//strlen
//my_strlen;
//1.const   我们是想求这个字符串的长度，不希望它的内容被改变   健壮性+1，又叫鲁棒性+1
//2.assert  我们要保证指针的有效性
//#include<assert.h>
//unsigned int my_strlen(const char* arr) //长度不能为负数，加个unsigned。  
//{
//	assert(arr != NULL);
//	int len = 0;
//	while(*arr++ != '\0')
//	{
//		len++;
//	}
//	return len;   
//}
//int main()
//{
//	char arr[] = "abcdeqweEWQE";
//	printf("%d\n", my_strlen(arr));
//	return 0;
//}




//1.给一个数，输出该数二进制中1的个数
//int numberof1(int n)  //存在一定的问题，对于负数不适用，可以改成unsigned int n。
//{
//	int count = 0;
//	while (n)
//	{
//		if (n % 2 == 1)
//			count++;
//		n /= 2;
//	}
//	return count;
//}
//int main()
//{
//	int n = -1;
//	int ret = numberof1(n);
//	printf("%d\n", ret);
//	return 0;
//}

//改 
//int numberof1(int n)
//{
//	int count = 0;
//	int i = 0;
//	for (i = 0; i < 32; i++)
//	{
//		if ((n & 1) == 1)
//		{
//			count++;
//			n = n >> 1;
//		}
//		else
//		{
//			n = n >> 1;
//		}
//	}
//	return count;
//}
//int main()
//{
//	int n = -1;
//	int ret = numberof1(n);
//	printf("%d\n", ret);
//	return 0;
//}

//优化
//int numberof1(int n)
//{
//	int count = 0;
//	while (n)
//	{
//		n = n&(n - 1);
//		count++;
//	}
//	return count;
//}
//int main()
//{
//	int n = -1;
//	int ret = numberof1(n);
//	printf("%d\n", ret);
//	return 0;
//}

//递归
//int numberof1(int n)
//{
//	if (n != 0)
//	{
//		n = n&(n - 1);
//		return 1 + numberof1(n);
//	}
//	return 0;
//}
//int main()
//{
//	int n = -1;
//	int ret = numberof1(n);
//	printf("%d\n", ret);
//	return 0;
//}


//写一个代码，判断一个数字是不是2的n次方
//二进制中只有一个1
//则k&（k-1）结果一定是0  但是不能判断负数
//int main()
//{
//	int k = 0;
//	scanf("%d", &k);
//	k = k&(k - 1);
//	if (k == 0)
//	{
//		printf("是\n");
//	}
//	else
//		printf("不是\n");
//	
//	return 0;
//}


//求两个数中，二进制位不同的个数
//int swap(int a, int b)
//{
//	int d = a^b;
//	int count = 0;
//	while (d != 0)
//	{
//		if ((d & 1) == 1)
//		{
//			count++;
//			d = d >> 1;
//		}
//		else
//		{
//			d = d >> 1;
//		}	
//	}
//	return count;
//}
//int main()
//{
//	int a = 1999;
//	int b = 2299;
//	int c =swap(a, b);
//	printf("%d\n", c);
//	return 0;
//}

//改
//int main()
//{
//	int a = 22;
//	int b = 33;
//	int i = 0;
//	int count = 0;
//	for (i = 0; i < 32; i++)
//	{
//
//		if (((a >> i) & 1 )!= ((b >> i) & 1))
//		{
//			count++;
//		}
//	}
//	printf("%d\n", count);
//	return 0;
//}


//改
//int main()
//{
//	int a = 0;
//	int b = 0;
//	int count = 0;
//	scanf("%d%d", &a, &b);
//	int n = a^b;
//	while (n)
//	{
//		n = n&(n - 1);
//		count++;
//	}
//	printf("%d\n", count);
//	return 0;
//}



//获取n的二进制中奇数位和偶数位
//int main()
//{
//	int i = 0;
//	int n = 0;
//	scanf("%d", &n);
//	//打印偶数位
//	for (i = 31; i >= 1; i -= 2)
//	{
//		printf("%d ", (n >> i) & 1);
//	}
//	//打印奇数位
//	for (i = 30; i >= 0; i -= 2)
//	{
//		printf("%d ", (n >> i) & 1);
//	}
//	return 0;
//}


//交换两个变量，不创建临时变量
//1.
//int main()
//{
//	int a = 15;
//	int b = 50;
//	a = a + b;
//	b = a - b;
//	a = a - b;
//	printf("a=%d,b=%d\n", a, b);
//	return 0;
//}
//2.
//int main()
//{
//	int a = 10;
//	int b = 20;
//	a = a^b;
//	b = a^b;
//	a = a^b;
//	printf("a=%d,b=%d\n", a, b);
//	return 0;
//}



//