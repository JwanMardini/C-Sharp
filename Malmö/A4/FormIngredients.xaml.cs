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
using System.Windows.Shapes;

namespace A4
{
    /// <summary>
    /// Interaction logic for FormIngredients.xaml
    /// </summary>
    public partial class FormIngredients : Window
    {
        private Recipe currRecipe;

        public FormIngredients(Recipe recipe)
        {
            InitializeComponent();
            currRecipe = recipe;
            UpdateIngredientList();
        
        }

        public Recipe GetRecipe()
        {
            return currRecipe;
        }


        /// <summary>
        /// Handles the click event of the "Add" button.
        /// </summary>
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string ingredient = ingredientTxt.Text.Trim();

            if (!string.IsNullOrEmpty(ingredient))
            {
                if (currRecipe.AddIngredient(ingredient))
                {
                    UpdateIngredientList();
                    ingredientTxt.Clear();
                }
                else
                {
                    MessageBox.Show("Unable to add ingredient. Check if the list is full or duplicated.");
                }
            }
            else
            {
                MessageBox.Show("Please enter an ingredient.");
            }
        }

        /// <summary>
        /// Updates the list of ingredients.
        /// </summary>
        private void UpdateIngredientList()
        {
            listBox.Items.Clear();
            foreach (var ingredient in currRecipe.Ingredients)
            {
                if (!string.IsNullOrEmpty(ingredient))
                {
                    listBox.Items.Add(ingredient);
                }
            }
            numOfIng.Content = currRecipe.Ingredients.ToString();
        }

        /// <summary>
        /// Handles the click event of the "Edit" button.
        /// </summary>
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            int index = listBox.SelectedIndex;
            if (index != -1)
            {
                string ingredient = currRecipe.GetIngredientsStringAt(index);
                ingredientTxt.Text = ingredient;
                currRecipe.DeletingIngredientAt(index);
                UpdateIngredientList();
            }
            else
            {
                MessageBox.Show("Please select an ingredient to edit.");
            }
        }

        /// <summary>
        /// Handles the click event of the "Delete" button.
        /// </summary>
        private void btnDel_Click_1(object sender, EventArgs e)
        {
            int index = listBox.SelectedIndex;
            if (index != -1)
            {
                currRecipe.DeletingIngredientAt(index);
                UpdateIngredientList();
            }
            else
            {
                MessageBox.Show("Please select an ingredient to delete.");
            }
        }

        /// <summary>
        /// Handles the click event of the "Ok" button.
        /// </summary>
        private void btnOk_Click_1(object sender, EventArgs e)
        {
            UpdateIngredientList();
            this.Close();
        }

        /// <summary>
        /// Handles the click event of the "Cancel" button.
        /// </summary>
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
