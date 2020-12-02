
namespace FinalProjectVersion2
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.First_Name_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Name_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCustomerBanner = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAddCustomers = new System.Windows.Forms.Button();
            this.btnEditCustomers = new System.Windows.Forms.Button();
            this.btnDeleteCustomers = new System.Windows.Forms.Button();
            this.btnBackToAdd = new System.Windows.Forms.Button();
            this.btnShowProducts = new System.Windows.Forms.Button();
            this.btnShowCustomers = new System.Windows.Forms.Button();
            this.btnShowCategories = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.Black;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.First_Name_Column,
            this.Last_Name_Column,
            this.Telephone_Column,
            this.Address_Column,
            this.Email_Column});
            this.dgvCustomers.Location = new System.Drawing.Point(419, 156);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.Size = new System.Drawing.Size(568, 258);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            // 
            // First_Name_Column
            // 
            this.First_Name_Column.HeaderText = "First_Name";
            this.First_Name_Column.Name = "First_Name_Column";
            this.First_Name_Column.ReadOnly = true;
            // 
            // Last_Name_Column
            // 
            this.Last_Name_Column.HeaderText = "Last_Name";
            this.Last_Name_Column.Name = "Last_Name_Column";
            this.Last_Name_Column.ReadOnly = true;
            // 
            // Telephone_Column
            // 
            this.Telephone_Column.HeaderText = "Telephone";
            this.Telephone_Column.Name = "Telephone_Column";
            this.Telephone_Column.ReadOnly = true;
            // 
            // Address_Column
            // 
            this.Address_Column.HeaderText = "Address";
            this.Address_Column.Name = "Address_Column";
            this.Address_Column.ReadOnly = true;
            // 
            // Email_Column
            // 
            this.Email_Column.HeaderText = "Email";
            this.Email_Column.Name = "Email_Column";
            this.Email_Column.ReadOnly = true;
            // 
            // lblCustomerBanner
            // 
            this.lblCustomerBanner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerBanner.BackColor = System.Drawing.Color.Gray;
            this.lblCustomerBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerBanner.ForeColor = System.Drawing.Color.LightGreen;
            this.lblCustomerBanner.Location = new System.Drawing.Point(0, 0);
            this.lblCustomerBanner.Name = "lblCustomerBanner";
            this.lblCustomerBanner.Size = new System.Drawing.Size(999, 114);
            this.lblCustomerBanner.TabIndex = 1;
            this.lblCustomerBanner.Text = "Customer Information";
            this.lblCustomerBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.Color.Pink;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(40, 156);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(100, 23);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.Color.Orchid;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(40, 203);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 23);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTelephone
            // 
            this.lblTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(40, 250);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(182, 23);
            this.lblTelephone.TabIndex = 4;
            this.lblTelephone.Text = "Telephone (No dashes):";
            this.lblTelephone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.MediumPurple;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(40, 298);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 23);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address:";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(40, 343);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(241, 252);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(109, 20);
            this.txtTelephone.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(241, 203);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(109, 20);
            this.txtLastName.TabIndex = 8;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(241, 159);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(109, 20);
            this.txtFirstName.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(241, 301);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(109, 20);
            this.txtAddress.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(241, 346);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(109, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // btnAddCustomers
            // 
            this.btnAddCustomers.BackColor = System.Drawing.Color.Black;
            this.btnAddCustomers.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomers.Location = new System.Drawing.Point(44, 391);
            this.btnAddCustomers.Name = "btnAddCustomers";
            this.btnAddCustomers.Size = new System.Drawing.Size(75, 23);
            this.btnAddCustomers.TabIndex = 12;
            this.btnAddCustomers.Text = "Add";
            this.btnAddCustomers.UseVisualStyleBackColor = false;
            this.btnAddCustomers.Click += new System.EventHandler(this.btnAddCustomers_Click);
            // 
            // btnEditCustomers
            // 
            this.btnEditCustomers.BackColor = System.Drawing.Color.Black;
            this.btnEditCustomers.ForeColor = System.Drawing.Color.White;
            this.btnEditCustomers.Location = new System.Drawing.Point(161, 391);
            this.btnEditCustomers.Name = "btnEditCustomers";
            this.btnEditCustomers.Size = new System.Drawing.Size(75, 23);
            this.btnEditCustomers.TabIndex = 13;
            this.btnEditCustomers.Text = "Edit/Update";
            this.btnEditCustomers.UseVisualStyleBackColor = false;
            this.btnEditCustomers.Click += new System.EventHandler(this.btnEditCustomers_Click);
            // 
            // btnDeleteCustomers
            // 
            this.btnDeleteCustomers.BackColor = System.Drawing.Color.Black;
            this.btnDeleteCustomers.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCustomers.Location = new System.Drawing.Point(275, 390);
            this.btnDeleteCustomers.Name = "btnDeleteCustomers";
            this.btnDeleteCustomers.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCustomers.TabIndex = 14;
            this.btnDeleteCustomers.Text = "Delete";
            this.btnDeleteCustomers.UseVisualStyleBackColor = false;
            this.btnDeleteCustomers.Click += new System.EventHandler(this.btnDeleteCustomers_Click);
            // 
            // btnBackToAdd
            // 
            this.btnBackToAdd.BackColor = System.Drawing.Color.Black;
            this.btnBackToAdd.ForeColor = System.Drawing.Color.White;
            this.btnBackToAdd.Location = new System.Drawing.Point(44, 432);
            this.btnBackToAdd.Name = "btnBackToAdd";
            this.btnBackToAdd.Size = new System.Drawing.Size(75, 23);
            this.btnBackToAdd.TabIndex = 15;
            this.btnBackToAdd.Text = "Back to Add";
            this.btnBackToAdd.UseVisualStyleBackColor = false;
            this.btnBackToAdd.Click += new System.EventHandler(this.btnBackToAdd_Click);
            // 
            // btnShowProducts
            // 
            this.btnShowProducts.BackColor = System.Drawing.Color.Black;
            this.btnShowProducts.ForeColor = System.Drawing.Color.White;
            this.btnShowProducts.Location = new System.Drawing.Point(324, 91);
            this.btnShowProducts.Name = "btnShowProducts";
            this.btnShowProducts.Size = new System.Drawing.Size(109, 23);
            this.btnShowProducts.TabIndex = 16;
            this.btnShowProducts.Text = "Products";
            this.btnShowProducts.UseVisualStyleBackColor = false;
            this.btnShowProducts.Click += new System.EventHandler(this.btnShowProducts_Click);
            // 
            // btnShowCustomers
            // 
            this.btnShowCustomers.BackColor = System.Drawing.Color.Black;
            this.btnShowCustomers.ForeColor = System.Drawing.Color.White;
            this.btnShowCustomers.Location = new System.Drawing.Point(434, 91);
            this.btnShowCustomers.Name = "btnShowCustomers";
            this.btnShowCustomers.Size = new System.Drawing.Size(109, 23);
            this.btnShowCustomers.TabIndex = 17;
            this.btnShowCustomers.Text = "Customers";
            this.btnShowCustomers.UseVisualStyleBackColor = false;
            // 
            // btnShowCategories
            // 
            this.btnShowCategories.BackColor = System.Drawing.Color.Black;
            this.btnShowCategories.ForeColor = System.Drawing.Color.White;
            this.btnShowCategories.Location = new System.Drawing.Point(544, 91);
            this.btnShowCategories.Name = "btnShowCategories";
            this.btnShowCategories.Size = new System.Drawing.Size(109, 23);
            this.btnShowCategories.TabIndex = 18;
            this.btnShowCategories.Text = "Categories";
            this.btnShowCategories.UseVisualStyleBackColor = false;
            this.btnShowCategories.Click += new System.EventHandler(this.btnShowCategories_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(999, 467);
            this.Controls.Add(this.btnShowProducts);
            this.Controls.Add(this.btnShowCategories);
            this.Controls.Add(this.btnShowCustomers);
            this.Controls.Add(this.btnBackToAdd);
            this.Controls.Add(this.btnDeleteCustomers);
            this.Controls.Add(this.btnEditCustomers);
            this.Controls.Add(this.btnAddCustomers);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblCustomerBanner);
            this.Controls.Add(this.dgvCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Information";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn First_Name_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Name_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_Column;
        public System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Label lblCustomerBanner;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAddCustomers;
        private System.Windows.Forms.Button btnEditCustomers;
        private System.Windows.Forms.Button btnDeleteCustomers;
        private System.Windows.Forms.Button btnBackToAdd;
        private System.Windows.Forms.Button btnShowProducts;
        private System.Windows.Forms.Button btnShowCustomers;
        private System.Windows.Forms.Button btnShowCategories;
    }
}