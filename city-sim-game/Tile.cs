using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_sim_game
{
    class Tile
    {

        private int key;
        private char zoningList; //t=transport, r=residential, c=commercial, i=industrial, a=ag, w=water
        private bool availableForZoning;
        private bool fertileSoil;

        public Tile()
        {
            key = -1;
            zoningList = '\0';
            availableForZoning = true;
        }

        public int Key
        {
            get
            {
                return key;
            }
            set
            {
                key = value;
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

        public bool FertileSoil
        {
            get
            {
                return fertileSoil;
            }
            set
            {
                fertileSoil = value;
            }
        }
    }
}
