
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
        public int Hunger { get; set; } = 5;
        public int Boredom { get; set; } = 5;
        public int HealthLevel { get; set; } = 5;


        // add constructors here
        public VirtualPet()
        {

        }

        public VirtualPet(string name, int hunger, string species)
        {
            Name = name;
            Hunger = hunger;
            Species = species;

        }
        // add methods here
        public void SetPetName()
        {
            Console.WriteLine("What is the Pet's name?");
            string UsersPetsName = Console.ReadLine();
            Name = UsersPetsName;
        }

        public void SetPetSpecies()
        {
            Console.WriteLine("What is your Pets Species?");
            string userPetsSpecies = Console.ReadLine();
            Species = userPetsSpecies;
        }

        public void AddPetToShelter()
        {
            Console.WriteLine("Your Pet is in the Shelter.");
        }

        public void ViewPetInfo()
        {
            Console.WriteLine($"My pets name is {Name}. Its species is a {Species}.");

        }

        public void PetStatus()
        {
            Console.WriteLine($"My pets Health: {HealthLevel} Hunger: {Hunger} Boredom: {Boredom}");

        }

        public void FeedPet()
        {
            Console.WriteLine($"My Pets Hunger Status: {--Hunger}");

        }

        public void TakePetToDr()
        {
            Console.WriteLine($"My Pets Health Status: {++HealthLevel}");

        }

        public void PlayWithPet()
        {
            Console.WriteLine($"My Pets Bordom Status: {--Boredom} Hunger: {++Hunger} Health: {++HealthLevel}");

        }

        public void AddPetNameandSpeciesToList()
        {

        }



    }
}



