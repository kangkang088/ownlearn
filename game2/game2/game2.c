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
	printf("----------------扫雷游戏-----------\n");
	//打印列号
	for (i = 0; i <= col; i++)  //优化界面，便于看列数
	{
		printf("%d ", i);
	}
	printf("\n");
	for (i = 1; i <= row; i++)
	{
		printf("%d ", i);//优化界面,便于看行数
		for (j = 1; j <= col; j++)
		{
			printf("%c ", board[i][j]);
		}
		printf("\n");
	}
	printf("----------------扫雷游戏-----------\n");
}

void setmine(char mine[ROWS][COLS], int row, int col)
{
	//布置十个雷
	int count = easy_count;
	while (count)
	{
		//生成随机下标
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
		mine[x - 1][y + 1] - 8 * '0';//字符'1'-'0'转化为数字。加起来就是雷数
}
void findmine(char mine[ROWS][COLS], char show[ROWS][COLS], int row, int col)
{
	//1.输入排查的坐标
	//2.检查坐标处是不是雷
	//（1）是雷：炸死-游戏结束
	//（2）不是雷：统计坐标周围雷的数量-存储排查雷的信息到show数组-游戏继续
	int x = 0;
	int y = 0;
	int win = 0;
	while (win<row*col-easy_count)
	{

		printf("请输入要排查的坐标：");
		scanf("%d%d", &x, &y);//x>=1,x<=9;y>=1,y<=9.
		//判断坐标的合法性
		if (x >= 1 && x <= row && y >= 1 && y <= col)
		{
			if (mine[x][y] == '1')
			{
				printf("很遗憾，你被炸死了");
				displayboard(mine, row, col);
				break;
			}
			else
			{
				//不是雷，统计该坐标周围有几个雷
				int ret = get_mine_count(mine,x,y);//该函数只是为了支持findmine，所以不去头文件
				show[x][y] = ret+'0'; //将数字转换为字符
				//显示出排查的信息
				displayboard(show, row, col);
				win++;
			}
		}
		else
		{
			printf("坐标不合法，请重新输入\n");
		}
	}
	if (win == row*col - easy_count)
	{
		printf("恭喜您，排雷成功\n");
		displayboard(mine, row, col);
	}
}