//#include <iostream>
//using namespace std;
//
////这里穿数组的时候，注意数组长度也要传递，不然在函数中计算数组长度时，相当于是计算指针的大小
//void bubbleSort(int* arr, int len)
//{
//	for (int i = 0; i < len - 1; i++)
//	{
//		for (int j = 0; j < len - 1 - i; j++) {
//			if (arr[j] > arr[j + 1])
//			{
//				int temp = arr[j];
//				arr[j] = arr[j + 1];
//				arr[j + 1] = temp;
//			}
//		}
//	}
//}
////打印数组的函数
//void printTest(int arr[],int len)
//{
//	for (int i = 0; i < len; i++)
//	{
//		cout << arr[i] << ' ';
//	}
//}
//int main()
//{
//	int arr[10] = { 4,3,6,9,1,2,10,8,7,5 };
//	int len = sizeof(arr)/sizeof(int);
//	bubbleSort(arr, len);
//	printTest(arr,len);
//
//}