#include <iostream>
#include <fstream>
#include <vector>
#include <algorithm>
#include <string>
using namespace std;

//Ԥ���ռ� ���ɷ���
void test1()
{
	vector<int> v;

	//����reserveԤ���ռ�
	v.reserve(100000);
	int num = 0;//ͳ�ƿ��ٴ���
	int* p = NULL;
	for (int i = 0; i < 100000; i++)
	{
		v.push_back(i);
		if (p != &v[0])
		{
			p = &v[0];
			num++;
		}
	}
	cout << "num = " << num << endl;
	
}
int main()
{
	test1();
}