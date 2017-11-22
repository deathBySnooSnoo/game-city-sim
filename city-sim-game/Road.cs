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
        
        public Road()
        {

        }
    }
}
