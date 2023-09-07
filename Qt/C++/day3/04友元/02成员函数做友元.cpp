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
	this->m_sittingRoom = "客厅";
	this->m_bedRoom = "卧室";
}
GoodGay::GoodGay()
{
	this->building = new Building;
}
void GoodGay::visit()
{
	//需要友元
	cout << "visit（）正在访问私有成员" << endl;
	cout << this->building->m_bedRoom << endl;
}
void GoodGay::visitt()
{
	cout << "visitt（）正在访问非私有成员" << endl;
	cout << this->building->m_sittingRoom << endl;
}
int main()
{
	GoodGay gd;
	gd.visit();
	gd.visitt();
}