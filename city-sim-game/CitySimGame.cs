using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace city_sim_game
{
    class CitySimGame
    {
        private static bool paused = false;
        private static bool quit = false;
        private static Map map = null;
        private static List<Person> population = null;
        private static List<Job> jobs = null;
        private static Demand demands = null;
        private static List<Occupation> occupations = null;

        public static void Main(string[] args)
        {
            map = new Map(100, 100);
            population = new List<Person>();
            jobs = new List<Job>();
            demands = new Demand();
            occupations = new List<Occupation>();
            XmlTextReader xtr = new XmlTextReader("Occupations.xml");
            Occupation o = null;
            bool makingOccupation = false;
            while (xtr.Read())
            {
                if (!makingOccupation)
                {
                    makingOccupation = true;
                    o = new Occupation();
                }
                if (xtr.NodeType.Equals(XmlNodeType.Element))
                {
                    if (xtr.Name.Equals("Name"))
                    {
                        o.Name = xtr.ReadElementContentAsString();
                    }
                    else if (xtr.Name.Equals("Salary"))
                    {
                        o.Salary = xtr.ReadElementContentAsInt();
                    }
                    else if (xtr.Name.Equals("Education"))
                    {
                        o.Education = xtr.ReadElementContentAsInt();
                        occupations.Add(o);
                        makingOccupation = false;
                    }
                }
            }
            System.Threading.Thread timeThread = new System.Threading.Thread(TimePassage);
            timeThread.Start();
            while (!quit)
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
                    Console.WriteLine("Enter 'population', 'demands': ");
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
                        Console.WriteLine("Ag: " + Demands.Agricultural + "\nResidential: " + Demands.LowIncomeResidential + "\nCommercial: " + Demands.Commercial + "\nIndustrial: " + Demands.Industrial);
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

        public static void AddPerson(Person p)
        {
            population.Add(p);
        }

        public static List<Job> Jobs
        {
            get
            {
                return jobs;
            }
        }

        public static void AddJob(Job j)
        {
            jobs.Add(j);
        }

        public static Demand Demands
        {
            get
            {
                return demands;
            }
        }

        public static List<Occupation> Occupations
        {
            get
            {
                return occupations;
            }
        }
    }
}
