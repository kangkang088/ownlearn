#define _CRT_SECURE_NO_WARNINGS 1
#include <stdio.h>
#include<string.h>
//int main() {
//	int i = 0;
//	int sum = 0;
//	int arr[] = { 0 };
//	scanf("%d", &i);
//	while (i)
//	{
//		arr[sum] = i % 6;
//		sum++;
//		i = i / 6;
//	}
//	for (sum--; sum >= 0; sum--)
//	{
//		printf("%d", arr[sum]);
//	}
//	return 0;
//}


//int main()
//{
//	//����һ������-10������
//	int arr[10];
//	//�ַ���
//	char arr2[5];
//	return 0;
//}



//int main()
//{
//	char arr1[] = "abc";
//	char arr2[] = { 'a', 'b', 'c' };
//	printf("%d\n", sizeof(arr1));
//	printf("%d\n", sizeof(arr2));
//	printf("%d\n", strlen(arr1));
//	printf("%d\n", strlen(arr2));
//	return 0;
//}



//int main()
//{
//	//int i = 0;
//	//char arr[] = "abcdef";
//	//printf("%c\n", arr[3]);
//	/*for (i = 0; i <= 5; i++)
//	{
//		printf("%c\n", arr[i]);
//	}*/
//
//
//
//
//
//	int arr[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//	int i = 0;
//	int sz = sizeof(arr) / sizeof(arr[0]);
//	for (i = 0;i < sz;i++)
//	{
//		printf("%d\n", arr[i]);
//	}
//
//	return 0;
//}





//int main()
//{
//	int i = 0;
//	int arr[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//	int sz = sizeof(arr) / sizeof(arr[0]);
//	for (i = 0; i < sz; i++)
//	{
//		printf("&arr[%d] = %p\n",i, &arr[i]); //ÿ����ַ���ġ����ۣ��������ڴ�����������
//	}
//	return 0;
//}


//int main()
//{
//	int arr[][4] = { { 1, 2, 3 },{ 4, 5 } };//��ά�����п���ʡ�ԣ��в���ʡ�ԡ�
//
//	return 0;
//}



//int main()
//{
//	int arr[3][4] = { { 1, 2, 3 }, { 4, 5 } };//��ά�����п���ʡ�ԣ��в���ʡ�ԡ�
//	int i = 0;
//	for (i = 0; i < 3; i++)
//	{
//		int j = 0;
//		for (j = 0; j < 4; j++)
//		{
//			printf("%d", arr[i][j]);//����Ԫ�أ��������С�
//		}
//		printf("\n");
//	}
//	return 0;
//}


//int main()
//{
//	int arr[3][4] = { { 1, 2, 3 }, { 4, 5 } };//��ά�����п���ʡ�ԣ��в���ʡ�ԡ�
//	int i = 0;
//	for (i = 0; i < 3; i++)
//	{
//		int j = 0;
//		for (j = 0; j < 4; j++)
//		{
//			printf("&arr[%d][%d]=%p\n",i,j, arr[i][j]);  
//		}
//		printf("\n");
//	}
//	return 0;
//}



//ð�����������Ƿ��������򣬶���һ��һ�ε��š���������Ч�ʵͣ�
//void bubble_sort(int arr[],int sz)
//{
//	//ȷ��ð�����������
//	int i = 0;
//	for (i = 0; i < sz - 1; i++)
//	{
//		//ÿһ��ð����������ݡ�
//		int j = 0;
//		for (j = 0; j < sz-1-i; j++) //ȷ��ÿһ�˱ȽϵĶ�����
//		{
//			if (arr[j]> arr[j + 1])
//			{ 
//				int temp = arr[j];
//				arr[j] = arr[j + 1];
//				arr[j + 1] = temp;
//			}
//		}
//	}
//}
//int main()
//{
//	int i = 0;
//	int arr[] = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
//	int sz = sizeof(arr) / sizeof(arr[0]);
//	bubble_sort(arr,sz); //ð��������
//	for (i = 0; i < sz; i++)
//	{
//		printf("%d ", arr[i]);
//	}
//	return 0;
//}


//ð����������Ѿ��������򣩣���ô��������
//void bubble_sort(int arr[], int sz)
//{
//	//ȷ��ð�����������
//	int i = 0;
//	for (i = 0; i < sz - 1; i++)
//	{
//		//ÿһ��ð����������ݡ�
//		int j = 0;
//		int flag = 1;//�����Ѿ��������򣩣�
//		for (j = 0; j < sz - 1 - i; j++) //ȷ��ÿһ�˱ȽϵĶ�����
//		{
//			if (arr[j]> arr[j + 1])
//			{
//				int temp = arr[j];
//				arr[j] = arr[j + 1];
//				arr[j + 1] = temp;
//				flag = 0;//���������������ʵ������ȫ����ġ�
//			}
//		}
//		if (flag == 1)
//		{
//			break;
//		}
//	}
//}
//int main()
//{
//	int i = 0;
//	int arr[] = { 0,1,2,3,4,5,6,7,8,9 };
//	int sz = sizeof(arr) / sizeof(arr[0]);
//	bubble_sort(arr, sz); //ð��������
//	for (i = 0; i < sz; i++)
//	{
//		printf("%d ", arr[i]);
//	}
//	return 0;
//}


//int main()
//{
//	int arr[] = { 1, 2, 3, 4, 5, 6, 7 };
//	printf("%p\n", arr);
//	printf("%p\n", &arr[0]);
//	//������������Ԫ�ص�ַ
//	printf("%d\n", *arr);
//	return 0;
//}


//int main()
//{
//	int arr[] = { 1, 2, 3, 4, 5, 6, 7 };
//	int sz = sizeof(arr) / sizeof(arr[0]);
//	//1.sizeof(������)  -��������ʾ�������飬sizeof�����飩���������������Ĵ�С����λ���ֽڡ�
//	
//	
//	
//	
//	printf("%p\n", arr);//arr+1����4
//	printf("%p\n", &arr[0]); //&arr[0]+1����4
//	printf("%p\n", &arr);//�͵�һ��Ԫ�صĵ�ַ��ͬ���������𡣴��������������Ĵ�ռ䣨������������Ԫ�صĿռ䣩��ַ������&arr+1,��������߸�����Ԫ�أ����ַ+28.
//	//2.&������ -�����������������飬ȡ��������������ĵ�ַ
//
//
//	//printf("%p\n", arr);
//	//printf("%p\n", &arr[0]);
//	////������������Ԫ�ص�ַ
//	//printf("%d\n", *arr);
//	return 0;
//}


int main()
{

	return 0;
}