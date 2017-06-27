using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_sim_game
{
    class Tile
    {

        private int listPosition;
        private char zoningList;
        private bool availableForZoning;

        public Tile()
        {
            listPosition = 0;
            zoningList = '\0';
            availableForZoning = true;
        }

        public int ListPosition
        {
            get
            {
                return listPosition;
            }
            set
            {
                listPosition = value;
            }
        }

        public char ZoningList
        {
            get
            {
                return zoningList;
            }
            set
            {
                zoningList = value;
            }
        }

        public bool AvailableForZoning
        {
            get
            {
                return availableForZoning;
            }
            set
            {
                availableForZoning = value;
            }
        }
    }
}
