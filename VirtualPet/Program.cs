using System;
using System.Collections.Generic;

namespace VirtualPet
{
    class Program
    {

        static void Main(string[] args)
        {
            //Create Virtual Pet
            VirtualPet myCat = new VirtualPet();

            //Create Shelter
            VirtualPetShelter myShelter = new VirtualPetShelter();

            //create menu here
            //menu options here is to add pet to shelter
            string menuChoice = "";
            bool isPlaying = true;

            while (isPlaying)
            {
                Console.WriteLine("Virtual Pet Menu");
                Console.WriteLine("1. Add a Pet to shelter");
                Console.WriteLine("2. Show All My Pets Info");
                Console.WriteLine("3. Display All Pets Status");
                Console.WriteLine("4. Feed All Pets");
                Console.WriteLine("5. Take All Pets to Doctor");
                Console.WriteLine("6. Play with All Pets");
                Console.WriteLine("9. Exit");
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":

                        myCat.AddPetAndSpecies();
                        myShelter.AddPetToShelter(myCat);
                        break;

                    case "2":
                        //Show All Pets Names and Species
                        myShelter.ViewAllPetsInfo();
                        break;

                    case "3":
                        //Show Pets Health, Boredom, Hunger
                        myShelter.ViewAllPetsStatus();
                        break;

                    case "4":
                        //Feed The Pet
                        myShelter.FeedAllPets();
                        break;

                    case "5":
                        //Took Pet to Doctor
                        myShelter.TakeAllPetsToDoctor();
                        break;

                    case "6":
                        //Play with pet
                        //hunger lvl increases, boredom decreases, health increases
                        myShelter.PlayWithAllPets();
                        break;
                    case "9":
                        //Set isPlaying to False and will exit the program
                        isPlaying = false;
                        break;
                    default:
                        break;

                }


            }





            Console.ReadLine();


        }
    }
}


