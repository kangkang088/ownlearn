#define _CRT_SECURE_NO_WARNINGS 1
#include <stdio.h>
//int main()
//{
//	int ch = 0;
//	//EOF end of file �ļ�������־
//	while ((ch = getchar()) != EOF)
//	{
//		putchar(ch);
//	}
//	return 0;
//}


//int main()
//{
//	int ret = 0;
//	int ch = 0;                       //���뺯�����ȼ�����뻺�����������뻺��������ȡֵ�����������Ժ�scanf����һ���֣����ǰ��س���Ҳ�����һ��ת���ַ�\n;
//	char password[] = { 0 };
//	printf("���������룺 ");
//	scanf("%s", password);         //����123456���������������123456\n,����123456 ABCD,���뻺���������ʣ��  �ո�ABCD\n��scanfֻ���ȡ�ո�ǰ����ַ���
//	while (ch = getchar() != '\n');   //��ѭ����������һֱ��ȡ���뻺����������ַ���ȡ�ߣ�ֱ��ȫ�����ߣ����������getchar�����뻺��������õ��κ�ֵ��
//	{
//		;       //Ϊʲô��ѭ������Ϊgetcharֻ�ܻ�ȡ�ַ������ܻ�ȡ�ַ�����
//	}
//	printf("��ȷ�ϣ�Y/N��:");
//	ret = getchar();  //���û�������ѭ������������123456֮�󣬻س�����Ȼ�����һ���ַ�  \n(����)����ô���뻺�������滹��һ��ת���ַ�\n,��ʱret���ȡ��ֵ�����������û�л�������Y/N��ֱ������else������ȷ��
//	if (ret = 'Y')   
//		printf("ȷ�ϳɹ�\n");
//	else
//		printf("����ȷ��\n");
//	return 0;
//}
int main()
{
	int ch = 0;
	while ((ch = getchar()) != EOF)
	{

		if (ch<'0' || ch>'9')
			continue;
		putchar(ch);
	}
	return 0;
}