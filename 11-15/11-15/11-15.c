#define _CRT_SECURE_NO_WARNINGS 1
#include<stdio.h>
//int main()
//{
//	int arr[] = { 1, 2, 3, 4, 5 };
//	short* p = (short*)arr;//p�Ƕ�����ָ�룬ÿ�η��������ֽ�
//	//1��int�����ڴ��е���ʽ��00000000000000000000000000000001  ת����16���ƾ���00 00 00 01�����ڴ���С�˴洢����01 00 00 00��
//	//ͬ��  02 00 00 00    03 00 00 00    04 00 00 00  05 00 00 00
//	int i = 0;
//	for (i = 0; i < 4; i++)
//	{
//		*(p + i) = 0;//ע����short�͵�ָ�������ÿ�η��������ֽڣ���� 00 00 00 00 00 00 00 00 00 03 00 00 00 04 00 00 00 05 00 00 00
//	}
//	for (i = 0; i < 5; i++)
//	{
//		printf("%d ", arr[i]);
//	}
//	return 0;
//}
//
//
//�����������������������
//int main()
//{
//	int a,b;
//	scanf("%d%d", &a, &b);
//	a = a + b;
//	b = a - b;
//	a = a - b;
//	printf("a=%d,b=%d\n", a, b);
//
//	return 0;
//}
//
//����һ���ַ��������Ӧ��ASCII��ֵ
//int main()
//{
//	char c = 0;	//char�ͱ��������������������������һ���ֽڵĳ��ȣ�Ҳ����8λ�����ơ�
//				//��%d��ָ��int���͵�ת������Ҳ����4���ֽڣ���Ҫ��ȷ����ʾchar���͵Ļ���Ҫ��%���棬d��ǰ�����һ������ָʾ����
//	scanf("%c", &c);
//	printf("%hhd\n",c); //%hhd = char��%hd = short��%d = int��%ld = long��%lld = long long��
//						//printf��������Ὣint���͵ȼ����µ������Զ�ת��Ϊint����
//						//
//	return 0;
//}
//
//
//���д��ڵ���100���������ļ���ʱ���������£�
//
//1.       ֻ���������������λ�����磺��KiKi��˵1234�ȼ���34��
//
//2.       ������������ڵ��� 100�� ��ôKIKIҲ�������������������λ���������λ��ʮλΪ0����ֻ������λ��
//
//���磺45 + 80 = 25
//
//Ҫ������Ǹ����� a�� b��ģ��KiKi������������� a + b ��ֵ��
//int main()
//{
//	unsigned int a = 0;
//	unsigned int b = 0;
//	unsigned int c = 0;
//	scanf("%d %d", &a, &b);
//	c = a + b;
//	if (a >= 100)
//	{
//		a = a % 100;
//	}
//	else
//	{
//		a = a;
//	}
//	if (b >= 100)
//	{
//		b = b % 100;
//	}
//	else
//		b = b;
//	if (c >= 100)
//	{
//		c = c % 100;
//	}
//	else
//		c = c;
//	printf("%d\n", c);
//	return 0;
//}
//
//
//��һ����������Ҫ������ø������ĸ�λ
//int main()
//{
//	float a = 0;
//	scanf("%f", &a);
//	int c = 0;
//	c = (int)a % 10;
//	printf("%d\n", c);
//	return 0;
//}
//
//
//
//һ��3.156*10^7��,�������䣬�����Ӧ������
//int main()
//{
//	int age = 0;
//	scanf("%d", &age);
//	int miao = age * 3156;
//
//	printf("%d0000\n", miao);
//	return 0;
//}
//
//
//�������� seconds ������ת����Сʱ�����Ӻ��롣
//int main()
//{
//	int seconds = 0;
//	int a = 0;
//	int b = 0;
//	int c = 0;
//	scanf("%d", &seconds);
//	a = seconds / 3600;
//	b = (seconds % 3600) / 60;
//	c = seconds % 3600 % 60;
//	printf("%d %d %d", a, b, c);
//		return 0;
//}
//
//
//���������ε��ܳ������
//#include<math.h>
//int main()
//{
//	int a = 0;
//	int b = 0;
//	int c = 0;
//	int d = 0;
//	scanf("%d%d%d", &a, &b, &c);
//	if (a + b > c&&a + c > b&&b + c > a)
//	{
//		float circumference = a + b + c;
//		float d = circumference / 2;
//		float area = sqrt(d*(d - a) * (d - b) * (d - c));
//		printf("circumference=%.2f area=%.2f\n", circumference,area);
//	}
//	return 0;
//}
//
//
//
//����һ������İ뾶��������������������������ʽΪ V = 4/3*��r3������ �� = 3.1415926��
//
//
//���ݷ�Χ������һ������ֵ 0 \le n \le 15 \0��n��15
//int main()
//{
//	double a = 0;
//	scanf("%lf", &a);//scanf�У�double��%lf��float��%f��
//	double v = 0;
//	v = 4.000 / 3.000 * 3.1415926*a*a*a;
//
//	printf("%.3f", v);
//
//	return 0;
//}


//ʵ����ĸ�Ĵ�Сдת��
//ASCII��32
//int main()
//{
//	char x = 0;
//	while ((x = getchar()) != EOF)//EOF������������ctrl+z��ֹͣ���У��������Զ��������������ǡ�\n����ֻ��һ�Σ���������{}�ڲ���һ��geichar�����ˡ�
//	{
//		getchar();//�����ǻ�ȡ��\n����
//		putchar(x + 32);//�������x��
//		printf("\n");
//	}
//	return 0;
//}