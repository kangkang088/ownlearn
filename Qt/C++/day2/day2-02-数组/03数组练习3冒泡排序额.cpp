//#include <iostream>
//using namespace std;
//
//int main()
//{
//	int arr[9] = { 4,2,8,0,5,7,1,3,9 };
//	for (int i = 0; i < sizeof(arr) / sizeof(int) - 1; i++)
//	{
//		for (int j = 0; j < sizeof(arr) / sizeof(int) - 1 - i; j++)
//		{
//			if (arr[j] < arr[j + 1])
//			{
//				int temp = arr[j];
//				arr[j] = arr[j + 1];
//				arr[j + 1] = temp;
//
//			}
//		}
//	}
//	for (int i = 0; i < sizeof(arr) / sizeof(int); i++)
//	{
//		cout << arr[i] << endl;
//	}
//}