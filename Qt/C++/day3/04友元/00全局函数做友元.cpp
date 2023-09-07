//#include <iostream>
//using namespace std;
//
//class Building
//{
//    friend void goodGay(Building& building);
//public:
//    Building()
//    {
//        m_sittingRoom = "客厅";
//        m_bedRoom = "卧室";
//    }
//    string m_sittingRoom;
//private:
//    string m_bedRoom;
//};
//void goodGay(Building& building)
//{
//    cout << building.m_sittingRoom << endl;
//    //这里需要友元
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