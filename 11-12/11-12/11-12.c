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


//ָ�����͵�����
//1.ָ�����;�����ָ�������ʱ�ķ���Ȩ��
//2.ָ�����;�����ָ����һ���ľ���
//int main()
//{
//	//һ��16���Ʊ�ʾ4��������λ��
//	int a = 0x11223344;
//	//int* pa=&a;
//	//*pa = 0;//���ĸ��ֽ�
//	char* pc = &a;
//	*pc = 0;//��һ���ֽ�
//	return 0;
//}
//int main()
//{
//	int arr[10] = { 0 };
//	int* p = arr;
//	char* pc = arr;
//	printf("%p\n", p);
//	printf("%p\n", p + 1);//��4
//	printf("%p\n", pc);
//	printf("%p\n", pc + 1);//��1
//	return 0;
//}


//int main()
//{
//	int arr[10] = {0};
//	int* p = &arr;
//	int i = 0;
//	for (i = 0; i < 10; i++)  //charһ���ֽ�һ���ֽڵı䣬int�ĸ��ֽ��ĸ��ֽڵı�
//	{
//		*(p + i)=1;
//	}
//	return 0;
//}


//
//int main()
//{
//	//Ұָ��
//	//1.ָ��δ��ʼ��
//	int* p;//�ֲ�ָ��������ֲ���������ʼ����Ĭ�������ֵ��������p����������ַ��
//	*p = 20;//ͨ�������ַ��������ռ䣬�Ƿ������ڴ�
//	return 0;
//}



//int main()
//{
//	//2.ָ��Խ��
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
//	int a = 10;//�ֲ����������뺯������a�Ŀռ�
//	return &a;//����a�ĵ�ַ��p��a�Ŀռ������ͷţ�a���������ڽ���
//}
//int main()
//{
//	//3.ָ��ָ��ռ��ͷ�
//	int* p=test();
//	*p = 20;//�����⣬a�Ŀռ��Ѿ����ͷţ�����ϵͳ����ʱ���ٷ������ڷǷ����ʡ�
//	return 0;
//}



//��α���Ұָ��
//1.ָ���ʼ��
//int main()
//{
//	int* p = NULL;//����֪��ָ���ʼ��ʲô��ַ��ʱ�򣬾ͳ�ʼ��ΪNULL��
//	return 0;
//}
//int main()
//{
//	int a = 10;
//	int* p = &a;//��ȷ֪��ָ���ʼ����ַ
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



//ָ�������ǰ��������ָ��ָ��ͬһ���ռ䣬����һ����
//int main()
//{
//	int arr[10] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//	int* a=&arr[9];
//	int* b=&arr[0];
//	printf("%d\n",&arr[9] - &arr[0]); //ָ��-ָ���������ָ��֮���Ԫ�ظ���
//	return 0;
//}




#include<string.h>
//�����ķ���
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

//�ݹ�
//int my_strlen(char* str)
//{
//	if (*str != '\0')
//	{
//		str++;
//		return 1 + my_strlen(str);
//	}
//		return 0;
//}

//ָ��-ָ��
//int my_strlen(char* str)
//{
//	char* strat = str;//�Ȱ���ʼλ�õ�ַ������
//	while (*str != '\0')//str='\0'��ʱ�򣬲����㣬���õ�ǰstrָ��\0�ĵ�ַ��ȥ��ʼλ��
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



//����ָ��
//int main()
//{
//	int a = 10;
//	int* pa = &a;//pa��ָ�������һ��ָ��
//
//	//paҲ�Ǹ�������Ҳ�����ڴ��п��ٿռ�
//	//&pa��ȡ��pa���ڴ��е���ʼ��ַ��
//	 int* * ppa = &pa; //����ָ��
//	 //ǰ���*����ʵ��int*����������pa��������int*  ���ڶ�����˵��ppa��ָ�����
//
//	 //����ȡ
//	 int** * pppa = &ppa; //����ָ��
//	return 0;
//}



//ָ������
//int main()
//{
//	int arr[10];//�������� - ������͵�����
//	char ch[5];//�ַ����� - ����ַ�������
//
//	//����
//	//ָ������ - ���ָ��
//	int* parr[5] = {0};//����ָ������
//	char* cpl[5] = {0};//�ַ�ָ������
//
//	return 0;
//}



//�ṹ��
//struct A
//{
//	char c;
//	int a;
//	double d;
//};
//struct Stu
//{
//	//��Ա����
//	struct A sb; //Ƕ�׽ṹ��
//	char name[20];
//	int age;
//	char id[20];
//};
//int main()
//{
//	struct Stu s = { {'w',4,3.14},"����", 25, "190611323" }; //��ʼ����Ƕ�׳�ʼ��
//	return 0;
//}



//�ṹ���Ա�ķ���
//struct A
//{
//	char c;
//	int a;
//	double d;
//};
//struct Stu
//{
//	//��Ա����
//	struct A sb; //Ƕ�׽ṹ��
//	char name[20];
//	int age;
//	char id[20];
//};
//int main()
//{
//	struct Stu s = { { 'w', 4, 3.14 }, "����", 25, "190611323" }; //��ʼ����Ƕ�׳�ʼ��
//	printf("%c\n", s.sb.c);
//	struct  Stu* ps = &s;
//	printf("%c\n", (*ps).sb.c); //. 
//	printf("%c\n", ps->sb.c); //-> ָ����
//	return 0;
//}



//�ṹ�崫��
//struct A
//{
//	char c;
//	int a;
//	double d;
//};
//struct Stu
//{
//	//��Ա����
//	struct A sb; //Ƕ�׽ṹ��
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
//		struct Stu s = { { 'w', 4, 3.14 }, "����", 25, "190611323" }; //��ʼ����Ƕ�׳�ʼ��
//		//дһ��������ӡs�����ݣ�
//		print1(s);//��ֵ����  ��������ռ䣬�������ɸı����
//		print2(&s);//��ַ����  ʡ�ռ䣬�����ɸı������Ч�ʸ�
//		return 0;
//}





//ʵ�õ��Լ���
