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
        private int commercial;
        private int industrial;
        private int agricultural;

        public Demand()
        {
            lowIncomeResidential = 50;
            mediumIncomeResidential = 50;
            highIncomeResidential = 50;
            commercial = 50;
            industrial = 50;
            agricultural = 50;
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

        public int Commercial
        {
            get
            {
                return commercial;
            }
            set
            {
                commercial = value;
            }
        }

        public int Industrial
        {
            get
            {
                return industrial;
            }
            set
            {
                industrial = value;
            }
        }

        public int Agricultural
        {
            get
            {
                return agricultural;
            }
            set
            {
                agricultural = value;
            }
        }
    }
}
