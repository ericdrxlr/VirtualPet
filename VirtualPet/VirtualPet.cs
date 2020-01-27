
using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class VirtualPet
    {
        // add properties here

        public string Name { get; set; }
        public string Species { get; set; }
        public int Hunger { get; set; } 
        public int Boredom { get; set; } 
        public int HealthLevel { get; set; } 


        // add constructors here
        public VirtualPet()
        {
            Hunger = 5;
            Boredom = 5;
            HealthLevel = 5;
        }

        public VirtualPet(string name, string species)
        {
            Name = name;
            Species = species;
            Hunger = 5;
            Boredom = 5;
            HealthLevel = 5;

        }
        // add methods here
        public void AddPetAndSpecies()
        {
            Console.WriteLine("What is the Pet's name?");
            string UsersPetsName = Console.ReadLine();
            Name = UsersPetsName;

            Console.WriteLine("What is your Pets Species?");
            string userPetsSpecies = Console.ReadLine();
            Species = userPetsSpecies;
        }

        public void ViewPetInfo()
        {
            Console.WriteLine($"My pets name is {Name}. Its species is a {Species}.");

        }

        public void PetStatus()
        {
            Console.WriteLine($"Name: {Name} | Health: {HealthLevel} | Hunger: {Hunger} | Boredom: {Boredom}");

        }

        public void FeedPet()
        {
            Console.WriteLine($"{Name}'s Hunger Status Decreased To {--Hunger}");

        }

        public void TakePetToDr()
        {
            Console.WriteLine($"My Pets Health Status: {++HealthLevel}");

        }

        public void PlayWithPet()
        {
            Console.WriteLine($"My Pets Bordom Status: {--Boredom} Hunger: {++Hunger} Health: {++HealthLevel}");

        }

        public void AddPetNameandSpeciesToList(List<VirtualPet> myPetList)
        {
            //access the list

            //create a new object of the list

            //add the current input pet.name and pet.species to list into the object

           // myPetList.Add(new VirtualPet() {Name = Name, Species = Species});


        }



    }
}



