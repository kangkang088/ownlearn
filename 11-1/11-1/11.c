#define _CRT_SECURE_NO_WARNINGS 1
#include <stdio.h>
//��һ��
//int main()
//{
//	int age = 100;
//	if (age < 18)
//		printf("��ʱδ����\n");
//	else if (age >= 18 && age < 28)
//		printf("����\n");
//	else if (age >= 28 && age < 50)
//		printf("��ʱΪ׳��\n");
//	else if (age >= 50 && age < 90)
//		printf("��ʱΪ����\n");
//	/*else*/     //�����else����ȥ��
//		printf("��ʱ�ϲ���\n");//Ҳ����ϲ���
//	return 0;
//}
////�ڶ���
//int main()
//{
//	int age = 18;
//	if (age < 18)
//		printf("��ʱδ����");
//	else{
//		if (age >= 18 && age < 28)
//			printf("����\n");
//		else if (age >= 28 && age < 50)
//			printf("��ʱΪ׳��\n");
//		else if (age >= 50 && age < 90)
//			printf("��ʱΪ����\n");
//		else
//			printf("�ϲ���\n");
//	    }
//	return 0;
//
//}


//  0Ϊ�٣�����Ϊ�档


//if�����ƶ������ʱ��Ҫ��{}�����

//if (���ʽ)
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
//	   else//elseֻ��������δƥ���ifƥ��
//		printf("hah\n");
//	return 0;
//}




//int main()
//{
//	int num = 4;
//	if (5 = = num)//�жϳ����ͱ��������������
//		printf("hehe\n");
//	
//	
//	//if (num = 5)
//	//{
//	//	printf("hehe\n");//��ʱ��Ȼ���ӡ�Ǻǣ���Ϊif�����Ǹ�ֵ=;bug
//	//}
//	return 0;
//}


//int main()
//{
//	int i = 0;
//	scanf("%d", &i);
//	if (1 == i % 2)
//	{
//		printf("����\n");
//	}
//	else
//	{
//		printf("ż��\n");
//	}
//		return 0;
//}

int main()
{
	int a = 0;
	scanf("%d", &a);
	while (a >= 1 && a <= 100)
	{
		if (a % 2 == 1)
			printf("����%d\n",a);
		a++;
		
	}
	return 0;
}