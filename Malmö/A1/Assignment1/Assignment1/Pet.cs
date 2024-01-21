using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Pet
    {
        private string name;
        private int age;
        private bool isFemale;
        private string pronouns;

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
            else{
                this.isFemale = false;
                this.pronouns = "He";
            }


        }

        public void DisplayAllPetInfo()
        {
            Console.WriteLine("++++++++++++++++++++++++++++");
            Console.WriteLine($"Name: {this.name} Age: {this.age}");
            Console.WriteLine($"{this.name}: {this.pronouns}'s such a wonderful pup!");
            Console.WriteLine("++++++++++++++++++++++++++++");

        }

        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("Greetings from the pet class");
            Console.WriteLine();

            ReadAndSavePetData();
            DisplayAllPetInfo();
            Console.WriteLine();
        }





    }
}
