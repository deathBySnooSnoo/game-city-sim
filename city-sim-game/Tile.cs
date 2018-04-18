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
        private char zoningList; //t=transport, r=residential, c=commercial, i=industrial, a=ag, w=water, j=junction
        private bool availableForZoning;
        private bool fertileSoil;
        private int oil;

        public Tile(byte oilContent)
        {
            key = -1;
            zoningList = '\0';
            availableForZoning = true;
            oil = oilContent;
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

        public int Oil
        {
            get
            {
                return oil;
            }
            set
            {
                oil = value;
            }
        }
    }
}
