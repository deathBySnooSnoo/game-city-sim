using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_sim_game
{
    class ResidentialBuilding
    {
        private int floors;
        private int buildingValue;
        private int totalHomes;
        private int occupiedHomes;
        private int occupants;
        private Lot lot;

        public ResidentialBuilding()
        {
            floors = 1;
            buildingValue = 40000;
            totalHomes = 1;
            occupiedHomes = 0;
            occupants = 0;
        }

        public ResidentialBuilding(Lot l)
        {
            floors = 1;
            buildingValue = 40000;
            totalHomes = 1;
            occupiedHomes = 0;
            occupants = 0;
            lot = l;
        }

        public void DecreaseOccupiedHomes(int housingDecrease)
        {
            occupiedHomes -= housingDecrease;
        }

        public void IncreaseOccupiedHomes(int housingIncrease)
        {
            occupiedHomes += housingIncrease;
        }

        public void DecreaseOccupants(int leavingOccupants)
        {
            occupants -= leavingOccupants;
        }

        public void IncreaseOccupants(int newOccupants)
        {
            occupants += newOccupants;
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

        public int TotalHomes
        {
            get
            {
                return totalHomes;
            }
            set
            {
                totalHomes = value;
            }
        }

        public int OccupiedHomes
        {
            get
            {
                return occupiedHomes;
            }
            set
            {
                occupiedHomes = value;
            }
        }

        public int Occupants
        {
            get
            {
                return occupants;
            }
            set
            {
                occupants = value;
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
