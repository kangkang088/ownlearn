//#include <iostream>
//using namespace std;
//int mutiply(int num)
//{
//	if (num == 1)
//	{
//		return 1;
//	}
//	return num * mutiply(num - 1);
//}
//int sum(int n)
//{
//	if (n == 1)
//	{
//		return 1;
//	}
//	return n + sum(n - 1);
//}
////쳲���������-�ݹ龭��
////1,1,����λ��ʼ��ÿһλ����ǰ��λ�����ֵĺ�
//int arraya(int n)
//{
//	if (n == 1 || n == 2)
//	{
//		return 1;
//	}
//	return arraya(n - 1) + arraya(n - 2);
//}
//int main()
//{
//	cout << mutiply(5) << endl;
//	cout << sum(100) << endl;
//	for (int i = 1; i <= 20; i++)
//	{
//		cout << arraya(i) << endl;
//	}
//}