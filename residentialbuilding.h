#pragma once

#include <cstring>

class residentialbuilding {
public:
	void decreaseOccupiedHomes(int housingDecrease);
	void increaseOccupiedHomes(int housingIncrease);
	void increaseOccupants(int newOccupants);
	void decreaseOccupants(int leavingOccupants);
	int getOccupants();
	int getOccupiedHomes();
	int getBuildingValue();
	int getFloorCount();
	residentialbuilding();
	~residentialbuilding();
};