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
            if (minute == 60)
            {
                hour++;
                minute = 0;
                if (hour == 24)
                {
                    day++;
                    hour = 0;
                    if (((month == 4 || month == 6 || month == 9 || month == 11) && day == 31) || (month == 2 && day == 29) || ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10) && day == 32))
                    {
                        month++;
                        day = 1;
                    }
                    else if (month == 12 && day == 32)
                    {
                        year++;
                        month = 1;
                        day = 1;
                    }
                    Console.WriteLine(month + "-" + day + "-" + year);
                    SpawnPeople();
                    HaveChildren();
                    EmploymentChange();
                }
            }
        }

        private void SpawnPeople()
        {
            int newPersons = 0;
            while (newPersons < CitySimGame.AvailableJobs.Count/2 || CitySimGame.Population.Count < 10)
            {
                Person p = new Person();
                CitySimGame.Population.Add(p);
                newPersons++;
                if (p.IsMarried)
                {
                    CitySimGame.Population.Add(p.Spouse);
                    newPersons++;
                }
            }
        }

        private void HaveChildren()
        {
            List<Person> newborns = new List<Person>();
            foreach (Person p in CitySimGame.Population)
            {
                if (p.IsFemale && People.HaveBaby())
                {
                    newborns.Add(new Person(p, p.Spouse));
                }
            }
            CitySimGame.Population.AddRange(newborns);
        }

        private void SpawnBusinesses()
        {
            //sort business demands here. pass highest and step through until exiting the loop
            if (CitySimGame.Demands.CommercialDemandExists())
            {

            }
        }

        private void EmploymentChange()
        {
            if (CitySimGame.AvailableJobs.Count > 0)
            {
                foreach (Person p in CitySimGame.Population)
                {
                    if (p.Occupation != null)
                    {
                        p.FindJob();
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
