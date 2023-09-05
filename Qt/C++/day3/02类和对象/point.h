#pragma once
#include <iostream>
using namespace std;

class Point {
	double m_x;
	double m_y;
public:
	void setX(double x);
	
	double getX();
	
	void setY(double y);
	double getY();
};