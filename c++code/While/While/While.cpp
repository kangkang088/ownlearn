#include <iostream>
using namespace std;
/*int main()
{
	int num = 1;
	while (num <= 10)
		cout << "这是第" << num++ << "位超女" << endl;
}*/

//break
//continue
int main()
{
	bool once = true;
	while (true)
	{
		if (once == false)
		{
			cout << "请确认是否继续下一名超女选秀（1-继续，0-停止）";
			bool exist;
			cin >> exist;
			if (exist == false)
			{
				break;
			}
		}
		once = false;
		cout << "请输入超女的颜值（1-漂亮，0-不漂亮）";
		bool face;
		cin >> face;
		if (face)
		{
			cout << "晋级成功" << endl;
			continue;
		}

		cout << "请输入超女的身材（1-火辣，0-不辣）";
		bool body;
		cin >> body;
		if (body)
		{
			cout << "晋级成功" << endl;
		}
	}
}