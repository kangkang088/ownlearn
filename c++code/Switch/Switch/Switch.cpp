#include <iostream>
using namespace std;
int main()
{
	int sc;
	cout << "请输入身材的值：";
	cin >> sc;
	switch (sc)
	{
	case 1:
		cout << "火辣\n";
		break;
	case 2:
		cout << "适中\n";
		break;
	case 3:
		cout << "丰满\n";
		break;
	case 4:
		cout << "苗条\n";
		break;
	default:
		cout << "其他\n";
	}
}