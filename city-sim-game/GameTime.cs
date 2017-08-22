using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_sim_game
{
    class GameTime
    {
        private static int month;
        private static int day;
        private static int year;
        private static int hour;
        private static int minute;

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
                    //UpgradeZones();
                    BuildNewZones();
                }
            }
        }

        public void BuildNewZones()
        {
            if (CitySimGame.Map.AvailableAg)
            {
                //stupid simple
                foreach(Lot l in CitySimGame.Map.Lots)
                {
                    if(l.LandValue > 90 && l.ZoneType == 'a')
                    {
                        CitySimGame.Map.AddFarm(new Farm(l));
                        l.Developed = true;
                        Console.WriteLine("New farm at: " + l.UpperLeftCorner + "," + l.LowerRightCorner);
                    }
                }
            }
        }

        public static int Month
        {
            get
            {
                return month;
            }
            set
            {
                month = value;
            }
        }

        public static int Day
        {
            get
            {
                return day;
            }
            set
            {
                day = value;
            }
        }

        public static int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        public static int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                hour = value;
            }
        }

        public static int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                minute = value;
            }
        }
    }
}
