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
//    //创建一个vector容器  数组
//    vector<int> v;
//
//    //向容器中插入数据
//    v.push_back(10);
//    v.push_back(20);
//    v.push_back(30);
//    v.push_back(40);
//    v.push_back(50);
//
//    //通过迭代器访问容器中的数据
//    //指向容器中第一个元素的位置
//    vector<int>::iterator itBegin = v.begin();
//    //指向容器中最后一个元素的下一个位置
//    vector<int>::iterator itEnd = v.end();
//
//    //第一种遍历方式
//    //比较麻烦，要写上面的代码
//    cout << "第一种遍历方式" << endl;
//    while (itBegin != itEnd)
//    {
//        cout << *itBegin << endl;
//        itBegin++;
//    }
//    //第二种遍历方式
//    cout << "第二种遍历方式" << endl;
//    for (vector<int>::iterator it = v.begin(); it != v.end(); it++)
//    {
//        cout << *it << endl;
//    }
//    //第三种，STL提供的算法
//    cout << "第三种遍历方式" << endl;
//    for_each(v.begin(), v.end(), myPrint);
//}
//int main()
//{
//    test1();
//}