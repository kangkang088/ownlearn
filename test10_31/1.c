#define _CRT_SECURE_NO_WARNINGS 1
#include <stdio.h>
//int main()
//{
//	printf("%d\n", sizeof(char*));
//	printf("%d\n", sizeof(int*));
//	printf("%d\n", sizeof(double*));
//	printf("%d\n", sizeof(float*));
//	return 0;
//}
struct BOOK
{
	char name[20];
	short price;
};
int main()
{
	struct BOOK a = { "c����",25 };

	struct BOOK* b = &a;
	printf("%s\n", b->name);
	printf("%d\n", b->price);
	a.price = 2;
	printf("%d\n", a.price);
	printf("%s\n", a.name);



	/*printf("%s\n", a.name);
	printf("%dԪ\n", a.price);
	a.price = 38;
	printf("�޸�֮��ļ۸�%dԪ\n", a.price);*/
	return 0;
}