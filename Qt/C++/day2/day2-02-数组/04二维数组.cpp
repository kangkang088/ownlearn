//#include <iostream>
//using namespace std;
//
//int main()
//{
//    int arr[2][3] = { 1,2,34,5,6,7 };
//	for (int i = 0; i < sizeof(arr)/sizeof(arr[0]); i++)
//	{
//		for (int j = 0; j < sizeof(arr[0]) / sizeof(arr[0][0]); j++) {
//			cout << arr[i][j] <<" ";
//		}
//		cout << endl;		
//	}
//}
////sizeof(arr)二维数组的大小
////sizeof(arr[0])二维数组一行的大小
////sizeof(arr[0][0])二维数组元素大小
////sizeof(arr)/sizeof(arr[0])行数
////sizeof(arr[0])/sizeof(arr[0][0])列数
////arr二维数组首地址
////arr[0]第一行地址
////arr[1]第二行地址
////&arr[0][0]第一个元素的地址
