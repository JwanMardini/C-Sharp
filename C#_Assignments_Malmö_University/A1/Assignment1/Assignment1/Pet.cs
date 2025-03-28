using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Pet
    {
        private string name; // Stores the name of the pet
        private int age; // Stores the age of the pet
        private bool isFemale; // Stores whether the pet is female or not
        private string pronouns; // Stores the pronouns based on the gender of the pet

        // Method to read and save pet data entered by the user
        public void ReadAndSavePetData()
        {
            Console.Write("What is the name of your pet? ");
            this.name = Console.ReadLine();

            Console.Write($"What is {this.name} age? ");
            string ageInput = Console.ReadLine();
            this.age = int.Parse(ageInput);

            Console.Write("Is your pet a female (y/n)? ");
            string genderInput = Console.ReadLine();
            if (genderInput == "y")
            {
                this.isFemale = true;
                this.pronouns = "She";
            }
            else
            {
                this.isFemale = false;
                this.pronouns = "He";
            }
        }

        // Method to display all pet information
        public void DisplayAllPetInfo()
        {
            Console.WriteLine("++++++++++++++++++++++++++++");
            Console.WriteLine($"Name: {this.name} Age: {this.age}");
            Console.WriteLine($"{this.name}: {this.pronouns}'s such a wonderful pup!");
            Console.WriteLine("++++++++++++++++++++++++++++");
        }

        // Method to start interaction with the Pet class
        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("Greetings from the pet class");
            Console.WriteLine();

            ReadAndSavePetData(); // Read and save pet data
            DisplayAllPetInfo(); // Display all pet information
            Console.WriteLine();
        }
    }
}
