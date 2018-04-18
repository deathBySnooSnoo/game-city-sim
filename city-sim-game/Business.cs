using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_sim_game
{
    class Business
    {
        private string name;
        private IBusinessBuilding building;
        private string bizType;
        private int revenue;
        private int employees;
        private List<Job> jobs;

        public Business()
        {
            name = "";
            //bizType = null;
            revenue = 0;
            employees = 0;
            jobs = new List<Job>();
            //foreach (KeyValuePair<string, int> j in BusinessType.GetBusinessByType(bizType).Jobs)
            //{
            //    for (int i = 0; i < j.Value; i++)
            //    {
            //        Job temp = new Job(this, Occupation.GetOccupationByName(j.Key));
            //        CitySimGame.AvailableJobs.Add(temp);
            //        jobs.Add(temp);
            //    }
            //}
            //building = null;
        }

        public void HireEmployee(Person employee, Job job)
        {
            foreach (Job j in jobs)
            {
                if (j.Equals(job))
                {
                    j.Worker = employee;
                    employees++;
                }
            }
        }

        public int Employees
        {
            get
            {
                return employees;
            }
            set
            {
                employees = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public IBusinessBuilding Building
        {
            get
            {
                return building;
            }
            set
            {
                building = value;
            }
        }

        public string BizType
        {
            get
            {
                return bizType;
            }
            set
            {
                bizType = value;
            }
        }

        public int Revenue
        {
            get
            {
                return revenue;
            }
            set
            {
                revenue = value;
            }
        }

        public List<Job> Jobs
        {
            get
            {
                return jobs;
            }
            set
            {
                jobs = value;
            }
        }
    }
}
