﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MyClassLibrary;

namespace CoffeShop
{
    public partial class frmMenu : Form
    {
        frmCustomerOrder frmCustomer = new frmCustomerOrder();
        Employee employee = new Employee();
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
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
                    }
                }
                else
                {
                    // Load categories into the ComboBox using a foreach loop
                    foreach (var item in Enum.GetValues(typeof(MyClassLibrary.MenuItem.MenuCategory)))
                    {
                        cobCategory.Items.Add(item);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frmMain = new frmMain();
            frmMain.Show();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmCustomer.Show();

            Order order = new Order {
                CustomerName = txtName.Text,
                Email = txtEmail.Text,
                PhoneNumber = double.Parse(txtPhoneNumber.Text)
            };

            frmCustomer.lblYourname.Text = order.CustomerName;
            frmCustomer.lblYourNumber.Text = order.PhoneNumber.ToString();
            frmCustomer.lblyourEmail.Text = order.Email;

            // Iterate through the selected items in lisMenuView
            foreach (var selectedItem in lisMenuView.SelectedItems)
            {
                // Add each selected item to libOrderView
                frmCustomer.libOrderView.Items.Add(selectedItem.ToString());

            }

            decimal totalWithoutTax = 0;
            decimal totalTax = 0;

            // Iterate through the selected items in lisMenuView
            foreach (var selectedItem in lisMenuView.SelectedItems)
            {
                string itemText = selectedItem.ToString();
                string[] parts = itemText.Split('$');
                if (parts.Length == 2)
                {
                    string itemDescription = parts[0].Trim();
                    string priceText = parts[1].Trim();

                    if (decimal.TryParse(priceText, out decimal itemPrice))
                    {
                        // Calculate the price with tax (e.g., 8% tax)
                        decimal priceWithTax = itemPrice * 1.08m;

                        // Update the total amount without tax and total tax
                        totalWithoutTax += itemPrice;
                        totalTax += priceWithTax - itemPrice;
                    }
                }
                // Calculate the grand total
                decimal grandTotal = totalWithoutTax + totalTax;

                frmCustomer.lblOrderTime.Text = "Order Time : " 
                                +  DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                // Display the totals in respective labels
                frmCustomer.lblAmount.Text = $"Order Value: {totalWithoutTax:C}";
                frmCustomer.lblTax.Text = $"Total Tax: {totalTax:C}";
                frmCustomer.lblTotal.Text = $"  Total: {grandTotal:C}";
            }
        }

        private void cobCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cobCategory.SelectedItem.ToString(); // Use cobAddCategory

            // Clear the ListBox before populating with new items
            lisMenuView.Items.Clear();

            employee.PopulateMenuitemList(lisMenuView, selectedCategory);
        }

        private void lisMenuView_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedString = lisMenuView.SelectedItem.ToString();

            employee.UpdateDescriptionAndImage(selectedString, lisMenuView, lblDescription, prbImage);

        }
    }

}
