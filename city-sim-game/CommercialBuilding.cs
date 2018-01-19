using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_sim_game
{
    class CommercialBuilding : BusinessBuilding
    {
        private int floors;
        private int buildingValue;
        private int businessCount;
        private int availableSpaces;
        private Lot lot;

        public CommercialBuilding(Lot l)
        {
            floors = 1;
            buildingValue = 50000;
            businessCount = 1;
            availableSpaces = 1;
            lot = l;
        }

        public int Floors
        {
            get
            {
                return floors;
            }
            set
            {
                floors = value;
            }
        }

        public int BuildingValue
        {
            get
            {
                return buildingValue;
            }
            set
            {
                buildingValue = value;
            }
        }

        public int BusinessCount
        {
            get
            {
                return businessCount;
            }
            set
            {
                businessCount = value;
            }
        }

        public int AvailableSpaces
        {
            get
            {
                return availableSpaces;
            }
            set
            {
                availableSpaces = value;
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
