#define _CRT_SECURE_NO_WARNINGS 1
#include<stdio.h>
//�±����ò�����
//int main()
//{
//	int arr[10] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//	printf("$d\n", arr[4]);//[]�����±����ò�����
//	//[]�Ĳ�������������arr��[]��
//	return 0;
//}


//�������ò�����
//��������
//int Add(int x, int y)
//{
//	return x + y;
//}
//void test()
//{}
//int main()
//{
//	int a = 10;
//	int b = 20;
//	//��������
//	int ret = Add(a, b);//�������Ǻ������ò�������û�оͲ��Ǻ������á������������������в���
//	text();//����������ֻ��һ��test���޲���
//	return 0;
//}



//�ṹ��Ա���ʲ�����
//struct BOOK
//{
//	//�ṹ���Ա
//	char name[20];
//	char id[20];
//	int price;
//
//};
//int main()
//{
//	struct BOOK b = {"c����","05151",55};
//	struct BOOK* pb = &b; //����һ���ṹ�����͵�ָ��
//	//�ṹ�������.��Ա��
//	printf("������%s\n", b.name); //b���Ի��ɣ�*pb��
//	printf("��ţ�%s\n", b.id);
//	printf("���ۣ�%d\n", b.price);
//
//	//�ṹ��ָ��->��Ա��
//	printf("������%s\n", pb->name);
//	printf("��ţ�%s\n", pb->id);
//	printf("���ۣ�%d\n", pb->price);
//	return 0;
//}



//int main()
//{
//	char a = 3;
//	//00000011
//	char b = 127;
//	//01111111
//	char c = a + b;
//	//a��b����char���͵ģ���û�дﵽһ��int�Ĵ�С
//	//������������
//	//���������������͵ķ���λ���������������з�������������0��������1. �޷�������������������0.
//	//00000000000000000000000000000011 -a
//	//00000000000000000000000001111111 -b
//	//00000000000000000000000010000010 -c
//	//�ض�
//	//10000010 -c�����룩
//
//	//c���з���char�������λ�Ƿ���λ����c�Ǹ���
//	
//	printf("%d\n", c);//-126,
//	//Ҫ��������Ϊint�Ĵ�С�������
//	//11111111111111111111111110000010�����룩
//	//11111111111111111111111110000001�����룩
//	//10000000000000000000000001111110��ԭ�룩
//	//-126
//	return 0;
//}



//int main()
//{
//	char c = 1;
//	printf("%d\n", sizeof(c));//������û�в�������
//	printf("%d\n", sizeof(+c));//�������㣬������������Ϊint
//	printf("%d\n", sizeof(-c));
//	return 0;
//}



//int main()
//{
//	char a = 0xb6;  
//	short b = 0xb600;//�����0xb60����short��ȡֵ��Χ�ڣ���ضϵ�ʱ�򲻻���Ӱ�죬�����b
//	int c = 0xb6000000;
//	if (a == 0xb6)  //���㣬����������0xb6������Χ���ض���Ӱ��
//	{
//		printf("a");
//	}
//	if (b == 0xb600)//���㣬����������0xb600������Χ���ض���Ӱ��.�����b��Ϊ�޷������ͣ���0xb600����뷶Χ���ض���Ӱ��
//	{
//		printf("b");
//	}
//	if (c == 0xb6000000)//���㣬����������.����Ӽ���0������Χ��int���ͷ�Χ�����㣬��Ҳ��������������c�����������������ֻ��int��С���µ�����
//	{
//		printf("c");
//	}
//	return 0;
//}

 

//����һ���������飬��ɶ�����Ĳ���
//1.ʵ�ֺ���init��������ʼ������ȫΪ0
//2.ʵ��print��������ӡ�����ÿ��Ԫ��
//3.ʵ��reverse���������������Ԫ�ص�����
//void init(int arr[],int sz)
//{
//	int i = 1;
//	for (i = 0; i < sz; i++)
//	{
//		arr[i] = 0;
//	}
//}
//void print(int arr[], int sz)
//{
//	int i = 0;
//	for (i = 0; i < sz; i++)
//	{
//		printf("%d ", arr[i]);
//	}
//	printf("\n");
//}
//void reverse(int arr[], int sz)
//{
//	int left = 0;
//	int right = sz-1;	
//	while (left < right)
//	{
//		int tmp = arr[left];
//		arr[left] = arr[right];
//		arr[right] = tmp;
//		left++;
//		right--;
//	}
//}
//int main()
//{
//	int arr[10] = { 1,2,3,4,5,6,7,8,9,10 };
//	int sz = sizeof(arr) / sizeof(arr[0]);
//	reverse(arr, sz);
//	print(arr, sz);
//	init(arr,sz);
//	print(arr, sz);
//	return 0;
//}




//��������A������B�е����ݣ���������һ����
//void swap(int A[], int B[], int sz)
//{
//	int i = 0;
//	for (i = 0; i < sz; i++)
//	{
//		int c = A[i];
//		A[i] = B[i];
//		B[i] = c;
//	}
//}
//void print(int A[], int sz)
//{
//	int i = 0;
//	for (i = 0; i < sz; i++)
//	{
//		printf("%d ", A[i]);
//	}
//}
//int main()
//{
//	int A[10] = { 5, 7, 8, 4, 9, 1, 6, 16, 4, 54 };
//	int B[10] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//	int sz = sizeof(A) / sizeof(A[0]);
//	swap(A, B, sz);
//	print(A, sz);
//	printf("\n");
//	print(B, sz);
//	return 0;
//}
//int main()
//{
//	int arr1[] = { 1, 3, 5, 7, 9 };
//	int arr2[] = { 2, 4, 6, 8, 10 };
//	int sz = sizeof(arr1) / sizeof(arr1[0]);
//	int i = 0;
//	for (i = 0; i < sz; i++)
//	{
//		int tmp = arr1[i];
//		arr1[i] = arr2[i];
//		arr2[i] = tmp;
//	}
//	for (i = 0; i < sz; i++)
//	{
//		printf("%d ", arr1[i]);
//	}
//	printf("\n");
//	for (i = 0; i < sz; i++)
//	{
//		printf("%d ", arr2[i]);
//	}
//	return 0;
//}


int main()
{

	return 0;
}