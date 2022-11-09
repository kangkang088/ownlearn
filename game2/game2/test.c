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
	char mine[ROWS][COLS] = { 0 };//存放布置好的雷的信息；
	char show[ROWS][COLS] = { 0 };//存放排查出来的雷的信息；
	//初始化棋盘
	initboard(mine, ROWS, COLS,'0');  
	initboard(show, ROWS, COLS,'*');
	//打印棋盘
	// displayboard(mine,ROW,COL);  //正常游戏中不会打印这个显示雷的数组
	displayboard(show,ROW,COL);
	//布置雷
	setmine(mine,ROW,COL);
	//displayboard(mine, ROW, COL);  //不给看  显示随机雷的位置
	
	//排查雷
	findmine(mine,show,ROW,COL);  //mine中得到的信息给show,只在9*9中查找

}
int main()
{
	int input = 0;
	srand((unsigned int)time(NULL));
	do
	{
		menu();
		printf("请选择：");
		scanf("%d", &input);
		switch (input)
		{
		case 1:
			game();//扫雷游戏
			break;
		case 0:
			break;
		default:
			printf("选择错误，请重新选择\n");
			break;
		}
	} while (input);
	return 0;
}