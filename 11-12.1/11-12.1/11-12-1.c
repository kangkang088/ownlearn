#define _CRT_SECURE_NO_WARNINGS 1
#include<stdio.h>



//实用调试技巧
int main()
{
	int arr[10] = { 0 };
	int sz = sizeof(arr) / sizeof(arr[0]);
	int i = 0;
	for (i = 0; i < sz; i++)
	{
		arr[i] = i+1;

	}
 	for (i = 0; i < sz; i++)
	{
		printf("%d ", arr[i]);
	}
	return 0;
}