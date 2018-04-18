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
        private int height;
        private bool developed;

        public Lot(char z, char d, Tuple<int, int> ulc, int w, int h)
        {
            zoneType = z;
            density = d;
            upperLeftCorner = ulc;
            width = w;
            height = h;
            acres = width * height / 43560; //converting sq ft into acres. one tile is 100 sq ft MATH MAY BE WRONG
            landValue = 100; //needs to be dynamic based on area
            developed = false;
        }

        public int DistanceFromNearestResidentialBuilding()
        {
            
            return -1;
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

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
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
