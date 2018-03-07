using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_sim_game
{
    class Job : Occupation
    {
        private Business workplace;
        private Occupation occupationType;
        private Person worker;
        private int[] startTime; //{hour, minute}
        private int[] endTime; //{hour, minute}

        public Job(Business b, Occupation ot)
        {
            workplace = b;
            occupationType = ot;
            Salary = occupationType.Salary;
            Name = occupationType.Name;
            Education = occupationType.Education;
            worker = null;
        }

        public Business Workplace
        {
            get
            {
                return workplace;
            }
            set
            {
                workplace = value;
            }
        }

        public Occupation OccupationType
        {
            get
            {
                return occupationType;
            }
        }

        public Person Worker
        {
            get
            {
                return worker;
            }
            set
            {
                worker = value;
            }
        }

        public int[] StartTime
        {
            get
            {
                return startTime;
            }
            set
            {
                startTime = value;
            }
        }

        public int[] EndTime
        {
            get
            {
                return endTime;
            }
            set
            {
                endTime = value;
            }
        }
    }
}
