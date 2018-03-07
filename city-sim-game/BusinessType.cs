using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_sim_game
{
    class BusinessType
    {
        private char zoning;
        private string type;
        private Dictionary<string, int> jobs;

        public BusinessType()
        {
            zoning = '\0';
            type = "";
            jobs = new Dictionary<string, int>();
        }

        public static BusinessType[] GetBusinessByZoning(char zone)
        {
            List<BusinessType> bTypes = new List<BusinessType>();
            foreach (BusinessType bt in CitySimGame.BusinessTypes)
            {
                if (bt.Zoning == zone)
                {
                    bTypes.Add(bt);
                }
            }
            return bTypes.ToArray();
        }

        public static BusinessType GetBusinessByType(string type)
        {
            foreach (BusinessType bt in CitySimGame.BusinessTypes)
            {
                if (bt.Type.Equals(type))
                {
                    return bt;
                }
            }
            return null;
        }

        public char Zoning
        {
            get
            {
                return zoning;
            }
            set
            {
                zoning = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public Dictionary<string, int> Jobs
        {
            get
            {
                return jobs;
            }
        }
    }
}
