/**
    Class for keeping time
    Super long-term: different types of calendars for different users
*/

#include <sstream>
#include <string>
#include <thread>

using namespace std;

class gameTime{
    
    private:
        
        int month;
        int day;
        int year;
        int hour;
        int minute;
        bool paused;

        //fuck leap years
        void tick(){
            while(!paused){
                minute++;
                if(minute == 60){
                    hour++;
                    minute = 0;
                    if(hour == 24){
                        hour = 0;
                        day++;
                        if(((month == 4 || month == 6 || month == 9 || month == 11) && day == 31) || ((month == 2) && day == 29) || ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10) && day == 32)){
                            month++;
                            day = 1;
                        }
                        else if(month == 12 && day == 32){
                            month = 1;
                            day = 1;
                            year++;
                        }
                        std::thread dayAdvanced(newDay);
                        dayAdvanced.join();
                    }
                }
            }
        }

        void newDay(){
            
        }

    public:
        
        //returns date as a string for convenience for now
        string getDate(){
            stringstream s;
            s<<month<<"-"<<day<<"-"<<year;
            return s.str();
        }

        //start new game clock; maybe should be a constructor
        void startClock(){
            month = 1;
            day = 1;
            year = 1;
            hour = 7;
            minute = 0;
            tick();
        }

        //start clock from save game; also maybe should be a constructor
        void startClock(string time){
            
        }

        void pause(){
            paused = true;
        }

        void unpause(){
            paused = false;
        }

};
