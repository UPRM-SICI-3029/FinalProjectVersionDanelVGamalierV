
namespace FinalProjectVersion2
{
    partial class InventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.lblBanner = new System.Windows.Forms.Label();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSportsCategory = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnDoNothing = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEditProducts = new System.Windows.Forms.Button();
            this.btnDeleteProducts = new System.Windows.Forms.Button();
            this.btnShowCustomers = new System.Windows.Forms.Button();
            this.btnShowCategories = new System.Windows.Forms.Button();
            this.btnBackToAdd = new System.Windows.Forms.Button();
            this.cmbSportsCategory = new System.Windows.Forms.ComboBox();
            this.Product_ID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sports_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBanner
            // 
            this.lblBanner.BackColor = System.Drawing.Color.Gray;
            this.lblBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.ForeColor = System.Drawing.Color.LightGreen;
            this.lblBanner.Location = new System.Drawing.Point(-1, 0);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(1009, 114);
            this.lblBanner.TabIndex = 0;
            this.lblBanner.Text = "Sports Equipment Inventory";
            this.lblBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.Black;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_ID_Column,
            this.Product_Name,
            this.Stock_Column,
            this.Price_Column,
            this.Sports_Category});
            this.dgvInventory.Location = new System.Drawing.Point(409, 149);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.Size = new System.Drawing.Size(585, 258);
            this.dgvInventory.TabIndex = 1;
            this.dgvInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellClick);
            // 
            // lblProductId
            // 
            this.lblProductId.BackColor = System.Drawing.Color.SpringGreen;
            this.lblProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.Location = new System.Drawing.Point(22, 168);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(100, 23);
            this.lblProductId.TabIndex = 2;
            this.lblProductId.Text = "Product Id:";
            this.lblProductId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.Color.Honeydew;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(22, 211);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(120, 23);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "Product Name:";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStock
            // 
            this.lblStock.BackColor = System.Drawing.Color.Aquamarine;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(22, 250);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(178, 23);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Stock:";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.SkyBlue;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(22, 293);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(100, 23);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSportsCategory
            // 
            this.lblSportsCategory.BackColor = System.Drawing.Color.SlateBlue;
            this.lblSportsCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSportsCategory.Location = new System.Drawing.Point(22, 333);
            this.lblSportsCategory.Name = "lblSportsCategory";
            this.lblSportsCategory.Size = new System.Drawing.Size(128, 23);
            this.lblSportsCategory.TabIndex = 6;
            this.lblSportsCategory.Text = "Sport Category:";
            this.lblSportsCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(249, 168);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(100, 20);
            this.txtProductId.TabIndex = 7;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(249, 211);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 8;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(249, 250);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 9;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(249, 293);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 10;
            // 
            // btnDoNothing
            // 
            this.btnDoNothing.BackColor = System.Drawing.Color.Black;
            this.btnDoNothing.ForeColor = System.Drawing.Color.White;
            this.btnDoNothing.Location = new System.Drawing.Point(272, 91);
            this.btnDoNothing.Name = "btnDoNothing";
            this.btnDoNothing.Size = new System.Drawing.Size(141, 23);
            this.btnDoNothing.TabIndex = 12;
            this.btnDoNothing.Text = "Products";
            this.btnDoNothing.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(26, 384);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEditProducts
            // 
            this.btnEditProducts.BackColor = System.Drawing.Color.Black;
            this.btnEditProducts.ForeColor = System.Drawing.Color.White;
            this.btnEditProducts.Location = new System.Drawing.Point(151, 384);
            this.btnEditProducts.Name = "btnEditProducts";
            this.btnEditProducts.Size = new System.Drawing.Size(75, 23);
            this.btnEditProducts.TabIndex = 14;
            this.btnEditProducts.Text = "Edit/Update";
            this.btnEditProducts.UseVisualStyleBackColor = false;
            this.btnEditProducts.Click += new System.EventHandler(this.btnEditProducts_Click);
            // 
            // btnDeleteProducts
            // 
            this.btnDeleteProducts.BackColor = System.Drawing.Color.Black;
            this.btnDeleteProducts.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProducts.Location = new System.Drawing.Point(274, 384);
            this.btnDeleteProducts.Name = "btnDeleteProducts";
            this.btnDeleteProducts.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProducts.TabIndex = 15;
            this.btnDeleteProducts.Text = "Delete";
            this.btnDeleteProducts.UseVisualStyleBackColor = false;
            this.btnDeleteProducts.Click += new System.EventHandler(this.btnDeleteProducts_Click);
            // 
            // btnShowCustomers
            // 
            this.btnShowCustomers.BackColor = System.Drawing.Color.Black;
            this.btnShowCustomers.ForeColor = System.Drawing.Color.White;
            this.btnShowCustomers.Location = new System.Drawing.Point(413, 91);
            this.btnShowCustomers.Name = "btnShowCustomers";
            this.btnShowCustomers.Size = new System.Drawing.Size(145, 23);
            this.btnShowCustomers.TabIndex = 16;
            this.btnShowCustomers.Text = "Customers";
            this.btnShowCustomers.UseVisualStyleBackColor = false;
            this.btnShowCustomers.Click += new System.EventHandler(this.btnShowCustomers_Click);
            // 
            // btnShowCategories
            // 
            this.btnShowCategories.BackColor = System.Drawing.Color.Black;
            this.btnShowCategories.ForeColor = System.Drawing.Color.White;
            this.btnShowCategories.Location = new System.Drawing.Point(558, 91);
            this.btnShowCategories.Name = "btnShowCategories";
            this.btnShowCategories.Size = new System.Drawing.Size(133, 23);
            this.btnShowCategories.TabIndex = 17;
            this.btnShowCategories.Text = "Categories";
            this.btnShowCategories.UseVisualStyleBackColor = false;
            this.btnShowCategories.Click += new System.EventHandler(this.btnShowCategories_Click);
            // 
            // btnBackToAdd
            // 
            this.btnBackToAdd.BackColor = System.Drawing.Color.Black;
            this.btnBackToAdd.ForeColor = System.Drawing.Color.White;
            this.btnBackToAdd.Location = new System.Drawing.Point(26, 429);
            this.btnBackToAdd.Name = "btnBackToAdd";
            this.btnBackToAdd.Size = new System.Drawing.Size(75, 23);
            this.btnBackToAdd.TabIndex = 18;
            this.btnBackToAdd.Text = "Back to Add";
            this.btnBackToAdd.UseVisualStyleBackColor = false;
            this.btnBackToAdd.Click += new System.EventHandler(this.btnBackToAdd_Click);
            // 
            // cmbSportsCategory
            // 
            this.cmbSportsCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSportsCategory.FormattingEnabled = true;
            this.cmbSportsCategory.Location = new System.Drawing.Point(237, 333);
            this.cmbSportsCategory.Name = "cmbSportsCategory";
            this.cmbSportsCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbSportsCategory.TabIndex = 19;
            // 
            // Product_ID_Column
            // 
            this.Product_ID_Column.FillWeight = 86.92892F;
            this.Product_ID_Column.HeaderText = "Product_ID";
            this.Product_ID_Column.Name = "Product_ID_Column";
            this.Product_ID_Column.ReadOnly = true;
            // 
            // Product_Name
            // 
            this.Product_Name.FillWeight = 152.2842F;
            this.Product_Name.HeaderText = "Product_Name";
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            // 
            // Stock_Column
            // 
            this.Stock_Column.FillWeight = 86.92892F;
            this.Stock_Column.HeaderText = "Stock";
            this.Stock_Column.Name = "Stock_Column";
            this.Stock_Column.ReadOnly = true;
            // 
            // Price_Column
            // 
            this.Price_Column.FillWeight = 86.92892F;
            this.Price_Column.HeaderText = "Price";
            this.Price_Column.Name = "Price_Column";
            this.Price_Column.ReadOnly = true;
            // 
            // Sports_Category
            // 
            this.Sports_Category.FillWeight = 86.92892F;
            this.Sports_Category.HeaderText = "Sports_Category";
            this.Sports_Category.Name = "Sports_Category";
            this.Sports_Category.ReadOnly = true;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1006, 473);
            this.Controls.Add(this.cmbSportsCategory);
            this.Controls.Add(this.btnBackToAdd);
            this.Controls.Add(this.btnShowCategories);
            this.Controls.Add(this.btnShowCustomers);
            this.Controls.Add(this.btnDeleteProducts);
            this.Controls.Add(this.btnEditProducts);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDoNothing);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.lblSportsCategory);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.lblBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports Equipment Inventory";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSportsCategory;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnDoNothing;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEditProducts;
        private System.Windows.Forms.Button btnDeleteProducts;
        public System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Button btnShowCustomers;
        private System.Windows.Forms.Button btnShowCategories;
        private System.Windows.Forms.Button btnBackToAdd;
        private System.Windows.Forms.ComboBox cmbSportsCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_ID_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sports_Category;
    }
}