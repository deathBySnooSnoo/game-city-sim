using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_sim_game
{
    class Business
    {
        private int employees;
        private string name;
        private BusinessBuilding building;
        private char businessType;
        private int revenue;

        public Business()
        {
            employees = 0;
            name = "";

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

        public BusinessBuilding Building
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

        public char BusinessType
        {
            get
            {
                return businessType;
            }
            set
            {
                businessType = value;
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
    }
}
