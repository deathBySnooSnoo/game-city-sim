using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_sim_game
{
    class Occupation
    {
        private string name;
        private int salary;
        private int education;

        public Occupation()
        {

        }

        public static Occupation[] GetOccupationsByEducation(int education)
        {
            List<Occupation> occupations = new List<Occupation>();
            foreach (Occupation o in CitySimGame.Occupations)
            {
                if (o.Education <= education)
                {
                    occupations.Add(o);
                }
            }
            return occupations.ToArray();
        }

        public static Occupation GetOccupationByName(string occupationName)
        {
            foreach (Occupation o in CitySimGame.Occupations)
            {
                if (o.Name.Equals(occupationName))
                {
                    return o;
                }
            }
            return null;
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

        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        public int Education
        {
            get
            {
                return education;
            }
            set
            {
                education = value;
            }
        }
    }
}
