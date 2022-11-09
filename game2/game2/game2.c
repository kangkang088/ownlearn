#define _CRT_SECURE_NO_WARNINGS 1
#include"game2.h"
void initboard(char board[ROWS][COLS], int rows, int cols,char set)
{
	int i = 0;
	int j = 0;
	for (i = 0; i < rows;i++)
	{
		for (j = 0; j < cols; j++)
		{
			board[i][j] = set;
		}
	}
}
void displayboard(char board[ROWS][COLS], int row, int col)
{
	int i = 0;
	int j = 0;
	printf("----------------ɨ����Ϸ-----------\n");
	//��ӡ�к�
	for (i = 0; i <= col; i++)  //�Ż����棬���ڿ�����
	{
		printf("%d ", i);
	}
	printf("\n");
	for (i = 1; i <= row; i++)
	{
		printf("%d ", i);//�Ż�����,���ڿ�����
		for (j = 1; j <= col; j++)
		{
			printf("%c ", board[i][j]);
		}
		printf("\n");
	}
	printf("----------------ɨ����Ϸ-----------\n");
}

void setmine(char mine[ROWS][COLS], int row, int col)
{
	//����ʮ����
	int count = easy_count;
	while (count)
	{
		//��������±�
		int x = rand()%row+1;
		int y = rand()%col+1;
		if (mine[x][y] == '0')
		{
			mine[x][y] = '1';
			count--;
		}
	}
}



static int get_mine_count(char mine[ROWS][COLS], int x, int y)
{
	return mine[x - 1][y] + mine[x - 1][y - 1] + mine[x][y - 1] +
		mine[x + 1][y - 1] +
		mine[x + 1][y] +
		mine[x + 1][y + 1] +
		mine[x][y + 1] +
		mine[x - 1][y + 1] - 8 * '0';//�ַ�'1'-'0'ת��Ϊ���֡���������������
}
void findmine(char mine[ROWS][COLS], char show[ROWS][COLS], int row, int col)
{
	//1.�����Ų������
	//2.������괦�ǲ�����
	//��1�����ף�ը��-��Ϸ����
	//��2�������ף�ͳ��������Χ�׵�����-�洢�Ų��׵���Ϣ��show����-��Ϸ����
	int x = 0;
	int y = 0;
	int win = 0;
	while (win<row*col-easy_count)
	{

		printf("������Ҫ�Ų�����꣺");
		scanf("%d%d", &x, &y);//x>=1,x<=9;y>=1,y<=9.
		//�ж�����ĺϷ���
		if (x >= 1 && x <= row && y >= 1 && y <= col)
		{
			if (mine[x][y] == '1')
			{
				printf("���ź����㱻ը����");
				displayboard(mine, row, col);
				break;
			}
			else
			{
				//�����ף�ͳ�Ƹ�������Χ�м�����
				int ret = get_mine_count(mine,x,y);//�ú���ֻ��Ϊ��֧��findmine�����Բ�ȥͷ�ļ�
				show[x][y] = ret+'0'; //������ת��Ϊ�ַ�
				//��ʾ���Ų����Ϣ
				displayboard(show, row, col);
				win++;
			}
		}
		else
		{
			printf("���겻�Ϸ�������������\n");
		}
	}
	if (win == row*col - easy_count)
	{
		printf("��ϲ�������׳ɹ�\n");
		displayboard(mine, row, col);
	}
}