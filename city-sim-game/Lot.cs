using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_sim_game
{
    class Lot
    {
        private string address;
        private char zoneType;
        private char density;
        private int landValue;
        private float acres;
        private Tuple<int, int> upperLeftCorner;
        private Tuple<int, int> lowerRightCorner;
        private bool developed;

        public Lot(char z, char d, Tuple<int, int> ulc, Tuple<int, int> lrc)
        {
            zoneType = z;
            density = d;
            upperLeftCorner = ulc;
            lowerRightCorner = lrc;
            acres = (lrc.Item1 - ulc.Item1) * (lrc.Item2 - ulc.Item2) / 43560; //converting sq ft into acres. one tile is 100 sq ft MATH MAY BE WRONG
            landValue = 100;
            developed = false;
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public char ZoneType
        {
            get
            {
                return zoneType;
            }
            set
            {
                zoneType = value;
            }
        }

        public char Density
        {
            get
            {
                return density;
            }
            set
            {
                density = value;
            }
        }

        public int LandValue
        {
            get
            {
                return landValue;
            }
            set
            {
                landValue = value;
            }
        }

        public float Acres
        {
            get
            {
                return acres;
            }
            set
            {
                acres = value;
            }
        }

        public Tuple<int, int> UpperLeftCorner
        {
            get
            {
                return upperLeftCorner;
            }
            set
            {
                upperLeftCorner = value;
            }
        }

        public Tuple<int, int> LowerRightCorner
        {
            get
            {
                return lowerRightCorner;
            }
            set
            {
                lowerRightCorner = value;
            }
        }

        public bool Developed
        {
            get
            {
                return developed;
            }
            set
            {
                developed = value;
            }
        }
    }
}
