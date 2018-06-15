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
        private int width;
        private int depth;
        private bool developed;

        public Lot(char z, char den, Tuple<int, int> ulc, int w, int dep)
        {
            zoneType = z;
            density = den;
            upperLeftCorner = ulc;
            width = w;
            depth = dep;
            acres = width * depth * 100/ 43560; //converting sq ft into acres
            landValue = 100; //needs to be dynamic based on area
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

        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        public int Depth
        {
            get
            {
                return depth;
            }
            set
            {
                depth = value;
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
