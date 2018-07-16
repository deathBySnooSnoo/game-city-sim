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
        private double distance;
        
        public Road(Intersection s, Intersection e, int laneCount, int sl, bool[] ld, double length)
        {
            start = s;
            end = e;
            lanes = laneCount;
            speedLimit = sl;
            name = "";
            laneDirections = ld;
            distance = length;
        }

        public Intersection GetOppositeEnd(Intersection x)
        {
            if (start == x)
            {
                return end;
            }
            else if (end == x)
            {
                return start;
            }
            else
            {
                return null;
            }
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

        public double Distance
        {
            get
            {
                return distance;
            }
            set
            {
                distance = value;
            }
        }

        public double OptimalTraversalTime
        {
            get
            {
                return distance / speedLimit;
            }
        }
    }
}
