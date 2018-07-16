using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_sim_game
{
    class ConvenienceStore : Business
    {
        private const string bizType = "convenience store";
        private string name;
        private int revenue;
        private int employees;
        private List<Job> jobs;
        private CommercialBuilding building;

        public ConvenienceStore()
        {
            Name = "";
            Revenue = 0;
            Employees = 0;
            Jobs = new List<Job>();
            foreach (KeyValuePair<string, int> j in BusinessType.GetBusinessByType(bizType).Jobs)
            {
                for (int i = 0; i < j.Value; i++)
                {
                    Job temp = new Job(this, Occupation.GetOccupationByName(j.Key));
                    CitySimGame.AvailableJobs.Add(temp);
                    Jobs.Add(temp);
                }
            }
            building = FindLocationForBusiness();
        }

        private CommercialBuilding FindLocationForBusiness()
        {
            List<CommercialBuilding> availableBuildings = CitySimGame.Map.GetAvailableCommercialBuildings();
            if (availableBuildings != null || availableBuildings.Count > 0)
            {
                foreach (CommercialBuilding cb in availableBuildings)
                {
                    if (CitySimGame.Map.DistanceToNearestBusinessOfType(bizType, cb.BuildingLot) > 1 && CitySimGame.Map.DistanceToNearestResidence(cb.BuildingLot) < 1) //miles; should figure out how to change it for travel time for typical mode of travel
                    {
                        cb.BusinessCount++;
                        return cb;
                    }
                }
            }
            else if (CitySimGame.Map.AvailableCommercial > 0)
            {
                foreach (Lot l in CitySimGame.Map.Lots)
                {
                    if (l.ZoneType == 'c')
                    {
                        if (CitySimGame.Map.DistanceToNearestBusinessOfType(bizType, l) > 1 && CitySimGame.Map.DistanceToNearestResidence(l) < 1) //miles
                        {
                            l.Developed = true;
                            return CitySimGame.Map.AddShops(new CommercialBuilding(l, 1, 1, 1));
                        }
                    }
                }
            }
            CitySimGame.Demands.CommercialLots++;
            return null;
        }

        public new string BizType
        {
            get
            {
                return bizType;
            }
        }

        public new CommercialBuilding Building
        {
            get
            {
                return building;
            }
            set
            {
                building = value;
            }
        }
    }
}
