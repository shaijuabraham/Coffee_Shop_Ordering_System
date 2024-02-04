﻿
namespace CoffeShop
{
    partial class frmEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.grbEmployeeView = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lisMenuView = new System.Windows.Forms.ListBox();
            this.prbImage = new System.Windows.Forms.PictureBox();
            this.cobCategory = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.grbAddItems = new System.Windows.Forms.GroupBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtImagurl = new System.Windows.Forms.TextBox();
            this.lblOurCost = new System.Windows.Forms.Label();
            this.txtOurCost = new System.Windows.Forms.TextBox();
            this.lblRetailPrice = new System.Windows.Forms.Label();
            this.txtRetailPrice = new System.Windows.Forms.TextBox();
            this.lblItemDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cobAddCategory = new System.Windows.Forms.ComboBox();
            this.btnViewMenu = new System.Windows.Forms.Button();
            this.grbEmployeeView.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prbImage)).BeginInit();
            this.grbAddItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEmployeeView
            // 
            this.grbEmployeeView.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.grbEmployeeView.Controls.Add(this.groupBox1);
            this.grbEmployeeView.Controls.Add(this.lisMenuView);
            this.grbEmployeeView.Controls.Add(this.prbImage);
            this.grbEmployeeView.Controls.Add(this.cobCategory);
            this.grbEmployeeView.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbEmployeeView.Location = new System.Drawing.Point(12, 56);
            this.grbEmployeeView.Name = "grbEmployeeView";
            this.grbEmployeeView.Size = new System.Drawing.Size(393, 265);
            this.grbEmployeeView.TabIndex = 0;
            this.grbEmployeeView.TabStop = false;
            this.grbEmployeeView.Text = "Employee View";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(6, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 73);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Description";
            // 
            // lblDescription
            // 
            this.lblDescription.AllowDrop = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 18);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(355, 52);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lisMenuView
            // 
            this.lisMenuView.FormattingEnabled = true;
            this.lisMenuView.Location = new System.Drawing.Point(6, 46);
            this.lisMenuView.Name = "lisMenuView";
            this.lisMenuView.Size = new System.Drawing.Size(225, 134);
            this.lisMenuView.TabIndex = 4;
            this.lisMenuView.SelectedIndexChanged += new System.EventHandler(this.lisMenuView_SelectedIndexChanged);
            // 
            // prbImage
            // 
            this.prbImage.Location = new System.Drawing.Point(237, 46);
            this.prbImage.Name = "prbImage";
            this.prbImage.Size = new System.Drawing.Size(145, 134);
            this.prbImage.TabIndex = 3;
            this.prbImage.TabStop = false;
            // 
            // cobCategory
            // 
            this.cobCategory.FormattingEnabled = true;
            this.cobCategory.Location = new System.Drawing.Point(6, 19);
            this.cobCategory.Name = "cobCategory";
            this.cobCategory.Size = new System.Drawing.Size(121, 21);
            this.cobCategory.TabIndex = 2;
            this.cobCategory.SelectedIndexChanged += new System.EventHandler(this.cobCategory_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Location = new System.Drawing.Point(6, 151);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 30);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(290, 151);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 30);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(128, 22);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(69, 17);
            this.lblItemName.TabIndex = 6;
            this.lblItemName.Text = "ItemName";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(203, 18);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(179, 23);
            this.txtItemName.TabIndex = 7;
            // 
            // grbAddItems
            // 
            this.grbAddItems.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.grbAddItems.Controls.Add(this.lblUrl);
            this.grbAddItems.Controls.Add(this.txtImagurl);
            this.grbAddItems.Controls.Add(this.lblOurCost);
            this.grbAddItems.Controls.Add(this.btnAdd);
            this.grbAddItems.Controls.Add(this.txtOurCost);
            this.grbAddItems.Controls.Add(this.btnBack);
            this.grbAddItems.Controls.Add(this.lblRetailPrice);
            this.grbAddItems.Controls.Add(this.txtRetailPrice);
            this.grbAddItems.Controls.Add(this.lblItemDescription);
            this.grbAddItems.Controls.Add(this.txtDescription);
            this.grbAddItems.Controls.Add(this.cobAddCategory);
            this.grbAddItems.Controls.Add(this.lblItemName);
            this.grbAddItems.Controls.Add(this.txtItemName);
            this.grbAddItems.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAddItems.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbAddItems.Location = new System.Drawing.Point(12, 327);
            this.grbAddItems.Name = "grbAddItems";
            this.grbAddItems.Size = new System.Drawing.Size(393, 187);
            this.grbAddItems.TabIndex = 6;
            this.grbAddItems.TabStop = false;
            this.grbAddItems.Text = "Add New Items";
            this.grbAddItems.Enter += new System.EventHandler(this.grbAddItems_Enter);
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(134, 125);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(66, 17);
            this.lblUrl.TabIndex = 15;
            this.lblUrl.Text = "Image Url";
            // 
            // txtImagurl
            // 
            this.txtImagurl.Location = new System.Drawing.Point(203, 122);
            this.txtImagurl.Name = "txtImagurl";
            this.txtImagurl.Size = new System.Drawing.Size(179, 23);
            this.txtImagurl.TabIndex = 16;
            // 
            // lblOurCost
            // 
            this.lblOurCost.AutoSize = true;
            this.lblOurCost.Location = new System.Drawing.Point(137, 96);
            this.lblOurCost.Name = "lblOurCost";
            this.lblOurCost.Size = new System.Drawing.Size(60, 17);
            this.lblOurCost.TabIndex = 13;
            this.lblOurCost.Text = "Our Cost";
            // 
            // txtOurCost
            // 
            this.txtOurCost.Location = new System.Drawing.Point(203, 96);
            this.txtOurCost.Name = "txtOurCost";
            this.txtOurCost.Size = new System.Drawing.Size(179, 23);
            this.txtOurCost.TabIndex = 14;
            // 
            // lblRetailPrice
            // 
            this.lblRetailPrice.AutoSize = true;
            this.lblRetailPrice.Location = new System.Drawing.Point(128, 70);
            this.lblRetailPrice.Name = "lblRetailPrice";
            this.lblRetailPrice.Size = new System.Drawing.Size(72, 17);
            this.lblRetailPrice.TabIndex = 11;
            this.lblRetailPrice.Text = "Retail Price";
            // 
            // txtRetailPrice
            // 
            this.txtRetailPrice.Location = new System.Drawing.Point(203, 70);
            this.txtRetailPrice.Name = "txtRetailPrice";
            this.txtRetailPrice.Size = new System.Drawing.Size(179, 23);
            this.txtRetailPrice.TabIndex = 12;
            // 
            // lblItemDescription
            // 
            this.lblItemDescription.AutoSize = true;
            this.lblItemDescription.Location = new System.Drawing.Point(123, 47);
            this.lblItemDescription.Name = "lblItemDescription";
            this.lblItemDescription.Size = new System.Drawing.Size(74, 17);
            this.lblItemDescription.TabIndex = 9;
            this.lblItemDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(203, 44);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(179, 23);
            this.txtDescription.TabIndex = 10;
            // 
            // cobAddCategory
            // 
            this.cobAddCategory.FormattingEnabled = true;
            this.cobAddCategory.Location = new System.Drawing.Point(6, 19);
            this.cobAddCategory.Name = "cobAddCategory";
            this.cobAddCategory.Size = new System.Drawing.Size(121, 25);
            this.cobAddCategory.TabIndex = 8;
            // 
            // btnViewMenu
            // 
            this.btnViewMenu.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnViewMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewMenu.Location = new System.Drawing.Point(51, 532);
            this.btnViewMenu.Name = "btnViewMenu";
            this.btnViewMenu.Size = new System.Drawing.Size(288, 44);
            this.btnViewMenu.TabIndex = 17;
            this.btnViewMenu.Text = "View Menu";
            this.btnViewMenu.UseVisualStyleBackColor = false;
            this.btnViewMenu.Click += new System.EventHandler(this.btnViewMenu_Click);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(416, 624);
            this.Controls.Add(this.btnViewMenu);
            this.Controls.Add(this.grbAddItems);
            this.Controls.Add(this.grbEmployeeView);
            this.Name = "frmEmployee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.grbEmployeeView.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prbImage)).EndInit();
            this.grbAddItems.ResumeLayout(false);
            this.grbAddItems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEmployeeView;
        private System.Windows.Forms.ListBox lisMenuView;
        private System.Windows.Forms.PictureBox prbImage;
        private System.Windows.Forms.ComboBox cobCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.GroupBox grbAddItems;
        private System.Windows.Forms.Label lblItemDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cobAddCategory;
        private System.Windows.Forms.Label lblOurCost;
        private System.Windows.Forms.TextBox txtOurCost;
        private System.Windows.Forms.Label lblRetailPrice;
        private System.Windows.Forms.TextBox txtRetailPrice;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtImagurl;
        private System.Windows.Forms.Button btnViewMenu;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}