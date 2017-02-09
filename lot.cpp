#include "lot.h"

using namespace std;

string address;
char zoneType;
char density;
int landValue = 100;

char lot::getZoneType() {
	return zoneType;
}

char lot::getDensity() {
	return density;
}

int lot::getLandValue() {
	return landValue;
}

void lot::setZoneType(char zt) {
	zoneType = zt;
}

void lot::setDensity(char d) {
	density = d;
}

void lot::setLandValue(int lv) {
	landValue = lv;
}

lot::lot() {
	
}

lot::~lot() {

}