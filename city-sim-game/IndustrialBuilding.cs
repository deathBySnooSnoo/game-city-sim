using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_sim_game
{
    class IndustrialBuilding : BusinessBuilding
    {
        private int buildingValue;
        private int businessCount;
        private int availableSpaces;
        private Lot lot;

        public IndustrialBuilding(Lot l)
        {
            buildingValue = 50000;
            businessCount = 1;
            availableSpaces = 1;
            lot = l;
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
