using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_sim_game
{
    class Person
    {
        private string firstName;
        private string lastName;
        private string occupation;
        private int income;
        private ResidentialBuilding home;
        private Business work;
        private bool isFemale;
        private int educationLevel;
        private bool isMarried;
        private int[] birthday;
        private Person spouse;
        private static Random rand = new Random();

        public Person()
        {
            Random rand = new Random();
            birthday = People.GetRandomBirthday();
            if (rand.Next(2) == 1)
            {
                isMarried = true;
            }
            else
            {
                isMarried = false;
            }
            if (rand.Next(2) == 1)
            {
                isFemale = true;
            }
            else
            {
                isFemale = false;
            }
            firstName = People.GetRandomFirstName(isFemale);
            if (isMarried && isFemale) 
            {
                spouse = new Person(this);
                lastName = spouse.LastName;
            }
            else if (isMarried && !isFemale)
            {
                lastName = People.GetRandomLastName();
                spouse = new Person(this);
            }
            else
            {
                lastName = People.GetRandomLastName();
                spouse = null;
            }
            educationLevel = rand.Next(8, 20);
            Occupation occ = People.GetRandomOccupation(educationLevel);
            occupation = occ.Name;
            income = occ.Salary;
        }

        public Person(Person sp)
        {
            spouse = sp;
            isFemale = !spouse.IsFemale;
            isMarried = true;
            firstName = People.GetRandomFirstName(isFemale);
            if (isFemale)
            {
                lastName = spouse.LastName;
            }
            else
            {
                lastName = People.GetRandomLastName();
            }
            birthday = People.GetRandomBirthday();
            educationLevel = rand.Next(8, 20);
            Occupation occ = People.GetRandomOccupation(educationLevel);
            occupation = occ.Name;
            income = occ.Salary;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Occupation
        {
            get
            {
                return occupation;
            }
            set
            {
                occupation = value;
            }
        }

        public int Income
        {
            get
            {
                return income;
            }
            set
            {
                income = value;
            }
        }

        public ResidentialBuilding Home
        {
            get
            {
                return home;
            }
            set
            {
                home = value;
            }
        }

        public Business Work
        {
            get
            {
                return work;
            }
            set
            {
                work = value;
            }
        }

        public bool IsFemale
        {
            get
            {
                return isFemale;
            }
            set
            {
                isFemale = value;
            }
        }

        public int EducationLevel
        {
            get
            {
                return educationLevel;
            }
            set
            {
                educationLevel = value;
            }
        }

        public bool IsMarried
        {
            get
            {
                return isMarried;
            }
            set
            {
                isMarried = value;
            }
        }

        public int[] Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }

        public Person Spouse
        {
            get
            {
                return spouse;
            }
            set
            {
                spouse = value;
            }
        }
    }
}
