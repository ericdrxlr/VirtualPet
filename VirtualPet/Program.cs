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
            bool userPlaying = true;

            while (userPlaying)
            {
                Console.WriteLine("\nVirtual Pet Menu:");
                Console.WriteLine("1. Add A Pet To Shelter");
                Console.WriteLine("2. Display All My Pets Info");
                Console.WriteLine("3. Display All Pets Status");
                Console.WriteLine("4. Interact With A Pet");
                Console.WriteLine("5. Interact With All Pets");
                Console.WriteLine("6. Exit\n");
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        myCat = new VirtualPet();
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
                        //Interact with 1 pet
                        myShelter.InteractWith1Pet();
                        break;

                    case "5":
                        //Interact with All Pets
                        myShelter.InteractWithAllPets();
                        break;

                    case "6":
                        //Set isPlaying to False and will exit the program
                        userPlaying = false;
                     
                        break;
                    default:
                        break;

                }


            }





            Console.ReadLine();


        }
    }
}


