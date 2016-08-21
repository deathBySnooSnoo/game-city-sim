/**
    Class for a Person
*/

#include <iostream>
#include <string>
#include <sqlite3.h>
#include "lot.h"

using namespace std;

class Person{

    private:

        string birthday;
        string firstName;
        string lastName;
        int personality;
        lot home;
        lot work;
        int wealth;
        bool female;
        bool married;
        person spouse;
        person dad;
        person mom;
        int educationLevel;
        job job;
        int age;
        bool alive;

    public:

        //Constructor for a new person from outside the settled region
        Person::Person(){
            birthday = people.getRandomBirthday(game.getDate());
            lastName = people.getRandomLastName();
            personality = people.getRandomPersonality();
            educationLevel = people.getRandomEducationLevel();
            job = employment.getAvailableJob(educationLevel);
            work = job.getLot();
            wealth = job.getPay();
            female = people.getGender();
            firstName = people.getRandomFirstName(female);
            married = people.getMarried();
            if(isMarried){
                spouse = person(true, !isFemale, lastName);
                home = residential.getAvailable(wealth + spouse.getWealth());
                spouse.setHome(home);
            }
            else{
                home = residential.getAvailable(wealth);
            }
        }
        
        //Constructor for a newborn
        Person::Person(bool born, person father, person mother){
            female = people.getGender();
            birthday = game.getDate();
            firstName = people.getRandomFirstName(female);
            lastName = dad.getLastName();
            if(dad.isAlive()){
                home = dad.getHome();
            }
            else if(mom.isAlive()){
                home = mom.getHome();
            }
            else{
                home = people.getRandomCouple();
            }
            dad = father;
            mom = mother;
            personality = people.getRandomPersonality();
        }
    
        //Constructor for the spouse of an outside settled region spawn
        Person::Person(bool married, bool female, person spouse){
            female = female;
            married = married;
            spouse = spouse;
            firstName = people.getRandomFirstName(female);
            lastName = spouse.getLastName();
            birthday = people.getRandomBirthday(game.getDate());
            personality = people.getRandomPersonality();
            educationLevel = people.getRandomEduationLevel();
            job = employment.getAvailableJob(educationLevel);
            work = job.getLot();
            wealth = job.getPay();
        }
        
        bool isMarried(){
            return married;
        }

        string getLastName(){
            return lastName;
        }

        location getHome(){
            return home;
        }
        
        void setHome(lot h){
            home = h;
        }
};
