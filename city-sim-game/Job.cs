using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_sim_game
{
    class Job : Occupation
    {
        private Business workplace;

        public Job(Business b)
        {
            workplace = b;
        }

        public Business Workplace
        {
            get
            {
                return workplace;
            }
            set
            {
                workplace = value;
            }
        }
    }
}
