using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml;

namespace city_sim_game
{
    class CitySimGame
    {
        private static bool paused = false;
        private static bool quit = false;
        private static Map map = null;
        private static List<Person> population = null;
        private static List<Job> availableJobs = null;
        private static Demand demands = null;
        private static Occupation[] occupations = null;
        private static BusinessType[] businessTypes = null;
        private static List<Business> businesses = null;
        private static string[] maleNames = null;
        private static string[] femaleNames = null;
        private static string[] lastNames = null;
        private static string mapFilePath = "";

        public static void Main(string[] args)
        {
            Init();
            Thread timeThread = new Thread(TimePassage);
            timeThread.Start();
            while (!quit) //running a console app from here. delete after gui made.
            {
                string input = Console.ReadLine();
                if (input.Equals("pause"))
                {
                    paused = !paused;
                }
                else if (input.Equals("quit"))
                {
                    quit = true;
                    paused = true;
                    timeThread.Abort();
                }
                else if (input.Equals("zone"))
                {
                    Console.WriteLine("Enter 'new', 'change', 'check', or 'remove': ");
                    input = Console.ReadLine();
                    if (input.Equals("new"))
                    {
                        map.Zone();
                    }
                    else if (input.Equals("check"))
                    {
                        map.CheckZone();
                    }
                    else if (input.Equals("change"))
                    {
                        map.ChangeZone();
                    }
                    else if (input.Equals("remove"))
                    {
                        map.Dezone();
                    }
                }
                else if (input.Equals("list"))
                {
                    Console.WriteLine("Enter 'population', 'demands', 'resources': ");
                    input = Console.ReadLine();
                    if (input.Equals("population"))
                    {
                        foreach(Person p  in Population)
                        {
                            Console.WriteLine(p.FirstName + " " + p.LastName);
                        }
                    }
                    else if (input.Equals("demands"))
                    {
                        Console.WriteLine("Residential: " + Demands.LowIncomeResidential);
                    }
                    else if (input.Equals("resources"))
                    {
                        
                    }
                }
                else if (input.Equals("road"))
                {
                    Console.WriteLine("Enter 'new' or 'edit': ");
                    input = Console.ReadLine();
                    if (input.Equals("new"))
                    {
                        map.NewRoad();
                    }
                }
            }
        }

        private static void TimePassage()
        {
            GameTime gt = new GameTime();
            while (!quit)
            {
                while (!paused)
                {
                    gt.Tick();
                    System.Threading.Thread.Sleep(167);
                }
            }
        }

        public static void Init()
        {
            map = new Map();
            population = new List<Person>();
            availableJobs = new List<Job>();
            demands = new Demand();
            businesses = new List<Business>();
            List<BusinessType> bTypes = new List<BusinessType>();
            XmlTextReader xtrBusinessTypes = new XmlTextReader("BusinessTypes.xml");
            bool makingBusinessType = false;
            BusinessType bt = null;
            string title = "";
            while (xtrBusinessTypes.Read())
            {
                if (!makingBusinessType)
                {
                    makingBusinessType = true;
                    bt = new BusinessType();
                }
                if (xtrBusinessTypes.NodeType.Equals(XmlNodeType.Element))
                {
                    if (xtrBusinessTypes.Name.Equals("Zoning"))
                    {
                        bt.Zoning = Convert.ToChar(xtrBusinessTypes.ReadElementContentAsString());
                    }
                    else if (xtrBusinessTypes.Name.Equals("Type"))
                    {
                        bt.Type = xtrBusinessTypes.ReadElementContentAsString();
                    }
                    else if (xtrBusinessTypes.Name.Equals("Title"))
                    {
                        title = xtrBusinessTypes.ReadElementContentAsString();
                    }
                    else if (xtrBusinessTypes.Name.Equals("Count"))
                    {
                        bt.Jobs.Add(title, xtrBusinessTypes.ReadElementContentAsInt());
                        title = "";
                    }
                }
                else if (xtrBusinessTypes.NodeType.Equals(XmlNodeType.EndElement))
                {
                    if (xtrBusinessTypes.Name.Equals("Business"))
                    {
                        bTypes.Add(bt);
                        makingBusinessType = false;
                    }
                }
            }
            businessTypes = bTypes.ToArray();
            List<Occupation> occs = new List<Occupation>();
            XmlTextReader xtrOccupations = new XmlTextReader("Occupations.xml");
            Occupation o = null;
            bool makingOccupation = false;
            while (xtrOccupations.Read())
            {
                if (!makingOccupation)
                {
                    makingOccupation = true;
                    o = new Occupation();
                }
                if (xtrOccupations.NodeType.Equals(XmlNodeType.Element))
                {
                    if (xtrOccupations.Name.Equals("Name"))
                    {
                        o.Name = xtrOccupations.ReadElementContentAsString();
                    }
                    else if (xtrOccupations.Name.Equals("Salary"))
                    {
                        o.Salary = xtrOccupations.ReadElementContentAsInt();
                    }
                    else if (xtrOccupations.Name.Equals("Education"))
                    {
                        o.Education = xtrOccupations.ReadElementContentAsInt();
                        occs.Add(o);
                        makingOccupation = false;
                    }
                }
            }
            occupations = occs.ToArray();
            femaleNames = System.IO.File.ReadAllLines("FemaleNames.txt");
            maleNames = System.IO.File.ReadAllLines("MaleNames.txt");
            lastNames = System.IO.File.ReadAllLines("LastNames.txt");
            Console.WriteLine("Map file location: ");
            mapFilePath = Console.ReadLine();
        }

        public static bool ExistsBusinessWithNoLocation(string businessType)
        {
            bool exists = false;
            foreach (Business b in businesses)
            {
                if (businessType.Equals(b.BizType) && b.Building == null)
                {
                    exists = true;
                }
            }
            return exists;
        }

        public static List<Business> GetBusinessByType(string businessType)
        {
            List<Business> bizzes = new List<Business>();
            foreach (Business b in businesses)
            {
                if (businessType.Equals(b.BizType))
                {
                    bizzes.Add(b);
                }
            }
            return bizzes;
        }

        public static Map Map
        {
            get
            {
                return map;
            }
        }

        public static List<Person> Population
        {
            get
            {
                return population;
            }
        }

        public static List<Job> AvailableJobs
        {
            get
            {
                return availableJobs;
            }
        }

        public static Demand Demands
        {
            get
            {
                return demands;
            }
        }

        public static Occupation[] Occupations
        {
            get
            {
                return occupations;
            }
        }

        public static BusinessType[] BusinessTypes
        {
            get
            {
                return businessTypes;
            }
        }

        public static List<Business> Businesses
        {
            get
            {
                return businesses;
            }
        }

        public static string[] FemaleNames
        {
            get
            {
                return femaleNames;
            }
            set
            {
                femaleNames = value;
            }
        }

        public static string[] MaleNames
        {
            get
            {
                return maleNames;
            }
            set
            {
                maleNames = value;
            }
        }

        public static string[] LastNames
        {
            get
            {
                return lastNames;
            }
            set
            {
                lastNames = value;
            }
        }

        public static string MapFilePath
        {
            get
            {
                return mapFilePath;
            }
        }
    }
}
