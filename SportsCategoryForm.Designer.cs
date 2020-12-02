
namespace FinalProjectVersion2
{
    partial class SportsCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SportsCategoryForm));
            this.dgvSportsCategories = new System.Windows.Forms.DataGridView();
            this.Sports_Categories_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtSportCategory = new System.Windows.Forms.TextBox();
            this.btnShowProducts = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.lblCategoriesBanner = new System.Windows.Forms.Label();
            this.btnEditCategories = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnShowCustomers = new System.Windows.Forms.Button();
            this.lblSportCategory = new System.Windows.Forms.Label();
            this.btnBackToAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSportsCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSportsCategories
            // 
            this.dgvSportsCategories.AllowUserToAddRows = false;
            this.dgvSportsCategories.AllowUserToDeleteRows = false;
            this.dgvSportsCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSportsCategories.BackgroundColor = System.Drawing.Color.Black;
            this.dgvSportsCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSportsCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sports_Categories_Column});
            this.dgvSportsCategories.Location = new System.Drawing.Point(461, 137);
            this.dgvSportsCategories.Name = "dgvSportsCategories";
            this.dgvSportsCategories.ReadOnly = true;
            this.dgvSportsCategories.Size = new System.Drawing.Size(327, 239);
            this.dgvSportsCategories.TabIndex = 0;
            this.dgvSportsCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSportsCategories_CellClick);
            // 
            // Sports_Categories_Column
            // 
            this.Sports_Categories_Column.HeaderText = "Sports_Categories";
            this.Sports_Categories_Column.Name = "Sports_Categories_Column";
            this.Sports_Categories_Column.ReadOnly = true;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.Black;
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Location = new System.Drawing.Point(91, 353);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(75, 23);
            this.btnAddCategory.TabIndex = 1;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtSportCategory
            // 
            this.txtSportCategory.Location = new System.Drawing.Point(259, 242);
            this.txtSportCategory.Name = "txtSportCategory";
            this.txtSportCategory.Size = new System.Drawing.Size(133, 20);
            this.txtSportCategory.TabIndex = 2;
            // 
            // btnShowProducts
            // 
            this.btnShowProducts.BackColor = System.Drawing.Color.Black;
            this.btnShowProducts.ForeColor = System.Drawing.Color.White;
            this.btnShowProducts.Location = new System.Drawing.Point(259, 91);
            this.btnShowProducts.Name = "btnShowProducts";
            this.btnShowProducts.Size = new System.Drawing.Size(100, 23);
            this.btnShowProducts.TabIndex = 3;
            this.btnShowProducts.Text = "Products";
            this.btnShowProducts.UseVisualStyleBackColor = false;
            this.btnShowProducts.Click += new System.EventHandler(this.btnShowProducts_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.Black;
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCategory.Location = new System.Drawing.Point(317, 353);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCategory.TabIndex = 4;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // lblCategoriesBanner
            // 
            this.lblCategoriesBanner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoriesBanner.BackColor = System.Drawing.Color.Gray;
            this.lblCategoriesBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriesBanner.ForeColor = System.Drawing.Color.LightGreen;
            this.lblCategoriesBanner.Location = new System.Drawing.Point(0, 0);
            this.lblCategoriesBanner.Name = "lblCategoriesBanner";
            this.lblCategoriesBanner.Size = new System.Drawing.Size(827, 114);
            this.lblCategoriesBanner.TabIndex = 5;
            this.lblCategoriesBanner.Text = "Manage Categories";
            this.lblCategoriesBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditCategories
            // 
            this.btnEditCategories.BackColor = System.Drawing.Color.Black;
            this.btnEditCategories.ForeColor = System.Drawing.Color.White;
            this.btnEditCategories.Location = new System.Drawing.Point(206, 353);
            this.btnEditCategories.Name = "btnEditCategories";
            this.btnEditCategories.Size = new System.Drawing.Size(75, 23);
            this.btnEditCategories.TabIndex = 6;
            this.btnEditCategories.Text = "Edit/Update";
            this.btnEditCategories.UseVisualStyleBackColor = false;
            this.btnEditCategories.Click += new System.EventHandler(this.btnEditCategories_Click);
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.Black;
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.Location = new System.Drawing.Point(461, 91);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(100, 23);
            this.btn.TabIndex = 7;
            this.btn.Text = "Categories";
            this.btn.UseVisualStyleBackColor = false;
            // 
            // btnShowCustomers
            // 
            this.btnShowCustomers.BackColor = System.Drawing.Color.Black;
            this.btnShowCustomers.ForeColor = System.Drawing.Color.White;
            this.btnShowCustomers.Location = new System.Drawing.Point(360, 91);
            this.btnShowCustomers.Name = "btnShowCustomers";
            this.btnShowCustomers.Size = new System.Drawing.Size(100, 23);
            this.btnShowCustomers.TabIndex = 8;
            this.btnShowCustomers.Text = "Customers";
            this.btnShowCustomers.UseVisualStyleBackColor = false;
            this.btnShowCustomers.Click += new System.EventHandler(this.btnShowCustomers_Click);
            // 
            // lblSportCategory
            // 
            this.lblSportCategory.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblSportCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSportCategory.Location = new System.Drawing.Point(87, 239);
            this.lblSportCategory.Name = "lblSportCategory";
            this.lblSportCategory.Size = new System.Drawing.Size(123, 23);
            this.lblSportCategory.TabIndex = 9;
            this.lblSportCategory.Text = "Sport Category:";
            this.lblSportCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBackToAdd
            // 
            this.btnBackToAdd.BackColor = System.Drawing.Color.Black;
            this.btnBackToAdd.ForeColor = System.Drawing.Color.White;
            this.btnBackToAdd.Location = new System.Drawing.Point(91, 382);
            this.btnBackToAdd.Name = "btnBackToAdd";
            this.btnBackToAdd.Size = new System.Drawing.Size(75, 23);
            this.btnBackToAdd.TabIndex = 10;
            this.btnBackToAdd.Text = "Back to Add";
            this.btnBackToAdd.UseVisualStyleBackColor = false;
            this.btnBackToAdd.Click += new System.EventHandler(this.btnBackToAdd_Click);
            // 
            // SportsCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(825, 413);
            this.Controls.Add(this.btnBackToAdd);
            this.Controls.Add(this.lblSportCategory);
            this.Controls.Add(this.btnShowCustomers);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnShowProducts);
            this.Controls.Add(this.btnEditCategories);
            this.Controls.Add(this.lblCategoriesBanner);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.txtSportCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.dgvSportsCategories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SportsCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Categories";
            this.Load += new System.EventHandler(this.SportsCategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSportsCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Sports_Categories_Column;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox txtSportCategory;
        private System.Windows.Forms.Button btnShowProducts;
        public System.Windows.Forms.DataGridView dgvSportsCategories;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Label lblCategoriesBanner;
        private System.Windows.Forms.Button btnEditCategories;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnShowCustomers;
        private System.Windows.Forms.Label lblSportCategory;
        private System.Windows.Forms.Button btnBackToAdd;
    }
}