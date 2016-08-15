#include <iostream>
#include <string>
#include <cstdlib>
#include <time>
#include "sqlite3.h"

using namespace std;

class People{

    private:
        
        static int callback(void *NotUsed, int argc, char **argv, char **azColName){

    public:

        string getRandomBirthday(string date){
            int day;
            int year;
            int month;
            srand(time(NULL));
            month = rand() % 12 + 1;
            year = rand();
        }

}
