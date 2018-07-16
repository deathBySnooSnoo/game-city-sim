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
        private List<Road> connectedRoads;

        public Intersection()
        {
            //id = something unique
            connectedRoads = new List<Road>();
        }

        public Road GetConnection(Intersection x)
        {
            foreach (Road r in connectedRoads)
            {
                if (r.GetOppositeEnd(this) == x)
                {
                    return r;
                }
            }
            return null;
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

        public List<Road> ConnectedRoads
        {
            get
            {
                return connectedRoads;
            }
        }
        public void AddConnectedRoad(Road r)
        {
            if (!connectedRoads.Contains(r))
            {
                connectedRoads.Add(r);
            }
        }
    }
}
