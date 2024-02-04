
namespace CoffeShop
{
    partial class frmMain
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
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(39, 328);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(109, 47);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(170, 330);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(109, 47);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::CoffeShop.Properties.Resources.mr1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(302, 389);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnMenu);
            this.Name = "frmMain";
            this.Text = "Mr. Coffe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnEmployee;
    }
}

