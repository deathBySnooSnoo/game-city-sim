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
        private bool[] laneDirections; //true is positive direction; false is negative direction
        private int speedLimit;
        private string name;
        private Intersection start;
        private Intersection end;
        
        public Road(Intersection s, Intersection e, int laneCount, int sl, bool[] ld)
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

        public int SpeedLimit
        {
            get
            {
                return speedLimit;
            }
            set
            {
                speedLimit = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Intersection Start
        {
            get
            {
                return start;
            }
            set
            {
                start = value;
            }
        }

        public Intersection End
        {
            get
            {
                return end;
            }
            set
            {
                end = value;
            }
        }
    }
}
