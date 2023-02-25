#include <iostream>
using namespace std;
/*int main()
{
	for (int i = 1; i <= 10; i++)
	{
		cout << "这是第" << i << "名超女的编号" << endl;
	}
}*/

/*int main()
{
	for  (int i = 1;  i < 5; i++)
	{
		for (int m = 1; m < 4; m++) 
		{
			cout << "这是第" << i << "小组的第" << m << "个超女" << endl;
		}
	}
}*/

int main()
{
	for (int i = 1; i < 10 ; i++)
	{
		for (int m = 1; m <= i; m++)
		{
			cout << m << "*" << i << "=" << (i * m) << "  ";
		}
		cout << endl;
	}
}
