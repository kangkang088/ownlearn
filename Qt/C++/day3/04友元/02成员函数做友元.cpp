#include <iostream>
using namespace std;
class Building;
class GoodGay
{
public:
	GoodGay();
	void visit();	
	void visitt();
	Building* building;
};
class Building
{
	friend void GoodGay::visit();
public:
	Building();
	string m_sittingRoom;
private:
	string m_bedRoom;
};
Building::Building()
{
	this->m_sittingRoom = "����";
	this->m_bedRoom = "����";
}
GoodGay::GoodGay()
{
	this->building = new Building;
}
void GoodGay::visit()
{
	//��Ҫ��Ԫ
	cout << "visit�������ڷ���˽�г�Ա" << endl;
	cout << this->building->m_bedRoom << endl;
}
void GoodGay::visitt()
{
	cout << "visitt�������ڷ��ʷ�˽�г�Ա" << endl;
	cout << this->building->m_sittingRoom << endl;
}
int main()
{
	GoodGay gd;
	gd.visit();
	gd.visitt();
}