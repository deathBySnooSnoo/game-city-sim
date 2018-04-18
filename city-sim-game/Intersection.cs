using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_sim_game
{
    class Intersection
    {
        private string id;
        private Tuple<int, int> upperLeftCorner;
        private Tuple<int, int> lowerRightCorner;

        public Intersection(Tuple<int, int> ulc, Tuple<int, int> lrc)
        {
            id = "";
            upperLeftCorner = ulc;
            lowerRightCorner = lrc;
        }

        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
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
    }
}
