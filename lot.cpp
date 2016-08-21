/**
    Class for property Lots

    ONLY SUPPORTING RECTANGULAR LOTS AT THE MOMENT
*/

#include <iostream>
#include <string>
#include "sqlite3.h"

using namespace std;

class Lot{

    private:

        string corners; //corners to draw the lot edges between
        string address; //street it is on once roads exist
        char zoneType; //type of zone: Agriculture, Industrial, Commercial, Residential, Mixed
        char density; //zone density: Low, Medium, High

    public:

        Lot(string c, char zt, char d){
            corners = c;
            zoneType = zt;
            density = d;
        }

        string getCorners(){
            return corners;
        }

        char getZoneType(){
            return zoneType;
        }

        char getDensity(){
            return density;
        }

        string getAddress(){
            return address;
        }
};
