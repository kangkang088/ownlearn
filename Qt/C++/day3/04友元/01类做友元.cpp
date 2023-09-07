//#include <iostream>
//using namespace std;
//
//class Building;
//class GoodGay
//{
//public:
//    GoodGay();
//    void visit();//访问Building中的属性
//    Building* building;
//};
//class Building
//{
//    friend class GoodGay;
//public:
//    Building();
//public:
//    string m_sittingRoom;
//private:
//    string m_bedRoom;
//};
////也可以类外实现成员函数
//Building::Building()
//{
//    this->m_sittingRoom = "客厅";
//    this->m_bedRoom = "卧室";
//}
//GoodGay::GoodGay()
//{
//    this->building = new Building();
//}
//void GoodGay::visit()
//{
//    cout << "好基友类正在访问" << this->building->m_sittingRoom << endl;
//    //需要友元
//    cout << "好基友类正在访问" << this->building->m_bedRoom << endl;
//}
//void test1()
//{
//    GoodGay gd;
//    gd.visit();
//}
//int main()
//{
//    test1();
//}