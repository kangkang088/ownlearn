#define ROW 3
#define COL 3


#include<stdio.h>
#include<stdlib.h>
#include<math.h>



//声明
void InitBoard(int board[ROW][COL], int row, int col);
void DisplayBoard(char board[ROW][COL], int row, int col);
void playermove(char board[ROW][COL], int row, int col);
void computermove(char board[ROW][COL], int row, int col);

//告诉我们四种游戏状态'，'玩家赢'*'，电脑赢#，平局'Q'，游戏继续'C'。
char iswin(char board[ROW][COL], int row, int col);