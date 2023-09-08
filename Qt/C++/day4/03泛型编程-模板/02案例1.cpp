//#include <iostream>
//#include <fstream>
//using namespace std;
//template <typename T>
//void mySwap(T &a, T &b)
//{
//	T temp = a;
//	a = b;
//	b = temp;
//}
//template<typename T>
//void mySort(T arr[],int len)
//{
//	for (int i = 0; i < len; i++)
//	{
//		int max = i;
//		for (int j = i+1; j < len; j++)
//		{
//			if (arr[max] < arr[j]) 
//			{
//				max = j;
//			}
//		}
//		if (max != i)
//		{
//			mySwap(arr[max], arr[i]);
//		}
//	}
//}
//template<typename T>
//void printArray(T arr[], int len)
//{
//	for (int i = 0; i < len; i++)
//	{
//		cout << arr[i] << "  ";
//	}
//	cout << endl;
//}
//void test1()
//{
//    char charArr[] = "badwqet";
//	mySort(charArr, sizeof(charArr)/sizeof(char));
//	printArray(charArr, sizeof(charArr)/sizeof(char));
//}
//void test2()
//{
//	int intArr[] = { 1,3,5,7,9 };
//	mySort(intArr, sizeof(intArr) / sizeof(int));
//	printArray(intArr, sizeof(intArr) / sizeof(int));
//}
//int main()
//{
//	test1();
//	test2();
//}