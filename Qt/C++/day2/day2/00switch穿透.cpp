//#include <iostream>
//using namespace std;
//
//int main()
//{
//	int year, month; int days = 0;
//	cout << "���������" << endl;
//	cin >> year;
//	cout << "�������·�" << endl;
//	cin >> month;
//	switch (month)
//	{
//	case 12: days += 30;
//	case 11: days += 31;
//	case 10: days += 30;
//	case 9: days += 31;
//	case 8: days += 31;
//	case 7: days += 30;
//	case 6: days += 31;
//	case 5: days += 30;
//	case 4: days += 31;
//	case 3: days += year % 4 == 0 && year % 100 != 0 || year % 400 == 0 ? 29 : 28;
//	case 2: days += 31;
//	}
//
//	cout << days << endl;
//}