#define ROW 9
#define COL 9
#define easy_count 10 //�׵�����
#include<stdio.h>
#include<stdlib.h>
#include<time.h>

#define ROWS ROW+2
#define COLS COL+2


//��ʼ������
void initboard(char board[ROWS][COLS],int rows,int cols,char set);
//��ӡ����
void displayboard(char board[ROWS][COLS],int row,int col);

//������
void setmine(char mine[ROWS][COLS], int row, int col);

//�Ų���
void findmine(char mine[ROWS][COLS], char show[ROWS][COLS], int row, int col);