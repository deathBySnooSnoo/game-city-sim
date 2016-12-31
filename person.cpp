#include "person.h"
#include <iostream>
#include <cstring>
#include "lot.h"
#include "gametime.h"
#include "sqlite3.h"

using namespace std;

string birthday;
string firstName;
string lastName;
int personality;
lot home;
lot work;
int wealth;
bool female;
bool married;
person spouse;
person dad;
person mom;
int educationLevel;
//job job;
int age;
bool alive;

person::person() {
	
}


person::~person() {

}
