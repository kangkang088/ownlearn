//#include <iostream>
//using namespace std;
//
//class Building
//{
//    friend void goodGay(Building& building);
//public:
//    Building()
//    {
//        m_sittingRoom = "����";
//        m_bedRoom = "����";
//    }
//    string m_sittingRoom;
//private:
//    string m_bedRoom;
//};
//void goodGay(Building& building)
//{
//    cout << building.m_sittingRoom << endl;
//    //������Ҫ��Ԫ
//    cout << building.m_bedRoom << endl;
//}
//void test1()
//{
//    Building build;
//    goodGay(build);
//}
//int main()
//{
//    test1();
//}