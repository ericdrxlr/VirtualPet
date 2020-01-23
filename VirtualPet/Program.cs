using System;

namespace VirtualPet
{
    class Program
    {

        static void Main(string[] args)
        {
            //Create Virtual Pet
            VirtualPet myCat = new VirtualPet();


            //create menu here
            //menu options here is to add pet to shelter
            string menuChoice = "";

            while (menuChoice != "9")
            {
                Console.WriteLine("Virtual Pet Menu");
                Console.WriteLine("1. Add a Pet to shelter");
                Console.WriteLine("2. Show My Pets Info");
                Console.WriteLine("3. Display Pets Status");
                Console.WriteLine("4. Feed Pet");
                Console.WriteLine("5. Take Pet to Doctor");
                Console.WriteLine("6. Play with Pet");
                Console.WriteLine("9. Exit");
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        myCat.AddPetToShelter();
                        myCat.SetPetName();
                        myCat.SetPetSpecies();
                        break;

                    case "2":
                        //Show Pet Name and Species
                        Console.WriteLine($"My pets name is {myCat.Name}. Its species is a {myCat.Species}.");
                        break;

                    case "3":
                        //Show Pets Health, Boredom, Hunger
                        Console.WriteLine($"My pets Health: {myCat.HealthLevel} Hunger: {myCat.Hunger} Boredom: {myCat.Boredom}");
                        break;

                    case "4":
                        //Feed The Pet

                        Console.WriteLine($"My Pets Hunger Status: {--myCat.Hunger}");
                        break;

                    case "5":
                        //Took Pet to Doctor

                        Console.WriteLine($"My Pets Health Status: {++myCat.HealthLevel}");
                        break;

                    case "6":
                        //Play with pet
                        //hunger lvl increases, boredom decreases, health increases
                        Console.WriteLine($"My Pets Bordom Status: {--myCat.Boredom} Hunger: {++myCat.Hunger} Health: {++myCat.HealthLevel}");

                        break;
                    default:
                        break;

                }


            }





            Console.ReadLine();


        }
    }
}


