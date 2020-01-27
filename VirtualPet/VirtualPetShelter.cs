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

        public void ShowAllPets()
        {
            foreach (VirtualPet petList in myPetList)
            {
                petList.ViewPetInfo();
            }
                    
        }
       


    }
}
