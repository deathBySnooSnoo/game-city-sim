using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_sim_game
{
    class IndustrialBuilding
    {
        private int buildingValue;
        private int businessCount;
        private int availableSpaces;
        private Lot buildingLot;
        private int squareFeet;

        public IndustrialBuilding(Lot l)
        {
            buildingValue = 50000;
            businessCount = 1;
            availableSpaces = 1;
            buildingLot = l;
            squareFeet = 0; //change this to be an actual square footage
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

        public Lot BuildingLot
        {
            get
            {
                return buildingLot;
            }
            set
            {
                buildingLot = value;
            }
        }

        public int SquareFeet
        {
            get
            {
                return squareFeet;
            }
            set
            {
                squareFeet = value;
            }
        }
    }
}
