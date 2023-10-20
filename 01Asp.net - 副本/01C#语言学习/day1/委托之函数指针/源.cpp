#include <iostream>
#include <fstream>
#include <vector>
#include <algorithm>
#include <string>
#include <deque>
#include <stack>
#include <queue>
#include <list>
#include <set>
#include <map>
#include <numeric>

typedef int (*Calc)(int a, int b);

int Add(int a, int b)
{
	return a + b;
}
int Sub(int a, int b)
{
	return a - b;
}
int main()
{
	int x = 100;
	int y = 200;
	int z = 0;

	Calc function1 = &Add;
	Calc function2 = &Sub;

	z = function1(x, y);
	printf("%d + %d = %d\n", x, y, z);
	z = function2(x, y);
	printf("%d + %d = %d\n", x, y, z);
	system("pause");
}