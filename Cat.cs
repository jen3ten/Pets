﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetTeam
{
    class Cat
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Hunger { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }

        public Cat(string name, string species)
        {
            Name = name;
            Species = species;
            Hunger = 10;
            Boredom = 10;
            Health = 10;
        }

        public void PetInfo()
        {
            Console.WriteLine("I'm " + Name + "! My species is " + Species + ".");
        }

        public void PetStatus()
        {
            Console.WriteLine(Name + "'s status is :");
            Console.WriteLine("Hunger: " + Hunger + "/20");
            Console.WriteLine("Bordeom: " + Boredom + "/20");
            Console.WriteLine("Health: " + Health + "/20");
        }

        public void Feed()
        {
            Hunger += 2;
            Console.WriteLine("You have fed " + Name);
        }

        public void Play()
        {
            Boredom += 3;
            Hunger -= 1;
            Health -= 1;
            Console.WriteLine("You have played with " + Name);
        }

        public void GoToDoctor()
        {
            Health += 1;
            Console.WriteLine("You have took " + Name + " to the vet!");
        }

        public void Interact()
        {
            bool interacting = true;
            string interact = "";
            do
            {
                Console.WriteLine("You are interacting with " + Name + ". Press any key to continue.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Interact Menu");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(" 1 = Feed:\n 2 = Play:\n 3 = Take your pet to the Vet:\n 4 = Quit Interacting");
                Console.ForegroundColor = ConsoleColor.White;
                interact = Console.ReadLine();
                switch (interact)
                {
                    case "1":
                        Feed();
                        break;
                    case "2":
                        Play();
                        break;
                    case "3":
                        GoToDoctor();
                        break;
                    case "4":
                        {
                            interacting = false;
                        }
                        while (interacting) ;
                        break;
                }
            }

            while (interacting);
        }

        public void AddPet()
        {
            Console.WriteLine("What would you like to name your pet?");
            Name = Console.ReadLine();
            Console.WriteLine("What would you like its species to be?");
            Species = Console.ReadLine();
        }
    }
}