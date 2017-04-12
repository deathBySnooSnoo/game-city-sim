using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_sim_game
{
    class GameTime
    {
        private int month;
        private int day;
        private int year;
        private int hour;
        private int minute;

        public GameTime()
        {
            month = 1;
            day = 1;
            year = 100;
            hour = 0;
            minute = 0;
        }

        public void Tick()
        {
            minute++;
            if(minute == 60)
            {
                hour++;
                minute = 0;
                if(hour == 24)
                {
                    day++;
                    hour = 0;
                    if(((month == 4 || month == 6 || month == 9 || month == 11) && day == 31) || (month == 2 && day == 29) || ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10) && day == 32))
                    {
                        month++;
                        day = 1;
                    }
                    else if(month == 12 && day == 32)
                    {
                        year++;
                        month = 1;
                        day = 1;
                    }
                    Console.WriteLine(month + "-" + day + "-" + year);
                }
            }
        }


    }
}
