//#include <iostream>
//using namespace std;
//
//class Building;
//class GoodGay
//{
//public:
//    GoodGay();
//    void visit();//����Building�е�����
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
////Ҳ��������ʵ�ֳ�Ա����
//Building::Building()
//{
//    this->m_sittingRoom = "����";
//    this->m_bedRoom = "����";
//}
//GoodGay::GoodGay()
//{
//    this->building = new Building();
//}
//void GoodGay::visit()
//{
//    cout << "�û��������ڷ���" << this->building->m_sittingRoom << endl;
//    //��Ҫ��Ԫ
//    cout << "�û��������ڷ���" << this->building->m_bedRoom << endl;
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