using System;
using System.Collections.Generic;

namespace JurassicPark
{
    class Dinosaur
    {
        public string Name { get; set; } = "Unknown Dinosaur";
        public string DietType { get; set; } = "Unknown";
        public DateTime WhenAcquired { get; set; }
        public double Weight { get; set; } = 0.0;
        public int EnclosureNumber { get; set; }






    }

    class Program
    {
        static void Main(string[] args)
        {
            var allTheDinosaurs = new List<Dinosaur>()
            { new Dinosaur {
              Name = "Blue",
              DietType = "carnivore",
              WhenAcquired = DateTime.Now,
              Weight = 88.2,
              EnclosureNumber = 99834,
            },

            new Dinosaur {
              Name = "Charlie",
              DietType = "carnivore",
              WhenAcquired = DateTime.Now,
              Weight = 93.7,
              EnclosureNumber = 99834,
            },

            new Dinosaur {
              Name = "Littlefoot",
              DietType = "herbivore",
              WhenAcquired = DateTime.Now,
              Weight = 36782.5,
              EnclosureNumber = 79003,
            },

            };




            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Welcome to Jurassic Park 🦖");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Console.Write("🦖 MENU: VIEW, ADD, REMOVE, TRANSFER, SUMMARY, OR QUIT: ");
            var usersChoice = Console.ReadLine();
            var ultimateUsersChoice = usersChoice.ToUpper();
            Console.WriteLine();
            Console.WriteLine();


            if (ultimateUsersChoice == ("QUIT"))
            { Console.WriteLine("🦖 Have a DINO-mite day!! 🦕"); }

            if (ultimateUsersChoice == ("VIEW"))
            {
                foreach (var dinosaur in allTheDinosaurs)
                {
                    Console.WriteLine($"{dinosaur.Name} is a {dinosaur.DietType} that weighs {dinosaur.Weight} pounds. {dinosaur.Name} has been with us since {dinosaur.WhenAcquired} and can be found in section #{dinosaur.EnclosureNumber}.");
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }

            if (ultimateUsersChoice == ("ADD"))
            {
                Console.Write("Name: ");
                var name = Console.ReadLine();

                Console.Write("Diet: ");
                var dietType = Console.ReadLine();

                Console.Write("Arrival Date & Time: ");
                var whenAcquired = Console.ReadLine();

                Console.Write("Weight in Pounds(#'s only): ");
                var weight = Console.ReadLine();

                Console.Write("Section #: ");
                var enclosureNumber = Console.ReadLine();

                Console.WriteLine($"You have added a {dietType} named {name}. {name} is {weight} pounds and is in section #{enclosureNumber} and arrived on {whenAcquired}.");

            }







        }
    }
}
