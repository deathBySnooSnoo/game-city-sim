using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_sim_game
{
    class Map
    {
        private List<Lot> lots;
        private int[,] tiles; //change data type to accommodate road or zone or whatever
        private List<Tuple<int,int>> availableAg; //change because tiles
        private List<Farm> farms;
        private List<Tuple<int, int>> availableResidential; //change because tiles
        private List<ResidentialBuilding> housing;
        private List<Tuple<int, int>> availableCommercial; //change because tiles
        private List<CommercialBuilding> shops;

        public Map(int x, int y)
        {
            tiles = new int[x, y];
            availableAg = new List<Tuple<int, int>>();
            farms = new List<Farm>();
            availableResidential = new List<Tuple<int, int>>();
            housing = new List<ResidentialBuilding>();
            availableCommercial = new List<Tuple<int, int>>();
            shops = new List<CommercialBuilding>();
        }

        public void NewZone()
        {
            int x = ReadXCoordinate();
            int y = ReadYCoordinate();
            Lot l = GetLot(x, y);
            if (!l.Zoned)
            {
                l.ZoneType = ReadZoneType();
                l.Density = ReadDensity();
                l.Zoned = true;
                if(l.ZoneType == 'a')
                {
                    availableAg.Add(Tuple.Create(x, y));
                }
                else if(l.ZoneType == 'r')
                {
                    availableResidential.Add(Tuple.Create(x, y));
                }
            }
            else
            {
                Console.WriteLine("Already zoned.");
            }
        }

        public void CheckZone()
        {
            Lot l = GetLot(ReadXCoordinate(), ReadYCoordinate());
            Console.WriteLine("Zone: " + l.ZoneType + " Density: " + l.Density);
        }

        public void ChangeZone()
        {
            Lot l = GetLot(ReadXCoordinate(), ReadYCoordinate());
            Console.WriteLine("Current Settings: \nZone: " + l.ZoneType + " Density: " + l.Density);
            l.ZoneType = ReadZoneType();
            l.Density = ReadDensity();
        }

        public void RemoveZone()
        {
            Lot l = GetLot(ReadXCoordinate(), ReadYCoordinate());
            l.ZoneType = '\0';
            l.Density = '\0';

        }

        public Lot GetLot(int x, int y)
        {
            return lots[tiles[x, y]];
        }

        #region CommandLine Specific Reads
        private int ReadXCoordinate()
        {
            Console.WriteLine("x: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private int ReadYCoordinate()
        {
            Console.WriteLine("y: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private char ReadZoneType()
        {
            Console.WriteLine("type: ");
            return Convert.ToChar(Console.ReadLine());
        }

        private char ReadDensity()
        {
            Console.WriteLine("density: ");
            return Convert.ToChar(Console.ReadLine());
        }
#endregion

        public List<Tuple<int,int>> AvailableAg
        {
            get
            {
                return availableAg;
            }
        }

        public void RemoveAvailableAg(Tuple<int, int> i)
        {
            availableAg.Remove(i);
        }

        public List<Farm> Farms
        {
            get
            {
                return farms;
            }
        }

        public void AddFarm(Farm f)
        {
            farms.Add(f);
        }

        public void RemoveFarm(Farm f)
        {
            farms.Remove(f);
        }

        public List<Tuple<int, int>> AvailableResidential
        {
            get
            {
                return availableResidential;
            }
        }

        public void RemoveAvailableResidential(Tuple<int, int> i)
        {
            availableResidential.Remove(i);
        }

        public List<ResidentialBuilding> Housing
        {
            get
            {
                return housing;
            }
        }

        public void AddHousing(ResidentialBuilding r)
        {
            housing.Add(r);
        }

        public void RemoveHousing(ResidentialBuilding r)
        {
            housing.Remove(r);
        }
    }
}
