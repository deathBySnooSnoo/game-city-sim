#include <iostream>
#include <string>
#include "sqlite3.h"

using namespace std;

class Lot{

    private:

        string corners;
        string address;
        char zoneType;
        char density;

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
