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

//int main()
//{
//	int a = 0;
//	scanf("%d", &a);
//	while (a >= 1 && a <= 100)
//	{
//		if (a % 2 == 1)
//			printf("����%d\n",a);
//		a++;
//		
//	}
//	return 0;
//}
//int main()
//{
//	int day = 0;
//	scanf("%d", &day);
//	switch (day)
//	{
//	case 1:
//		printf("����һ\n");
//		break;
//	case 2:
//		printf("���ڶ�\n");
//		break;
//	case 3:
//		printf("������\n");
//		break;
//	case 4:
//		printf("������\n");
//		break;
//	case 5:
//		printf("������\n");
//		break;
//	case 6:
//		printf("������\n");
//		break;
//	case 7:
//		printf("������\n");
//		break;
//	}
//	return 0;
//}

//1-5�ǹ����գ�6-7��Ϣ��
//д��һ�������� 

//int main()
//{
//	int day = 0;
//	scanf("%d", &day);
//	switch (day)
//	{
//	case 1:
//		printf("������\n");
//		break;
//	case 2:
//		printf("������n");
//		break;
//	case 3:
//		printf("������n");
//		break;
//	case 4:
//		printf("������n");
//		break;
//	case 5:
//		printf("������\n");
//		break;
//	case 6:
//		printf("��Ϣ��\n");
//		break;
//	case 7:
//		printf("��Ϣ��n");
//		break;
//	}
//	return 0;
//}

//д��2���򵥣�


//int main()
//{
//	int day = 0;
//	scanf("%d", &day);
//	switch (day)
//	{
//	case 1:		
//	case 2:	
//	case 3:
//	case 4:		
//	case 5:
//		printf("������\n");
//		break;
//	case 6:		
//	case 7:
//		printf("��Ϣ��n");
//		break;
//  default:   //  ���п��ޣ���Ҫ��ʱ����
//		printf("�������\n");  //��������ֵ�������ϼ������֮�У�������default��  ���Է������棬Ҳ���Է����棬��case����˳��
//	break;
//	}
//	return 0;
//}
//
//int main()
//{
//	/*while (���ʽ)
//		ѭ����䣺*/
//	/*while (1)
//		printf("hehe\n");*/
//	int i = 1;
//	while (i <= 10)
//	{
//		printf("%d\n", i);
//		i++;
//	}
//	return 0;
//}
//
//int main()
//{
//	/*while (���ʽ)
//	ѭ����䣺*/
//	/*while (1)
//	printf("hehe\n");*/
//	int i = 1;
//	while (i <= 10)
//	{
//		if (i == 5)
//			continue;  //��ѭ������������ֹѭ���б���ѭ������Ĵ��룬��i����5ʱ������if������continue��ֱ����ֹ����Ĵ��룬��������while������ʱiû�иı䣬��������if����������while���γ���ѭ��
//		printf("%d\n", i);
//		i++;
//	}
//	return 0;
//}


//int main()
//{
//	/*while (���ʽ)
//	ѭ����䣺*/
//	/*while (1)
//	printf("hehe\n");*/
//	int i = 1;
//	while (i <= 10)
//	{
//		i++;  //�ı�i++��λ�ã����������ѭ������i=5ʱ������if��continue��ֹ�������䣬����while���Ƚ���i++����ʱi��ֵ�ı䣬if���������㣬����ִ�к�������
//		if (i == 5)
//			continue;
//		printf("%d\n", i);
//		
//	}
//	return 0;
//}
//int main()
//{
//	int ch = 0;
//	// ctrl+z���ȡEOF��ֹͣ   ch��ȡ��EOF����ʱEOF ��= EOF Ϊ�٣�����  �������һ������EOF���൱��getchar��ȡ�������ַ�����Ȼ�����EOF���ҳ��򲻻�ֹͣ��
//	//EOF -end of file  �ļ�������־
//	while ((ch=getchar()) != EOF)
//	{
//		putchar(ch);
//	}
//
//	/*putchar(ch);
//	printf("%c\n", ch);*/
//	return 0;
//}