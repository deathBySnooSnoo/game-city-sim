﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_sim_game
{
    class Map
    {
        private List<Lot> lots; //unnecessary with changes to availability lists?
        private Tuple<int, char>[,] tiles;
        private List<Lot> availableAg; //change because tiles; done?
        private List<Farm> farms;
        private List<Lot> availableResidential; //change because tiles; done?
        private List<ResidentialBuilding> housing;
        private List<Lot> availableCommercial; //change because tiles; done?
        private List<CommercialBuilding> shops;

        public Map(int x, int y)
        {
            tiles = new Tuple<int, char>[x, y]; //int: position in array specified by char; char: t=transport, r=residential, c=commercial, i=industrial, a=ag
            availableAg = new List<Lot>();
            farms = new List<Farm>();
            availableResidential = new List<Lot>();
            housing = new List<ResidentialBuilding>();
            availableCommercial = new List<Lot>();
            shops = new List<CommercialBuilding>();
        }

        public void Zone()
        {
            int index = -1;
            int x1 = ReadXCoordinate();
            int y1 = ReadYCoordinate();
            int x2 = ReadXCoordinate();
            int y2 = ReadYCoordinate();
            char z = ReadZoneType();
            char d = ReadDensity();
            if (z == 'r')
            {
                availableResidential.Add(new Lot(z, d, new Tuple<int, int>(x1, y1), new Tuple<int, int>(x2, y2)));
                index = availableResidential.Count;
            }
            else if (z == 'c')
            {
                availableCommercial.Add(new Lot(z, d, new Tuple<int, int>(x1, y1), new Tuple<int, int>(x2, y2)));
                index = availableCommercial.Count;
            }
            else if (z == 'a')
            {
                availableAg.Add(new Lot(z, d, new Tuple<int, int>(x1, y1), new Tuple<int, int>(x2, y2)));
                index = availableAg.Count;
            }
            if (index >= 0)
            {
                for (int i = x1; i < x2 + 1; i++)
                {
                    for (int j = y1; j < y2 + 1; j++)
                    {
                        if (tiles[i, j] == null)
                        {
                            tiles[i, j] = new Tuple<int, char>(index, z);
                        }
                        else if (tiles[i, j].Item2 == z)
                        {
                            if (tiles[i, j].Item2 == 'r')
                            {

                            }
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

        public void RemoveZone()
        {
            Lot l = GetLot(ReadXCoordinate(), ReadYCoordinate());
            l.ZoneType = '\0';
            l.Density = '\0';

        }

        public Lot GetLot(int x, int y)
        {
            return lots[tiles[x, y].Item1];
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

        public List<Lot> AvailableAg
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

        public List<Lot> AvailableResidential
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
