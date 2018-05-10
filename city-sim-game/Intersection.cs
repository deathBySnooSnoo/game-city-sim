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
        private Tuple<int, int> center;

        public Intersection(Tuple<int, int> c)
        {
            id = "";
            center = c;
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

        public Tuple<int, int> Center
        {
            get
            {
                return center;
            }
            set
            {
                center = value;
            }
        }
    }
}
