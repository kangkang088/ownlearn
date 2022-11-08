#define _CRT_SECURE_NO_WARNINGS 1

#include"game1.h"
void menu()
{
	printf("************************\n");
	printf("****1.play  2.exit *****\n");
	printf("************************\n");
}
void game()//游戏的整个算法实现
{
	//存放玩家和电脑走出的棋盘信息。
	char board[ROW][COL] = {0};  //全部空格。
	//棋盘初始化
	InitBoard(board, ROW, COL);
	//打印棋盘
	DisplayBoard(board,ROW,COL);
	

}
void test()
{
	int input = 0;
	do
	{
		menu;
		printf("请选择：");
		scanf("%d", &input);
		switch (input)
		{
		case 1:
			printf("三子棋\n");
			game();
			break;
		case 0:
			printf("退出游戏\n");
			break;
		default:
			printf("选择错误，请重新选择！\n");
			break;
		}
	} while (input);
}
int main()
{
	test();
	return 0;
}