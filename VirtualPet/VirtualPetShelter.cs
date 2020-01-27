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
            myPetList.Add(myCat);
        }

        public void ShowPetList()
        {
           
            for (int i = 0; i < myPetList.Count; i++)
            {
                Console.WriteLine(myPetList.[i]);
            }
         

           
            /*
            foreach (VirtualPet petList in myPetList)
            {
                Console.WriteLine(petList);
            }
            */
           
        }
       


    }
}
