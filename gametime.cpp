#include "gametime.h"

using namespace std;

int month;
int day;
int year;
int hour;
int minute;

void gametime::tick() {
	minute++;
	if (minute == 60) {
		hour++;
		minute = 0;
		if (hour == 24) {
			day++;
			hour = 0;
			if (((month == 4 || month == 6 || month == 9 || month == 11) && day == 31) || (month == 2 && day == 29) || ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10) && day == 32)) {
				month++;
				day = 1;
			}
			else if (month == 12 && day == 32) {
				year++;
				month = 1;
				day = 1;
			}
			cout << month << "-" << day << "-" << year << endl;
		}
	}
}

/**
string getDate() {
	stringstream s;
	s << month << "-" << day << "-" << year;
	return s.str();
}
*/

gametime::gametime() {

}

gametime::~gametime() {

}