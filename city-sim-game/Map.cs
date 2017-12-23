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
        private Tile[,] tiles;
        private List<Farm> farms;
        private List<ResidentialBuilding> housing;
        private List<CommercialBuilding> shops;
        private List<IndustrialBuilding> industry;
        private int availableAg;
        private int availableResidential;
        private int availableCommercial;
        private int availableIndustrial;

        public Map(int x, int y)
        {
            tiles = new Tile[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    tiles[i, j] = new Tile();
                }
            }
            lots = new List<Lot>();
            farms = new List<Farm>();
            housing = new List<ResidentialBuilding>();
            shops = new List<CommercialBuilding>();
            industry = new List<IndustrialBuilding>();
            availableAg = 0;
            availableCommercial = 0;
            availableIndustrial = 0;
            availableResidential = 0;
        }

        public void Zone()
        {
            int x1 = ReadXCoordinate();
            int y1 = ReadYCoordinate();
            int x2 = ReadXCoordinate();
            int y2 = ReadYCoordinate();
            char z = ReadZoneType();
            char d = ReadDensity();
            AddZone(x1, y1, x2, y2, z, d);
        }

        private void AddZone(int x1, int y1, int x2, int y2, char z, char d)
        {
            int index = -1;
            if (z == 'r')
            {
                lots.Add(new Lot(z, d, new Tuple<int, int>(x1, y1), new Tuple<int, int>(x2, y2)));
                index = lots.Count - 1;
                availableResidential++;
            }
            else if (z == 'c')
            {
                lots.Add(new Lot(z, d, new Tuple<int, int>(x1, y1), new Tuple<int, int>(x2, y2)));
                index = lots.Count - 1;
                availableCommercial++;
            }
            else if (z == 'a')
            {
                lots.Add(new Lot(z, d, new Tuple<int, int>(x1, y1), new Tuple<int, int>(x2, y2)));
                index = lots.Count - 1;
                availableAg++;
            }
            else if (z == 'i')
            {
                lots.Add(new Lot(z, d, new Tuple<int, int>(x1, y1), new Tuple<int, int>(x2, y2)));
                index = lots.Count - 1;
                availableIndustrial++;
            }
            if (index > -1)
            {
                for (int i = x1; i < x2 + 1; i++)
                {
                    for (int j = y1; j < y2 + 1; j++)
                    {
                        if (tiles[i, j].AvailableForZoning)
                        {
                            tiles[i, j].ZoningList = z;
                            tiles[i, j].Key = index;
                            tiles[i, j].AvailableForZoning = false;
                        }
                        else
                        {
                            RemoveZone(x1, y1, i, j);
                            return;
                        }
                    }
                }
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
            for (int i = x2; i > x1 - 1; i--)
            {
                for (int j = y2; j > y1 - 1; j--)
                {
                    if (i == x1 && j == y1)
                    {
                        if (tiles[i, j].ZoningList == 'r')
                        {
                            availableResidential--;
                        }
                        else if (tiles[i, j].ZoningList == 'c')
                        {
                            availableCommercial--;
                        }
                        else if (tiles[i, j].ZoningList == 'a')
                        {
                            availableAg--;
                        }
                        else if (tiles[i, j].ZoningList == 'i')
                        {
                            availableIndustrial--;
                        }
                        lots.RemoveAt(tiles[i, j].Key);
                    }
                    tiles[i, j].AvailableForZoning = true;
                    tiles[i, j].Key = -1;
                    tiles[i, j].ZoningList = '\0';
                }
            }
        }

        public Lot GetLot(int x, int y)
        {
            return lots[tiles[x, y].Key];
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

        public List<CommercialBuilding> Shops
        {
            get
            {
                return shops;
            }
        }

        public void AddShops(CommercialBuilding c)
        {
            shops.Add(c);
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

        public void AddIndustry(IndustrialBuilding i)
        {
            industry.Add(i);
        }

        public void RemoveIndustry(IndustrialBuilding i)
        {
            industry.Remove(i);
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
