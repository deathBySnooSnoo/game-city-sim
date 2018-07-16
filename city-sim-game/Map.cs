using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace city_sim_game
{
    class Map
    {
        private List<Lot> lots;
        private List<Farm> farms;
        private List<ResidentialBuilding> housing;
        private List<CommercialBuilding> shops;
        private List<IndustrialBuilding> industry;
        private List<Intersection> intersections;
        private int availableAg;
        private int availableResidential;
        private int availableCommercial;
        private int availableIndustrial;

        public Map()
        {
            lots = new List<Lot>();
            farms = new List<Farm>();
            housing = new List<ResidentialBuilding>();
            shops = new List<CommercialBuilding>();
            industry = new List<IndustrialBuilding>();
            intersections = new List<Intersection>();
            availableAg = 0;
            availableCommercial = 0;
            availableIndustrial = 0;
            availableResidential = 0;
        }

        private void AddZone(double dfli, int w, int h, char z, char d, Road s)
        {
            int index = -1;
            if (z == 'r')
            {
                lots.Add(new Lot(z, d, dfli, w, h, s));
                index = lots.Count - 1;
                availableResidential++;
            }
            else if (z == 'c')
            {
                lots.Add(new Lot(z, d, dfli, w, h, s));
                index = lots.Count - 1;
                availableCommercial++;
            }
            else if (z == 'a')
            {
                lots.Add(new Lot(z, d, dfli, w, h, s));
                index = lots.Count - 1;
                availableAg++;
            }
            else if (z == 'i')
            {
                lots.Add(new Lot(z, d, dfli, w, h, s));
                index = lots.Count - 1;
                availableIndustrial++;
            }
        }

        public double DistanceToNearestBusinessOfType(string bizType, Lot lot)
        {
            //if "bizType" is "any" search for any commercial lot
            return 0;
        }

        public double DistanceToNearestResidence(Lot lot) //have one for a cluster of residences too?
        {
            return 0;
        }

        public List<ResidentialBuilding> GetAvailableHouses()
        {
            List<ResidentialBuilding> availableHouses = new List<ResidentialBuilding>();
            foreach (ResidentialBuilding rb in housing)
            {
                if (rb.OccupiedHomes < rb.TotalHomes)
                {
                    availableHouses.Add(rb);
                }
            }
            return availableHouses;
        }

        public List<CommercialBuilding> GetAvailableCommercialBuildings()
        {
            List<CommercialBuilding> availableShops = new List<CommercialBuilding>();
            foreach (CommercialBuilding cb in shops)
            {
                if (cb.BusinessCount < cb.AvailableSpaces)
                {
                    availableShops.Add(cb);
                }
            }
            return availableShops;
        }

        public List<Farm> Farms
        {
            get
            {
                return farms;
            }
        }

        public Farm AddFarm(Farm f)
        {
            farms.Add(f);
            return f;
        }

        public void RemoveFarm(Farm f)
        {
            farms.Remove(f);
        }

        public List<ResidentialBuilding> Housing
        {
            get
            {
                return housing;
            }
        }

        public ResidentialBuilding AddHousing(ResidentialBuilding r)
        {
            housing.Add(r);
            return r;
        }

        public void RemoveHousing(ResidentialBuilding r)
        {
            housing.Remove(r);
        }

        public List<CommercialBuilding> Shops
        {
            get
            {
                return shops;
            }
        }

        public CommercialBuilding AddShops(CommercialBuilding c)
        {
            shops.Add(c);
            return c;
        }

        public void RemoveShops(CommercialBuilding c)
        {
            shops.Remove(c);
        }

        public List<IndustrialBuilding> Industry
        {
            get
            {
                return industry;
            }
        }

        public IndustrialBuilding AddIndustry(IndustrialBuilding i)
        {
            industry.Add(i);
            return i;
        }

        public void RemoveIndustry(IndustrialBuilding i)
        {
            industry.Remove(i);
        }

        public List<Intersection> Intersections
        {
            get
            {
                return intersections;
            }
        }

        public int AvailableAg
        {
            get
            {
                return availableAg;
            }
            set
            {
                availableAg = value;
            }
        }

        public int AvailableResidential
        {
            get
            {
                return availableResidential;
            }
            set
            {
                availableResidential = value;
            }
        }

        public int AvailableCommercial
        {
            get
            {
                return availableCommercial;
            }
            set
            {
                availableCommercial = value;
            }
        }

        public int AvailableIndustrial
        {
            get
            {
                return availableIndustrial;
            }
            set
            {
                availableIndustrial = value;
            }
        }

        public List<Lot> Lots
        {
            get
            {
                return lots;
            }
        }
    }
}
