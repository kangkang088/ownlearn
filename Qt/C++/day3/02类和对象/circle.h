#pragma once
#include <iostream>
#include "point.h"
using namespace std;
class Circle
{
	double m_r;
	Point m_center;
public:
	double getR();
	void setR(double r);

	void setCenter(Point center);

	Point getCenter();

};