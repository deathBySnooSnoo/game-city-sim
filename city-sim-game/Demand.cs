using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_sim_game
{
    class Demand
    {
        private int residential;
        private int commercial;
        private int industrial;
        private int agricultural;

        public Demand()
        {
            residential = 50;
            commercial = 50;
            industrial = 50;
            agricultural = 100;
        }

        public int Residential
        {
            get
            {
                return residential;
            }
            set
            {
                residential = value;
            }
        }

        public int Commercial
        {
            get
            {
                return commercial;
            }
            set
            {
                commercial = value;
            }
        }

        public int Industrial
        {
            get
            {
                return industrial;
            }
            set
            {
                industrial = value;
            }
        }

        public int Agricultural
        {
            get
            {
                return agricultural;
            }
            set
            {
                agricultural = value;
            }
        }
    }
}
