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
            //myPetList.Add(myCat);
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


    }
}
