using System;
using System.Collections.Generic;
using System.Linq;

namespace JurassicPark
{
    class Dinosaur
    {
        public string Name { get; set; } = "Unknown Dinosaur";
        public string DietType { get; set; } = "Unknown";
        public DateTime WhenAcquired { get; set; } = DateTime.Now;
        public double Weight { get; set; } = 0.0;
        public int EnclosureNumber { get; set; } = 00000;






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
            var ultimateUsersChoice = Console.ReadLine().ToUpper();
            Console.WriteLine();
            Console.WriteLine();


            while (ultimateUsersChoice != ("QUIT"))
            {


                if (ultimateUsersChoice == ("VIEW"))
                {
                    foreach (var dinosaur in allTheDinosaurs)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"{dinosaur.Name} is a {dinosaur.DietType} that weighs {dinosaur.Weight} pounds. {dinosaur.Name} has been with us since {dinosaur.WhenAcquired} and can be found in section #{dinosaur.EnclosureNumber}.");
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    Console.Write("🦖 MENU: VIEW, ADD, REMOVE, TRANSFER, SUMMARY, OR QUIT: ");
                    ultimateUsersChoice = Console.ReadLine().ToUpper();
                }



                if (ultimateUsersChoice == ("ADD"))
                {
                    Console.Write("Name: ");
                    var name = Console.ReadLine();

                    Console.Write("Diet: ");
                    var dietType = Console.ReadLine();

                    Console.Write("Arrival Date & Time: ");
                    var whenAcquired = DateTime.Parse(Console.ReadLine());

                    Console.Write("Weight in Pounds(#'s only): ");
                    var weight = Double.Parse(Console.ReadLine());

                    Console.Write("Section #: ");
                    var enclosureNumber = Int32.Parse(Console.ReadLine());


                    var dinosaur = new Dinosaur()
                    {
                        Name = name,
                        DietType = dietType,
                        WhenAcquired = whenAcquired,
                        Weight = weight,
                        EnclosureNumber = enclosureNumber,
                    };


                    allTheDinosaurs.Add(dinosaur);

                    Console.WriteLine($"You have added a {dietType} named {name}. {name} is {weight} pounds, is in section #{enclosureNumber} and arrived on {whenAcquired}.");


                    Console.Write("🦖 MENU: VIEW, ADD, REMOVE, TRANSFER, SUMMARY, OR QUIT: ");
                    ultimateUsersChoice = Console.ReadLine().ToUpper();
                }



                if (ultimateUsersChoice == ("REMOVE"))
                {
                    Console.Write("Which dinosaur are you deleting?  ");
                    var dinoBeingDeleted = Console.ReadLine();
                    var findDinoToDelete = allTheDinosaurs.Find(dinosaur => dinoBeingDeleted == dinosaur.Name);


                    allTheDinosaurs.Remove(findDinoToDelete);

                    Console.WriteLine($"{dinoBeingDeleted} has been removed from the system.");

                    Console.Write("🦖 MENU: VIEW, ADD, REMOVE, TRANSFER, SUMMARY, OR QUIT: ");
                    ultimateUsersChoice = Console.ReadLine().ToUpper();
                }



                if (ultimateUsersChoice == ("TRANSFER"))
                {
                    Console.Write("Which dinosaur do you want to transfer?  ");
                    var dinoBeingMoved = Console.ReadLine();
                    var findDinoToMove = allTheDinosaurs.Find(dinosaur => dinoBeingMoved == dinosaur.Name);

                    Console.Write($"{findDinoToMove.Name} is in {findDinoToMove.EnclosureNumber}. Which enclosure number to transfer to?  ");
                    var enclosureNumberTransferred = Int32.Parse(Console.ReadLine());

                    findDinoToMove.EnclosureNumber = enclosureNumberTransferred;

                    Console.WriteLine($"{findDinoToMove.Name} is now in {findDinoToMove.EnclosureNumber}.");

                    Console.Write("🦖 MENU: VIEW, ADD, REMOVE, TRANSFER, SUMMARY, OR QUIT: ");
                    ultimateUsersChoice = Console.ReadLine().ToUpper();
                }



                if (ultimateUsersChoice == ("SUMMARY"))
                {
                    var numberOfCarnivores = allTheDinosaurs.Count(dinosaur => dinosaur.DietType == "carnivore");
                    var numberOfHerbivores = allTheDinosaurs.Count(dinosaur => dinosaur.DietType == "herbivore");
                    var numberOfOmnivores = allTheDinosaurs.Count(dinosaur => dinosaur.DietType == "omnivore");

                    Console.WriteLine($"The total number of carnivores is {numberOfCarnivores}");
                    Console.WriteLine($"The total number of herbivores are {numberOfHerbivores}");
                    Console.WriteLine($"The total number of omnivores are {numberOfOmnivores}");

                    Console.Write("🦖 MENU: VIEW, ADD, REMOVE, TRANSFER, SUMMARY, OR QUIT: ");
                    ultimateUsersChoice = Console.ReadLine().ToUpper();

                }



            }


            if (ultimateUsersChoice == ("QUIT"))
            { Console.WriteLine("🦖 Have a DINO-mite day!! 🦕"); }

        }
    }
}
