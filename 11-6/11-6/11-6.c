#define _CRT_SECURE_NO_WARNINGS 1
#include <stdio.h>
#include <string.h>

// int Run(int x)
//{
//	if (x % 4 == 0 && x % 100 != 0)
//	{
//		return 1;
//	}
//	else if (x % 400 == 0)
//	{
//		return 1;
//	}
//	else
//	{
//		return 0;
//	}
//}


 //�ж�������Ƿ�Ϊ����
//int main()
//{
//	int i = 0;
//	printf("��������Ҫ�жϵ���ݣ�");
//	scanf("%d", &i);
//	if (1 == Run(i))
//	{
//		printf("������\n", i);
//	}
//	else
//	{
//		printf("��������\n", i);
//	}
//	return 0;
//}


//�ж�1000-2000������겢��ӡ
//int main()
//{
//	int year = 0;
//	for (year = 1000; year <= 2000; year++)
//	{
//		if (1 == Run(year))
//		{
//			printf("%d\n", year);
//		}
//	}
//	return 0;
//}


				//��ַ�������������������arr[]�Ǹ�ָ��
//int binary_search(int arr[],int x,int sz)
//{
//	int left = 0;
//	int right = 0;
//	//int sz = 0;
//	int mid = 0;
//	//sz = sizeof(arr) / sizeof(arr[0]);  //�������ʱ����ʵ������������Ԫ�صĵ�ַ�����Ǵ���ȥһ��ָ�룬32λָ���С��4�ֽڣ�����Ҳ��4�ֽڣ���sz=1.
//	left = 0;
//	right = sz - 1;
//	while (left<=right)
//	{
//		mid = (left + right) / 2;   //���ܷŵ�ѭ�����棬ÿһ�ζ��ֲ��Ҷ�Ҫ��һ���м��±ꡣ
//		if (arr[mid] < x)
//		{
//			mid++;
//			left = mid;
//
//		}
//		else if (arr[mid]>x)
//		{
//			right--;
//			right = mid;
//
//		}
//		else
//		{
//			return mid;
//		}
//	}
//	if (right < left)
//	{
//		return -1;
//	}
//}
//int main()
//{
//	int  arr[] = {1,2,3,4,5,6,7,8,9,10};
//	int sz = 0;
//	int k = 7;
//	sz = sizeof(arr) / sizeof(arr[0]); //ע�����������������Ĵ�С���ɡ�
//	int ret = binary_search(arr,k,sz);//���ݹ�ȥ��arr��������Ԫ�صĵ�ַ
//	if (ret == -1)
//	{
//		printf("�Ҳ���");
//	}
//	else
//	{
//		printf("�ҵ��ˣ��±��ǣ�%d\n", ret);
//	}
//	return 0;
//}


//дһ���������øú���һ�Σ�numֵ��һ
//void add(int* x)
//{
//	*x=(*x)++;  //��������ţ���Ϊ++�����ȼ���*�ߡ�
//}
//int main()
//{
//	int num = 0;
//		add(&num);//num�Ǻ����ⲿ������Ҫ�ں����ڲ��ı䲢����������βκ�ʵ�ν�������ϵ���ô�ַ���á�
//		printf("%d\n", num);
//		add(&num);
//		printf("%d\n", num);
//		add(&num);
//		printf("%d\n", num);
//		add(&num);
//		printf("%d\n", num);
//		add(&num);
//		printf("%d\n", num);
//		add(&num);
//		printf("%d\n", num);
//	return 0;
//}


//Ƕ�׵���
//void add2()
//{
//	printf("hehe\n");
//}
//void add1()
//{
//	int i = 0;
//	for (i = 0; i < 3; i++)
//	{
//		add2();
//	}
//}
//int main()
//{
//	add1();
//	return 0;
//}


//int main()
//{
//	int len = 0;
//	//1
//	len = strlen("abc");
//	printf("%d\n", len);
//	//2  ��ʽ����
//	printf("%d\n", strlen("abc"));
//
//	return 0;
//}
int main()
{
	printf("%d", printf("%d", printf("%d", 43)));
//�����4321.�������յ��Ƿ���ֵ�����Ǵ�ӡ��ֵ��printf�����ķ���ֵ�Ǵ�ӡ���ַ��ĸ�����
//���ڲ��ӡ43������ֵΪ2�����м���ӡ2������ֵΪ1�������ӡ1�����ս��Ϊ4321.
	return 0;
}