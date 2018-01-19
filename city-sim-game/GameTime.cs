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
                    //UpgradeZones();
                    BuildNewZones();
                    SpawnPeople();
                }
            }
        }

        public void BuildNewZones()
        {
            //stupid simple
            foreach (Lot l in CitySimGame.Map.Lots)
            {
                if (l.LandValue > 90 && l.ZoneType == 'a' && l.Developed == false && CitySimGame.Demands.Agricultural > 0)
                {
                    CitySimGame.Map.AddFarm(new Farm(l));
                    l.Developed = true;
                    CitySimGame.Demands.Agricultural--;
                    //CitySimGame.AddJob(new Job())
                }
                else if (l.LandValue > 90 && l.ZoneType == 'r' && l.Developed == false && CitySimGame.Demands.LowIncomeResidential > 0)
                {
                    CitySimGame.Map.AddHousing(new ResidentialBuilding(l));
                    l.Developed = true;
                    CitySimGame.Demands.LowIncomeResidential--;
                }
                else if (l.LandValue > 90 && l.ZoneType == 'c' && l.Developed == false && CitySimGame.Demands.Commercial > 0)
                {
                    CitySimGame.Map.AddShops(new CommercialBuilding(l));
                    l.Developed = true;
                    CitySimGame.Demands.Commercial--;
                }
                else if (l.LandValue > 90 && l.ZoneType == 'i' && l.Developed == false && CitySimGame.Demands.Industrial > 0)
                {
                    CitySimGame.Map.AddIndustry(new IndustrialBuilding(l));
                    l.Developed = true;
                    CitySimGame.Demands.Industrial--;
                }
            }
        }

        public void SpawnPeople()
        {
            while (CitySimGame.Jobs.Count > 0 || CitySimGame.Population.Count < 10)
            {
                Person p = new Person();
                CitySimGame.AddPerson(p);
                if (p.IsMarried)
                {
                    CitySimGame.AddPerson(p.Spouse);
                }
                if (CitySimGame.Map.GetAvailableHouses().Count > 0 || CitySimGame.Map.AvailableResidential > 0)
                {
                    int totalIncome = 0;
                    if (p.IsMarried)
                    {
                        totalIncome = p.Income + p.Spouse.Income;
                    }
                    else
                    {
                        totalIncome = p.Income;
                    }
                    bool lookingForHouse = true;
                    if (CitySimGame.Map.GetAvailableHouses().Count > 0)
                    {
                        foreach (ResidentialBuilding rb in CitySimGame.Map.GetAvailableHouses())
                        {
                            if ((rb.BuildingValue + rb.Lot.LandValue < 2.5 * totalIncome) && (rb.BuildingValue + rb.Lot.LandValue > 1.75 * totalIncome) && lookingForHouse)
                            {
                                p.Home = rb;
                                if (p.IsMarried)
                                {
                                    p.Spouse.Home = rb;
                                    rb.IncreaseOccupants(2);
                                }
                                else
                                {
                                    rb.IncreaseOccupants(1);
                                }
                                rb.IncreaseOccupiedHomes(1);
                                lookingForHouse = false;
                                break;
                            }
                        }
                    }
                    else if (lookingForHouse)
                    {
                        
                    }
                }
                else
                {
                    
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
