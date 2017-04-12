using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_sim_game
{
    class CommercialBuilding
    {
        private int floors;
        private int buildingValue;
        private int businessCount;
        //private Business[] businesses;
        private int availableSpaces;

        public CommercialBuilding()
        {
            floors = 1;
            buildingValue = 50000;
            businessCount = 1;
            //businessess = new Business[businessCount];
            availableSpaces = 1;
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
    }
}
