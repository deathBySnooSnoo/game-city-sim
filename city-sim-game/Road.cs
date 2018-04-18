using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_sim_game
{
    class Road
    {
        private int lanes;
        private bool[] laneDirections; //true is away from camera when looking along the road/left to right when horizontal; false is toward camera when looking along the road/right to left when horizontal
        private int speedLimit;
        private string name;
        private Tuple<int, int> start; //center lane or tie break to the higher coordinate number center lane
        private Tuple<int, int> end;
        
        public Road(Tuple<int, int> s, Tuple<int, int> e, int laneCount, int sl, bool[] ld)
        {
            start = s;
            end = e;
            lanes = laneCount;
            speedLimit = sl;
            name = "";
            laneDirections = ld;
        }

        public int Lanes
        {
            get
            {
                return lanes;
            }
            set
            {
                lanes = value;
            }
        }

        public bool[] LaneDirections
        {
            get
            {
                return laneDirections;
            }
            set
            {
                laneDirections = value;
            }
        }
    }
}
