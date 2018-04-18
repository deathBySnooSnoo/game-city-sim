using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_sim_game
{
    interface IBusinessBuilding
    {
        int BuildingValue
        {
            get;
            set;
        }

        int BusinessCount
        {
            get;
            set;
        }

        int AvailableSpaces
        {
            get;
            set;
        }

        Lot BuildingLot
        {
            get;
            set;
        }

        int SquareFeet
        {
            get;
            set;
        }
    }
}
