using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_sim_game
{
    class Lake
    {
        private Tuple<int, int> upperLeftCorner;
        private Tuple<int, int> lowerRightCorner;

        public Lake(Tuple<int, int> ulc, Tuple<int, int> lrc)
        {
            upperLeftCorner = ulc;
            lowerRightCorner = lrc;
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
