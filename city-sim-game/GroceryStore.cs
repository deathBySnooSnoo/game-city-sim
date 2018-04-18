using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_sim_game
{
    class GroceryStore : Business
    {
        private const string bizType = "grocery store";
        private string name;
        private int revenue;
        private int employees;
        private List<Job> jobs;
        private CommercialBuilding building;

        public GroceryStore()
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
            building = null;
        }

        private void FindLocationForBusiness()
        {
            List<CommercialBuilding> availableBuildings = CitySimGame.Map.GetAvailableCommercialBuildings();
            if (availableBuildings == null)
            {

            }
            else
            {
                foreach (CommercialBuilding cb in availableBuildings)
                {
                    
                }
            }
        }

        public String BizType
        {
            get
            {
                return bizType;
            }
        }

        public CommercialBuilding Building
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
