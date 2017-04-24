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
        private bool zoned;

        public Lot()
        {
            landValue = 100;
            zoned = false;
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

        public bool Zoned
        {
            get
            {
                return zoned;
            }
            set
            {
                zoned = value;
            }
        }
    }
}
