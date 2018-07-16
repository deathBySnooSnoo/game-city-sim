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
        private Tile[,] tiles;
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
            Bitmap oilmap = new Bitmap("Oil_Map.bmp");
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

        public void Zone()
        {
            int x1 = ReadXCoordinate();
            int y1 = ReadYCoordinate();
            int width = ReadWidth();
            int height = ReadHeight();
            char z = ReadZoneType();
            char d = ReadDensity();
            AddZone(x1, y1, width, height, z, d);
        }

        private void AddZone(int x1, int y1, int w, int h, char z, char d)
        {
            int index = -1;
            if (z == 'r')
            {
                lots.Add(new Lot(z, d, new Tuple<int, int>(x1, y1), w, h));
                index = lots.Count - 1;
                availableResidential++;
            }
            else if (z == 'c')
            {
                lots.Add(new Lot(z, d, new Tuple<int, int>(x1, y1), w, h));
                index = lots.Count - 1;
                availableCommercial++;
            }
            else if (z == 'a')
            {
                lots.Add(new Lot(z, d, new Tuple<int, int>(x1, y1), w, h));
                index = lots.Count - 1;
                availableAg++;
            }
            else if (z == 'i')
            {
                lots.Add(new Lot(z, d, new Tuple<int, int>(x1, y1), w, h));
                index = lots.Count - 1;
                availableIndustrial++;
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

        public void Dezone()
        {
            int x1 = ReadXCoordinate();
            int y1 = ReadYCoordinate();
            int x2 = ReadXCoordinate();
            int y2 = ReadYCoordinate();
            RemoveZone(x1, y1, x2, y2);
        }

        private void RemoveZone(int x1, int y1, int x2, int y2)
        {

        }

        public Lot GetLot(int x, int y)
        {
            return lots[tiles[x, y].Key];
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

        public void NewRoad()
        {
            BuildRoad(ReadXCoordinate(), ReadYCoordinate(), ReadXCoordinate(), ReadYCoordinate());
        }

        private void BuildRoad(int x1, int y1, int x2, int y2)
        {
            
        }

        private void DestroyRoad(int x1, int y1, int x2, int y2)
        {

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

        private int ReadWidth()
        {
            Console.WriteLine("width: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private int ReadHeight()
        {
            Console.WriteLine("height: ");
            return Convert.ToInt32(Console.ReadLine());
        }
#endregion

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

        public Tile[,] Tiles
        {
            get
            {
                return tiles;
            }
        }
    }
}
