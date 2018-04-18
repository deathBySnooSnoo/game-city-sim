using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_sim_game
{
    class People
    {
        private static Random rand = new Random();

        //0-1-2 = m-d-y
        public static int[] GetRandomBirthday()
        {
            int currentYear = GameTime.Year;
            int[] birthday = new int[3];
            birthday[2] = rand.Next(currentYear - 90, currentYear - 17);
            birthday[0] = rand.Next(1, 13);
            if(birthday[0] == 4 || birthday[0] == 6 || birthday[0] == 9 || birthday[0] == 11)
            {
                birthday[1] = rand.Next(1, 31);
            }
            else if(birthday[0] == 2)
            {
                birthday[1] = rand.Next(1, 29);
            }
            else
            {
                birthday[1] = rand.Next(1, 32);
            }
            return birthday;
        }

        public static string GetRandomFirstName(bool isFemale)
        {
            if (isFemale)
            {
                return CitySimGame.FemaleNames[rand.Next(CitySimGame.FemaleNames.Length)];
            }
            else
            {
                return CitySimGame.MaleNames[rand.Next(CitySimGame.MaleNames.Length)];
            }
        }

        public static string GetRandomLastName()
        {
            return CitySimGame.LastNames[rand.Next(CitySimGame.LastNames.Length)];
        }

        public static Occupation GetRandomOccupation(int education)
        {
            Occupation[] suitableOccupations = Occupation.GetOccupationsByEducation(education);
            if (suitableOccupations == null)
            {
                return null;
            }
            else
            {
                return suitableOccupations[rand.Next(suitableOccupations.Length)];
            }
        }

        public static bool HaveBaby()
        {
            if (rand.Next(1, 1000) < 14)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
