
namespace CoffeShop
{
    partial class frmCustomerOrder
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
            this.libOrderView = new System.Windows.Forms.ListBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblGmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblyourEmail = new System.Windows.Forms.Label();
            this.lblYourNumber = new System.Windows.Forms.Label();
            this.lblYourname = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblOrderTime = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // libOrderView
            // 
            this.libOrderView.FormattingEnabled = true;
            this.libOrderView.Location = new System.Drawing.Point(12, 80);
            this.libOrderView.Name = "libOrderView";
            this.libOrderView.Size = new System.Drawing.Size(215, 225);
            this.libOrderView.TabIndex = 0;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.BackColor = System.Drawing.Color.CadetBlue;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(49, 23);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(126, 39);
            this.lblOrder.TabIndex = 1;
            this.lblOrder.Text = "Receipt";
            // 
            // lblGmail
            // 
            this.lblGmail.AutoSize = true;
            this.lblGmail.Location = new System.Drawing.Point(12, 380);
            this.lblGmail.Name = "lblGmail";
            this.lblGmail.Size = new System.Drawing.Size(38, 13);
            this.lblGmail.TabIndex = 12;
            this.lblGmail.Text = "Email :";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(12, 354);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(84, 13);
            this.lblPhoneNumber.TabIndex = 11;
            this.lblPhoneNumber.Text = "Phone Number :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 328);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 13);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Customer Name :";
            // 
            // lblyourEmail
            // 
            this.lblyourEmail.AutoSize = true;
            this.lblyourEmail.Location = new System.Drawing.Point(106, 380);
            this.lblyourEmail.Name = "lblyourEmail";
            this.lblyourEmail.Size = new System.Drawing.Size(38, 13);
            this.lblyourEmail.TabIndex = 15;
            this.lblyourEmail.Text = "Email :";
            // 
            // lblYourNumber
            // 
            this.lblYourNumber.AutoSize = true;
            this.lblYourNumber.Location = new System.Drawing.Point(106, 354);
            this.lblYourNumber.Name = "lblYourNumber";
            this.lblYourNumber.Size = new System.Drawing.Size(84, 13);
            this.lblYourNumber.TabIndex = 14;
            this.lblYourNumber.Text = "Phone Number :";
            // 
            // lblYourname
            // 
            this.lblYourname.AutoSize = true;
            this.lblYourname.Location = new System.Drawing.Point(105, 328);
            this.lblYourname.Name = "lblYourname";
            this.lblYourname.Size = new System.Drawing.Size(88, 13);
            this.lblYourname.TabIndex = 13;
            this.lblYourname.Text = "Customer Name :";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(106, 465);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(38, 13);
            this.lblTax.TabIndex = 16;
            this.lblTax.Text = "Email :";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(106, 442);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(38, 13);
            this.lblAmount.TabIndex = 17;
            this.lblAmount.Text = "Email :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(106, 487);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(38, 13);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "Email :";
            // 
            // lblOrderTime
            // 
            this.lblOrderTime.AutoSize = true;
            this.lblOrderTime.Location = new System.Drawing.Point(12, 413);
            this.lblOrderTime.Name = "lblOrderTime";
            this.lblOrderTime.Size = new System.Drawing.Size(38, 13);
            this.lblOrderTime.TabIndex = 19;
            this.lblOrderTime.Text = "Email :";
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(12, 520);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(88, 36);
            this.btnMenu.TabIndex = 21;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // frmCustomerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(238, 568);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblOrderTime);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblyourEmail);
            this.Controls.Add(this.lblYourNumber);
            this.Controls.Add(this.lblYourname);
            this.Controls.Add(this.lblGmail);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.libOrderView);
            this.Name = "frmCustomerOrder";
            this.Text = "frmCustomerOrder";
            this.Load += new System.EventHandler(this.frmCustomerOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListBox libOrderView;
        internal System.Windows.Forms.Label lblOrder;
        internal System.Windows.Forms.Label lblGmail;
        internal System.Windows.Forms.Label lblPhoneNumber;
        internal System.Windows.Forms.Label lblName;
        internal System.Windows.Forms.Label lblyourEmail;
        internal System.Windows.Forms.Label lblYourNumber;
        internal System.Windows.Forms.Label lblYourname;
        internal System.Windows.Forms.Label lblTax;
        internal System.Windows.Forms.Label lblAmount;
        internal System.Windows.Forms.Label lblTotal;
        internal System.Windows.Forms.Label lblOrderTime;
        internal System.Windows.Forms.Button btnMenu;
    }
}