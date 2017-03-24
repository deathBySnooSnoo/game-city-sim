#include "residentialbuilding.h"

using namespace std;

int floors;
int buildingValue;
int totalHomes;
int occupiedHomes;
int occupants;

void residentialbuilding::decreaseOccupiedHomes(int housingDecrease) {
	occupiedHomes -= housingDecrease;
}

void residentialbuilding::increaseOccupiedHomes(int housingIncrease) {
	occupiedHomes += housingIncrease;
}

void residentialbuilding::increaseOccupants(int newOccupants) {
	occupants += newOccupants;
}

void residentialbuilding::decreaseOccupants(int leavingOccupants) {
	occupants -= leavingOccupants;
}

int residentialbuilding::getOccupants() {
	return occupants;
}

int residentialbuilding::getOccupiedHomes() {
	return occupiedHomes;
}

int residentialbuilding::getBuildingValue() {
	return buildingValue;
}

int residentialbuilding::getFloorCount() {
	return floors;
}

residentialbuilding::residentialbuilding() {

}

residentialbuilding::~residentialbuilding() {

}