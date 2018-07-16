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
        private double distanceFromLeftIntersection; //probably should specify intersection
        private int width;
        private int depth;
        private bool developed;
        private Road street;

        public Lot(char z, char den, double dfli, int w, int dep, Road s)
        {
            zoneType = z;
            density = den;
            distanceFromLeftIntersection = dfli;
            width = w;
            depth = dep;
            landValue = 100; //needs to be dynamic based on surroundings
            developed = false;
            street = s;
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

        public float Area
        {
            get
            {
                return width * depth;
            }
        }

        public double DistanceFromLeftIntersection
        {
            get
            {
                return distanceFromLeftIntersection;
            }
            set
            {
                distanceFromLeftIntersection = value;
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

        public Road Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
    }
}
