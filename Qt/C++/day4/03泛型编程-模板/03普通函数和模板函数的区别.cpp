//#include <iostream>
//#include <fstream>
//using namespace std;
//
////1.��ͨ�������ÿ��Է�����ʽ����ת��
////2.����ģ�����Զ������Ƶ��������Է�����ʽ����ת��
////3.����ģ������ʽָ�����ͣ����Է�����ʽ����ת��
//
////��ͨ����
//int myAdd(int a, int b)
//{
//    return a + b;
//}
////����ģ��
//template<typename T>
//T myAdd_S(T a, T b)
//{
//    return a + b;
//}
//void test1()
//{
//    int a = 10;
//    int b = 20;
//    cout << myAdd(a, b) << endl;
//    char c = 'c';
//    //��ʽ����ת��
//    cout << myAdd(a,c) << endl;
//
//    //�Զ������Ƶ�
//    //cout << myAdd_S(a, c) << endl;//�����Է�����ʽ����ת��
//    
//    //��ʽָ������
//    cout << myAdd_S<int>(a, c) << endl;//���Է�����ʽ����ת��
//    //�����ʽ����ת�����ɹ����򱨴�
//}
//int main()
//{
//    test1();
//}