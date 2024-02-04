using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClassLibrary
{
    public class Employee
    {
        public void PopulateMenuList(ListBox lisMenuView, string selectedCategory)
        {
            string[] items = File.ReadAllLines("menuItem.txt");
            foreach (string item in items)
            {
                string[] data = item.Split(',');
                string category = data[0];
                string shortDescription = data[1];
                decimal RetailPrice = decimal.Parse(data[3]);
                decimal Cost = decimal.Parse(data[4]);
                if (category == selectedCategory)
                {
                    lisMenuView.Items.Add($"{shortDescription} - Retail Price: {RetailPrice:C}, Cost: {Cost:C}");
                }
            }
        }

        public void PopulateMenuitemList(ListBox lisMenuView, string selectedCategory)
        {
            string[] items = File.ReadAllLines("menuItem.txt");
            foreach (string item in items)
            {
                string[] data = item.Split(',');
                string category = data[0];
                string shortDescription = data[1];
                decimal Cost = decimal.Parse(data[4]);
                if (category == selectedCategory)
                {
                    lisMenuView.Items.Add($"{shortDescription} - Cost: {Cost:C}");
                }
            }
        }



        public void UpdateDescriptionAndImage(string selectedString, ListBox listBox, Label descriptionLabel, PictureBox pictureBox)
        {
            selectedString = listBox.SelectedItem as string;

            if (selectedString != null)
            {
                // Split the selected string to separate short description
                string[] selectedParts = selectedString.Split('-');
                if (selectedParts.Length > 0)
                {
                    string selectedShortDescription = selectedParts[0].Trim();
                    string[] lines = File.ReadAllLines("menuItem.txt");

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        string shortDescription = parts[1];
                        string longDescription = parts[2];
                        string imageUrl = parts[5];

                        if (shortDescription == selectedShortDescription)
                        {
                            // Update the Label with the LongDescription
                            descriptionLabel.Text = longDescription;
                            // Update the PictureBox with the ImageUrl with error handling
                            try
                            {
                                pictureBox.Load(imageUrl);
                                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                            }
                            catch (Exception ex )
                            {
                                // Handle the error here, such as displaying an error message or using a default image
                                MessageBox.Show("Error loading image: Url Is Wrong ");
                                // You can also set a default image if the load fails                            
                            }
                            break;
                        }
                    }
                }
            }

        }
       
    }






}
