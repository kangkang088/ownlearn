//#include <iostream>
//using namespace std;
//
////���ﴩ�����ʱ��ע�����鳤��ҲҪ���ݣ���Ȼ�ں����м������鳤��ʱ���൱���Ǽ���ָ��Ĵ�С
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
////��ӡ����ĺ���
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