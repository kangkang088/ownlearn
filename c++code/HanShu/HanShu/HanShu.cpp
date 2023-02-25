#include <iostream>
using namespace std;
int max(int a, int b);
void print(string str);
int n = 10;
int main()
{
	
	cout << max(5,8) << endl;
	print("超女妹妹");

}

int max(int a, int b)
{
	int c;
	c = a > b ? a : b;

	return c;
}

void print(string str)
{
	cout << str << endl;
	return;
}
