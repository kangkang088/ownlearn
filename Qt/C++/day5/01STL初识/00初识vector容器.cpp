//#include <iostream>
//#include <fstream>
//#include <vector>
//#include <algorithm>
//using namespace std;
//
//void myPrint(int val)
//{
//    cout << val << endl;
//}
//void test1()
//{
//    //����һ��vector����  ����
//    vector<int> v;
//
//    //�������в�������
//    v.push_back(10);
//    v.push_back(20);
//    v.push_back(30);
//    v.push_back(40);
//    v.push_back(50);
//
//    //ͨ�����������������е�����
//    //ָ�������е�һ��Ԫ�ص�λ��
//    vector<int>::iterator itBegin = v.begin();
//    //ָ�����������һ��Ԫ�ص���һ��λ��
//    vector<int>::iterator itEnd = v.end();
//
//    //��һ�ֱ�����ʽ
//    //�Ƚ��鷳��Ҫд����Ĵ���
//    cout << "��һ�ֱ�����ʽ" << endl;
//    while (itBegin != itEnd)
//    {
//        cout << *itBegin << endl;
//        itBegin++;
//    }
//    //�ڶ��ֱ�����ʽ
//    cout << "�ڶ��ֱ�����ʽ" << endl;
//    for (vector<int>::iterator it = v.begin(); it != v.end(); it++)
//    {
//        cout << *it << endl;
//    }
//    //�����֣�STL�ṩ���㷨
//    cout << "�����ֱ�����ʽ" << endl;
//    for_each(v.begin(), v.end(), myPrint);
//}
//int main()
//{
//    test1();
//}