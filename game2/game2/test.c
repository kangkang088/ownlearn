#define _CRT_SECURE_NO_WARNINGS 1
#include"game2.h"
void menu()
{
	printf("***********************\n");
	printf("**   1.play 0.exit   **\n");
	printf("***********************\n");
}
void game()
{
	char mine[ROWS][COLS] = { 0 };//��Ų��úõ��׵���Ϣ��
	char show[ROWS][COLS] = { 0 };//����Ų�������׵���Ϣ��
	//��ʼ������
	initboard(mine, ROWS, COLS,'0');  
	initboard(show, ROWS, COLS,'*');
	//��ӡ����
	// displayboard(mine,ROW,COL);  //������Ϸ�в����ӡ�����ʾ�׵�����
	displayboard(show,ROW,COL);
	//������
	setmine(mine,ROW,COL);
	//displayboard(mine, ROW, COL);  //������  ��ʾ����׵�λ��
	
	//�Ų���
	findmine(mine,show,ROW,COL);  //mine�еõ�����Ϣ��show,ֻ��9*9�в���

}
int main()
{
	int input = 0;
	srand((unsigned int)time(NULL));
	do
	{
		menu();
		printf("��ѡ��");
		scanf("%d", &input);
		switch (input)
		{
		case 1:
			game();//ɨ����Ϸ
			break;
		case 0:
			break;
		default:
			printf("ѡ�����������ѡ��\n");
			break;
		}
	} while (input);
	return 0;
}