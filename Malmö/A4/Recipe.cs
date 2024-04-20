using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace A4
{
    public class Recipe
    {
        private FoodCategory category;
        private string description;
        private string[] ingredients;
        private string name;
        private int maxNumIngredients;


        public Recipe(int maxNumIngredients)
        {
            this.maxNumIngredients = maxNumIngredients;
            DefaultValues();
        }

        // properties

        public FoodCategory Category
        {
            get { return category; }
            set { category = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string[] Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int MaxNumIngredients
        {
            get { return maxNumIngredients; }
        }

        // methods

        public bool AddIngredient(string input)
        {
            int index = FindVacantPosition();
            if (index != -1)
            {
                ingredients[index] = input;
                return true;
            }
            return false;
        }

        public bool ChangeIngredientAt(int index, string value)
        {
            if (CheckIndex(index))
            {
                ingredients[index] = value;
                return true;
            }
            return false;
        }

        private bool CheckIndex(int index)
        {
            return index >= 0 && index < ingredients.Length;
        }
        
        public int CurrentNumberOfIngredients()
        {
            int count = 0;
            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i] != null)
                {
                    count++;
                }
            }
            return count;
        }

        public void DefaultValues()
        {
            category = FoodCategory.Other;
            description = "";
            ingredients = new string[maxNumIngredients];
            name = "";
        }

        public void DeletingIngredientAt(int index)
        {
            if (CheckIndex(index))
            {
                ingredients[index] = null;
            }
        }

        private int FindVacantPosition()
        {
            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i] == null)
                {
                    return i;
                }
            }
            return -1;
        }

        public string GetIngredientsString()
        {
            string result = "";
            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i] != null)
                {
                    result += ingredients[i] + "\n";
                }
            }
            return result;

        }

        public string GetIngredientsStringAt(int index)
        {
            if (CheckIndex(index))
            {
                return ingredients[index];
            }
            return null;
        }
        // toString
        public override string ToString()
        {
            return "Name: " + name + "\n" +
                   "Category: " + category + "\n" +
                   "Description: " + description + "\n" +
                   "Ingredients: " + GetIngredientsString();
        }
    }
}
