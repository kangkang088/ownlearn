#define _CRT_SECURE_NO_WARNINGS 1
#include<stdio.h>

//���ö�ջ
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


//strcpy��ģ��
//�ַ�������
#include<string.h>


//����
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


//����1
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


//����2
//void my_strcpy(char* dest, char* src)
//{
//	while (*dest++ = *src++)//�ȿ�����\0����ͣ�����ˡ�
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


//����3(����ָ��Ŀ����ԣ�
//#include<assert.h>
//void my_strcpy(char* dest, char* src)
//{
//	assert(src != NULL);//����
//	assert(dest!= NULL);
//	while (*dest++ = *src++)//�ȿ�����\0����ͣ�����ˡ�
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


//����4 char * strcpy ( char * destination, const char * source )
//��srcָ������ݿ����Ž�dest��
//�����ϣ�����ϣ��destָ������ݿ����޸ģ�srcָ������ݲ�Ӧ�ñ��޸ģ���const��
//#include<assert.h>
//void my_strcpy(char* dest, const char* src)
//{
//	assert(src != NULL);//����
//	assert(dest != NULL);
//	while (*dest++ = *src++)//��һ����д���ˣ�����*src++ = *dest++�������������У����ᱨ��
//	{						//��const���Σ�src����ַ����ɳ��������޷��޸ģ���һд�����ͻ��޷��������У���ʾ�д���
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
//	//������const���α����������������ɸ��ģ���a����ͨ���ѵ�ַ����p�ķ�ʽ����p���н����ø�ֵ����ʱ���a��Ϊ20��û�ﵽconst��Ч�������Ų��ܽ�������������
//	return 0;
//}
////���Ƕ�ָ��const
//int main()
//{
//	const int a = 10;
//	const int* p = &a;
//	int n = 100;
//	//*p = 20;  //���ʱ��const���õ���ʵʱ*p����û������p����ʾָ��ָ������ݣ��ǲ���ı�ģ����ʱ��ͻ��޷����롣����������
//	p = &n;
//	int* pp = p;
//	*pp = 20;//���ʱ�����ǿ��Ըı�p����p����ʱa�ĵ�ַ�����n�ĵ�ַ���½�һ��ָ��pp���pҲ����n�ĵ�ַ����n�����޸�
//	return 0;
//}
////��������const����*�����p��ʱ��
//int main()
//{
//	int a = 10;
//	int* const p = &a;
//	int n = 100;
//	//p = &n; //���ﱨ��˵��const���ʱ�����ε���ָ��p�޷������ģ�
//	*p = 20;//����������˵������ͨ��*p���ı�a��ֵ��constû������*p
//	return 0;
//}



//����5 char * strcpy ( char * destination, const char * source )
//��srcָ������ݿ����Ž�dest��
//�����ϣ�����ϣ��destָ������ݿ����޸ģ�srcָ������ݲ�Ӧ�ñ��޸ģ���const��
//#include<assert.h>
//strcpy�������ص���ʵ��Ŀ��ռ����ʼ��ַ
//char* my_strcpy(char* dest, const char* src)
//{
//	assert(src != NULL);//����
//	assert(dest != NULL);
//	char* ret = dest;//����ʼ��ַ
//	while (*dest++ = *src++)//��һ����д���ˣ�����*src++ = *dest++�������������У����ᱨ��
//	{						//��const���Σ�src����ַ����ɳ��������޷��޸ģ���һд�����ͻ��޷��������У���ʾ�д���
//		;
//	}
//	return ret;
//}
//int main()
//{
//	char arr1[20] = "xxxxxxxxx";
//	char arr2[] = "hello";
//
//	printf("%s\n", my_strcpy(arr1, arr2));//��ʽ����
//	return 0;
//}



//strlen
//my_strlen;
//1.const   ��������������ַ����ĳ��ȣ���ϣ���������ݱ��ı�   ��׳��+1���ֽ�³����+1
//2.assert  ����Ҫ��ָ֤�����Ч��
//#include<assert.h>
//unsigned int my_strlen(const char* arr) //���Ȳ���Ϊ�������Ӹ�unsigned��  
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




//1.��һ���������������������1�ĸ���
//int numberof1(int n)  //����һ�������⣬���ڸ��������ã����Ըĳ�unsigned int n��
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

//�� 
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

//�Ż�
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

//�ݹ�
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


//дһ�����룬�ж�һ�������ǲ���2��n�η�
//��������ֻ��һ��1
//��k&��k-1�����һ����0  ���ǲ����жϸ���
//int main()
//{
//	int k = 0;
//	scanf("%d", &k);
//	k = k&(k - 1);
//	if (k == 0)
//	{
//		printf("��\n");
//	}
//	else
//		printf("����\n");
//	
//	return 0;
//}


//���������У�������λ��ͬ�ĸ���
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

//��
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


//��
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



//��ȡn�Ķ�����������λ��ż��λ
//int main()
//{
//	int i = 0;
//	int n = 0;
//	scanf("%d", &n);
//	//��ӡż��λ
//	for (i = 31; i >= 1; i -= 2)
//	{
//		printf("%d ", (n >> i) & 1);
//	}
//	//��ӡ����λ
//	for (i = 30; i >= 0; i -= 2)
//	{
//		printf("%d ", (n >> i) & 1);
//	}
//	return 0;
//}


//����������������������ʱ����
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