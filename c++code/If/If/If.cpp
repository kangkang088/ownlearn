#include <iostream>
using namespace std;
/*int main()
{
	bool face;
	cout << "请输入超女的颜值（1-漂亮，0-不漂亮）";
	cin >> face;
	if (face)
	{
		cout << "晋级成功" << endl;
	}
	else
	{
		cout << "晋级失败" << endl;
	}
}*/

/*int main()
{
	//超女选秀，女的，漂亮，身材好
	string sex;
	bool face;
	bool body;

	cout << "请输入超女的性别（男，女）";
	cin >> sex;
	if (sex == "女")
	{
		cout << "请输入超女的颜值（1-漂亮，0-不漂亮）";
		cin >> face;
		if (face)
		{
			cout << "请输入超女的身材（1-好，0-不好）";
			cin >> body;
			if (body) cout << "恭喜晋级" << endl;			
			else cout << "晋级失败" << endl;				
		}
		else cout << "晋级失败" << endl;		
	}
	else cout << "晋级失败" << endl;		
}*/

/*int main()
{
	int body;
	cout << "请输入超女的身材(1-苗条，2-丰满，3-火辣，4-肥胖，5-适中，>5-其他)：";
	cin >> body;
	if (body == 1)        cout << "苗条" << endl;		
	else if (body == 2) cout << "丰满" << endl;		
	else if (body == 3) cout << "火辣" << endl;	
	else if (body == 4) cout << "肥胖" << endl;		
	else if (body == 5) cout << "适中" << endl;		
	else                         cout << "其他" << endl;
		
}*/


/*int main()
{
	int age = 28;
	int height = 170;
	string sc = "火辣";
	string face = "漂亮";
	if (age >25 && age < 30)
	{
		if (height > 165 && height < 175) 
		{
			if (sc == "火辣")
			{
				if (face == "漂亮" || face == "一般")
				{
					cout << "晋级成功" << endl;
				}
			}
		}
	}

	if ((age > 25 && age < 30) && (height > 165 && height < 175) && (sc == "火辣") && (face == "漂亮" || face == "一般"))
	{
		cout << "晋级成功！\n";
	}


	if ((age > 25 && age < 30)                         &&
		(height > 165  && height < 175   )			&&
		(sc == "火辣")                                          &&
		(face == "漂亮" || face == "一般"))
	    {
		cout << "晋级成功" << endl;
	    }
}*/

int main()
{
	int a = 7;
	int b = 9;
	int c = 0;
	c = a > b ? a : b;
	cout << c << endl;

	if (a>b) c = a;		
	else c = b;
		
}