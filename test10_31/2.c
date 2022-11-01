#define _CRT_SECURE_NO_WARNINGS 1
#include <stdio.h>
#include <string.h>
int main()
{
	char p[5] = { 1, 2, 3, 4, 5 };
	printf("%d\n", p[1]);
	char* b = &p;
	printf("%p\n", b);
	printf("%d\n", *b + 3);
	
	return 0;
}