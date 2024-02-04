using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MyClassLibrary;


namespace CoffeShop
{
    public partial class frmEmployee : Form
    {
        Employee employee = new Employee();
        public frmEmployee()
        {
            InitializeComponent();
            
            
        }
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            string filename = "menuItem.txt";
            // Check if the file "nameItem.txt" exists
            if (File.Exists(filename))
            {
                // Read the content of the file
                string fileContent = File.ReadAllText(filename);

                // Check if the content is empty or contains only whitespace
                if (string.IsNullOrWhiteSpace(fileContent))
                {
                    // The file is empty, create menu items and save them to the file
                    List<MyClassLibrary.MenuItem> menuItems = MyClassLibrary.MenuItem.GetMenuItems();
                    MyClassLibrary.MenuItem.SaveMenuItemsToFile(menuItems);

                    // Load categories into the ComboBox using a foreach loop
                    foreach (var item in Enum.GetValues(typeof(MyClassLibrary.MenuItem.MenuCategory)))
                    {
                        cobCategory.Items.Add(item);
                        cobAddCategory.Items.Add(item);
                    }
                }
                else
                {
                    // Load categories into the ComboBox using a foreach loop
                    foreach (var item in Enum.GetValues(typeof(MyClassLibrary.MenuItem.MenuCategory)))
                    {
                        cobCategory.Items.Add(item);
                        cobAddCategory.Items.Add(item);
                    }
                }
            }
       
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain frmmain = new frmMain();
            this.Hide();
            frmmain.Show();
        }

        private void cobCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cobCategory.SelectedItem.ToString(); // Use cobAddCategory

            // Clear the ListBox before populating with new items
            lisMenuView.Items.Clear();

            employee.PopulateMenuList(lisMenuView, selectedCategory);

        }

        private void lisMenuView_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedString = lisMenuView.SelectedItem.ToString();


            employee.UpdateDescriptionAndImage(selectedString, lisMenuView, lblDescription, prbImage);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // IsNullOrWhiteSpace It checks if a string is null, empty, or contains only white-space characters.
            if (string.IsNullOrWhiteSpace(cobAddCategory.SelectedItem?.ToString()) ||
                   string.IsNullOrWhiteSpace(txtItemName.Text) ||
                   string.IsNullOrWhiteSpace(txtDescription.Text) ||
                   string.IsNullOrWhiteSpace(txtRetailPrice.Text) ||
                   string.IsNullOrWhiteSpace(txtOurCost.Text) ||
                   string.IsNullOrWhiteSpace(txtImagurl.Text))
            {
                MessageBox.Show("Please fill all the requested fields.");
            }

            else
            {
                string category = cobAddCategory.SelectedItem.ToString();
                string shortDescription = txtItemName.Text;
                string longDescription = txtDescription.Text;
                decimal retailPrice = decimal.Parse(txtRetailPrice.Text);
                decimal cost = decimal.Parse(txtOurCost.Text);
                string imageUrl = txtImagurl.Text;

                // Create a new menu item
                MyClassLibrary.MenuItem newItem = new MyClassLibrary.MenuItem(
                    (MyClassLibrary.MenuItem.MenuCategory)Enum.Parse(typeof(MyClassLibrary.MenuItem.MenuCategory), category),
                    shortDescription, longDescription, retailPrice, cost, imageUrl);
                // Load the existing menu items
                List<MyClassLibrary.MenuItem> menuItems = MyClassLibrary.MenuItem.GetMenuItems();
                // Add the new item to the list
                menuItems.Add(newItem);
                // Save the updated list to the file
                MyClassLibrary.MenuItem.SaveMenuItemsToFile(menuItems);

                // Oclear the text boxes
                txtItemName.Clear();
                txtDescription.Clear();
                txtRetailPrice.Clear();
                txtOurCost.Clear();
                txtImagurl.Clear();

                lisMenuView.Items.Add($"{newItem.ShortDescription} - Retail Price: {newItem.RetailPrice:C}, Cost: {newItem.Cost:C}");

                MessageBox.Show("New item has been added.");
            }
        }

        private void grbAddItems_Enter(object sender, EventArgs e)
        {

        }

        private void btnViewMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frm = new frmMenu();
            frm.Show();
        }
    }
}
