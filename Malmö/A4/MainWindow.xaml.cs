using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace A4
{
    public partial class MainWindow : Window
    {
        private const int MaxNumOfElements = 150;
        private const int MaxNumOfIngredients = 25;

        private RecipeManager recipeManager = new RecipeManager(MaxNumOfElements);
        private Recipe currRecipe = new Recipe(MaxNumOfIngredients);
        public MainWindow()
        {
            InitializeComponent();
            LoadCategoryList();

            categoryComboBox.SelectedIndex = 0;
            listRecipes.MouseDoubleClick += new MouseButtonEventHandler(listRecipes_MouseDoubleClick);


        }

        private void addIngerBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(recipeName.Text) || categoryComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter a name and select a category for the recipe.");
                return;
            }
            FormIngredients formIngredients = new FormIngredients(currRecipe);
            formIngredients.ShowDialog();

        }

        private void btnAddRec_Click(object sender, RoutedEventArgs e)
        {
            if (currRecipe.CurrentNumberOfIngredients() == 0)
            {
                MessageBox.Show("Please add ingredients to the recipe.");
                return;
            }

            currRecipe.Name = recipeName.Text;
            currRecipe.Category = (FoodCategory)categoryComboBox.SelectedItem;

            // Check if instructions are added
            if (string.IsNullOrEmpty(textInstructions.Text))
            {
                MessageBox.Show("Please add instructions to the recipe.");
                return;
            }

            currRecipe.Description = textInstructions.Text;

            bool addedSuccessfully = recipeManager.Add(currRecipe);

            if (addedSuccessfully)
            {
                UpdateGUI();
                currRecipe = new Recipe(MaxNumOfIngredients);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to add recipe. The recipe book is full or an error occurred.");
            }
        }

        private void btnEditBegin_Click(object sender, EventArgs e)
        {
            if (listRecipes.SelectedItem != null)
            {
                int index = listRecipes.SelectedIndex;
                currRecipe = recipeManager.GetRecipeAt(index);

                recipeName.Text = currRecipe.Name;
                categoryComboBox.SelectedItem = currRecipe.Category;
                textInstructions.Text = currRecipe.Description;
            }
            else
            {
                MessageBox.Show("Please select a recipe to edit.");
            }
        }

        private void btnEditFinish_Click(object sender, EventArgs e)
        {
            if (listRecipes.SelectedItem != null)
            {
                int index = listRecipes.SelectedIndex;

                currRecipe.Name = recipeName.Text;
                currRecipe.Category = (FoodCategory)categoryComboBox.SelectedItem;
                currRecipe.Description = textInstructions.Text;

                recipeManager.ChangeElement(index, currRecipe);

                UpdateGUI();
                ClearForm();
            }

        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (listRecipes.SelectedItem != null)
            {
                int index = listRecipes.SelectedIndex;
                recipeManager.DeleteElement(index);
                UpdateGUI();
            }
            else
            {
                MessageBox.Show("Please select a recipe to delete.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void listRecipes_MouseDoubleClick(object sender, EventArgs e)
        {
            ViewSelectedRecipeDetails();
        }

        /// <summary>
        /// Displays the details of the selected recipe.
        /// </summary>
        private void ViewSelectedRecipeDetails()
        {
            int selectedIndex = listRecipes.SelectedIndex;
            if (selectedIndex != -1)
            {
                Recipe selectedRecipe = recipeManager.GetRecipeAt(selectedIndex);

                string ingredients = selectedRecipe.GetIngredientsString();
                string instructions = selectedRecipe.Description;

                MessageBox.Show($"INGREDIENTS:\n {ingredients}\n\n {instructions}", "Cooking Instructions:");
            }
            else
            {
                MessageBox.Show("Please select a recipe to view its details.", "Selection Required");
            }
        }


        private void UpdateGUI()
        {
            listRecipes.Items.Clear();

            foreach (string recipeSummary in recipeManager.RecipeListToString())
            {
                listRecipes.Items.Add(recipeSummary);
            }
        }

        private void ClearForm()
        {
            recipeName.Clear();
            textInstructions.Text = "";
            categoryComboBox.SelectedIndex = -1;
            listRecipes.SelectedIndex = -1;
        }

        private void LoadCategoryList()
        {
            foreach (FoodCategory category in Enum.GetValues(typeof(FoodCategory)))
            {
                categoryComboBox.Items.Add(category);
            }
        }
    }
}
