using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_sim_game
{
    class Demand
    {
        private int lowIncomeResidential;
        private int mediumIncomeResidential;
        private int highIncomeResidential;
        private int clothingStores;
        private int groceryStores;
        private int convenienceStores;

        public Demand()
        {
            lowIncomeResidential = 100;
            mediumIncomeResidential = 100;
            highIncomeResidential = 100;
            clothingStores = 100;
            groceryStores = 100;
            convenienceStores = 100;
        }

        public bool CommercialDemandExists()
        {
            if (clothingStores > 0 || groceryStores > 0 || convenienceStores > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int LowIncomeResidential
        {
            get
            {
                return lowIncomeResidential;
            }
            set
            {
                lowIncomeResidential = value;
            }
        }

        public int MediumIncomeResidential
        {
            get
            {
                return mediumIncomeResidential;
            }
            set
            {
                mediumIncomeResidential = value;
            }
        }

        public int HighIncomeResidential
        {
            get
            {
                return highIncomeResidential;
            }
            set
            {
                highIncomeResidential = value;
            }
        }

        public int ClothingStores
        {
            get
            {
                return clothingStores;
            }
            set
            {
                clothingStores = value;
            }
        }

        public int GroceryStores
        {
            get
            {
                return groceryStores;
            }
            set
            {
                groceryStores = value;
            }
        }

        public int ConvenienceStores
        {
            get
            {
                return convenienceStores;
            }
            set
            {
                convenienceStores = value;
            }
        }
    }
}
