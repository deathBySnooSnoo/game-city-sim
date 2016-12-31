#include "lot.h"
#include <cstring>
#include <iostream>

using namespace std;

string corners;
string address;
char zoneType;
char density;

lot::lot(string c, char zt, char d){
	corners = c;
	zoneType = zt;
	density = d;
}

lot::~lot(){

}