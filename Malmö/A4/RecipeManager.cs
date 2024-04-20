using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace A4
{
    internal class RecipeManager
    {
        private Recipe[] recipeList;
        private int numOfElems=0;


        public RecipeManager(int maxNumRecipes)
        {
            recipeList = new Recipe[maxNumRecipes];
        }

        // methods

        
        public bool Add(Recipe recipe)
        {
            int index = FindVacantPosition();
            if (index != -1)
            {
                recipeList[index] = recipe;
                numOfElems++;
                return true;
            }
            return false;
        }       

        public bool Add(string name, string description, FoodCategory category, string[] ingredients)
        {
            Recipe recipe = new Recipe(ingredients.Length);
            recipe.Name = name;
            recipe.Description = description;
            recipe.Category = category;
            recipe.Ingredients = ingredients;
            return Add(recipe);
        }
        public void ChangeElement(int index, Recipe recipe)
        {
            if (CheckIndex(index))
            {
                recipeList[index] = recipe;
            }
        }
        private bool CheckIndex(int index)
        {
            if (index >= 0 && index < recipeList.Length)
            {
                return true;
            }
            return false;
        }

        public void DeleteElement(int index)
        {
            if (CheckIndex(index))
            {
                recipeList[index] = null;
                numOfElems--;
                MoveElementsOneStepToLeft(index);
            }
        }
        private int FindVacantPosition()
        {
            for (int i = 0; i < recipeList.Length; i++)
            {
                if (recipeList[i] == null)
                {
                    return i;
                }
            }
            return -1;
        }

        public int GetCurrentNumberOfRecipes()
        {
            int count = 0;
            for (int i = 0; i < recipeList.Length; i++)
            {
                if (recipeList[i] != null)
                {
                    count++;
                }
            }
            return count;
        }

        public Recipe GetRecipeAt(int index)
        {
            if (CheckIndex(index))
            {
                return recipeList[index];
            }
            return null;
        }

        private void MoveElementsOneStepToLeft(int index)
        {
            for (int i = index; i < recipeList.Length - 2; i++)
            {
                recipeList[i] = recipeList[i + 1]; //move 1 step to left
            }
            recipeList[recipeList.Length - 1] = null; //empty last place
        }


        // RecipeListsToString
        public string[] RecipeListToString()
        {
            string[] recipeStrings = new string[GetCurrentNumberOfRecipes()];
            int counter = 0;
            foreach (var recipe in recipeList)
            {
                if (recipe != null)
                {
                    recipeStrings[counter++] = recipe.ToString();
                }
            }
            return recipeStrings;
        }


    }
    }