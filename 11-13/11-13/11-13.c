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


int main()
{

	return 0;
}