using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_sim_game
{
    class Farm
    {
        private string type;
        private int income;
        private int employees;
        private int possibleEmployees;
        private ResidentialBuilding house;
        private bool family;
        private Lot lot;

        public Farm(Lot l)
        {
            income = 0;
            employees = 0;
            possibleEmployees = 0;
            family = true;
            house = new ResidentialBuilding();
            lot = l;
        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public int Income
        {
            get
            {
                return income;
            }
            set
            {
                income = value;
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

        public int PossibleEmployees
        {
            get
            {
                return possibleEmployees;
            }
            set
            {
                possibleEmployees = value;
            }
        }

        public ResidentialBuilding House
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }

        public bool Family
        {
            get
            {
                return family;
            }
            set
            {
                family = value;
            }
        }

        public Lot Lot
        {
            get
            {
                return lot;
            }
            set
            {
                lot = value;
            }
        }
    }
}
