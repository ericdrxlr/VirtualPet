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

        public void InteractWithAllPets()
        {
            string menuChoice = ""; //creating a variable for users petChoice
            bool userPlaying = true;

            while (userPlaying)
            {
                Console.WriteLine("Interact With All Your Pets");
                Console.WriteLine("\n1. Feed All My Pets");
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
           string menuChoice = "";
            bool userIsPlaying = true;

            Console.WriteLine();
           // list of all pets here with its corresponding index
           
            //user chooses pet(also contains the conversion syntax)

            //look up users petchoice in list 

            //set new pet to pet choice within our list

            //while loop starts here

            //prompt user with menu choice

            //switch
            
            }

        }

    }
}
