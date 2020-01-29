using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class VirtualPetShelter

    {
        //Create a new List
        List<VirtualPet> myPetList = new List<VirtualPet>();

        public void AddPetToShelter(VirtualPet myCat)
        {
            myPetList.Add(new VirtualPet(myCat.Name, myCat.Species));
        }

        public void ViewAllPetsInfo()
        {
            foreach (VirtualPet petList in myPetList)
            {
                petList.ViewPetInfo();
            }
        }

        public void ViewAllPetsStatus()
        {
            foreach (VirtualPet petList in myPetList)
            {
                petList.PetStatus();
            }
        }
        public void FeedAllPets()
        {
            foreach (VirtualPet petList in myPetList)
            {
                petList.FeedPet();
            }
        }

        public void PlayWithAllPets()
        {
            foreach (VirtualPet petList in myPetList)
            {
                petList.PlayWithPet();
            }
        }
        public void TakeAllPetsToDoctor()
        {
            foreach (VirtualPet petList in myPetList)
            {
                petList.TakePetToDr();
            }
        }
        public void ShowPetInfoWithID()
        {
            int counter = 1;
            foreach (VirtualPet petList in myPetList)
            {
                petList.ViewPetInfoWithID(counter);
                counter++;
            }
        }

        public void InteractWithAllPets()
        {
            string menuChoice = ""; //creating a variable for users petChoice
            bool userPlaying = true;

            while (userPlaying)
            {
                Console.WriteLine("\nInteract With All Your Pets");
                Console.WriteLine("1. Feed All My Pets");
                Console.WriteLine("2. Play With All My Pets");
                Console.WriteLine("3. Take All My Pets To Doctor");
                Console.WriteLine("4. Exit");

                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        //Feed The Pets
                        FeedAllPets();
                        break;

                    case "2":
                        //Play With All Pets
                        PlayWithAllPets();
                        break;

                    case "3":
                        //Take All Pets to the Dr
                        TakeAllPetsToDoctor();
                        break;

                    case "4":
                        //Set isPlaying to False and will exit the program
                        userPlaying = false;
                        break;

                    default:
                        break;

                }

            }

        }
        public void InteractWith1Pet()
        {
            // list of all pets here with its corresponding index
            ShowPetInfoWithID();

            //user chooses pet(also contains the conversion syntax)
            Console.WriteLine("Please select a pet from the above list.");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            //look up users petchoice in list 
            //set new pet to pet choice within our list
            VirtualPet myPet = myPetList[userChoice-1];

            
            string menuChoice = "";
            bool userIsPlaying = true;
            //while loop starts here
            while (userIsPlaying)
            {
                Console.WriteLine("\nWhat Would You Like To Do With Your Pet?");
                Console.WriteLine("1. Feed Your Pet");
                Console.WriteLine("2. Play With Your Pet");
                Console.WriteLine("3. Take Your Pet To The Doctor");
                Console.WriteLine("4. Exit");
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        myPet.FeedPet();
                        break;

                    case "2":
                        myPet.PlayWithPet();
                        break;

                    case "3":
                        myPet.TakePetToDr();
                        break;

                    case "4":
                        userIsPlaying = false;
                        break;

                    default:
                        break;
                }
            
            }
        }

    }
}

