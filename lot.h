#pragma once

#include <cstring>
#include <iostream>

class lot{
public:
	char getZoneType();
	char getDensity();
	int getLandValue();
	void setZoneType(char zt);
	void setDensity(char d);
	void setLandValue(int lv);
	lot();
	~lot();
};