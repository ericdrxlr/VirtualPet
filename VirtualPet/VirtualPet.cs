
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

    }
}



