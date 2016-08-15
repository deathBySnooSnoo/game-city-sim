#include <sstream>
#include <string>

using namespace std;

class gameTime{
    
    private:
        
        int month;
        int day;
        int year;
        int hour;
        int minute;

    public:
        
        string getDate(){
            stringstream s;
            s<<month<<"-"<<day<<"-"<<year;
            return s.str();
        }

};
