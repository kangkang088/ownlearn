#define ROW 3
#define COL 3


#include<stdio.h>
#include<stdlib.h>
#include<math.h>



//����
void InitBoard(int board[ROW][COL], int row, int col);
void DisplayBoard(char board[ROW][COL], int row, int col);
void playermove(char board[ROW][COL], int row, int col);
void computermove(char board[ROW][COL], int row, int col);

//��������������Ϸ״̬'��'���Ӯ'*'������Ӯ#��ƽ��'Q'����Ϸ����'C'��
char iswin(char board[ROW][COL], int row, int col);