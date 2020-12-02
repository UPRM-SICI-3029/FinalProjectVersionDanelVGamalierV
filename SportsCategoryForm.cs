using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalProjectVersion2
{
    public partial class SportsCategoryForm : Form
    {
        int selectedRow, startingLetterPosition, finalLetterPosition;
        string filename = "SportsCategories.txt";
        string newSport, replacement = "";
        public SportsCategoryForm()
        {
            InitializeComponent();
        }

        private void SportsCategoryForm_Load(object sender, EventArgs e)
        {
            CreateDGV();
            ReturnAndClean();
        }

        public void CreateDGV()
        {
            dgvSportsCategories.Rows.Clear();
            StreamReader sr = new StreamReader("SportsCategories.txt");
            string x = sr.ReadToEnd();
            string[] y = x.Split(',');
            foreach (string s in y)
            {
                dgvSportsCategories.Rows.Add(s);
            }
            sr.Close();
        }
        public void SaveDGV()
        {
            const char DELIM = ',';
            StreamWriter productFile;
            productFile = File.CreateText(filename);
            int rowcount = dgvSportsCategories.Rows.Count;
            int a = 1;
            for (int i = 0; i < rowcount; i++)
            {
                if (a < rowcount)
                {

                    productFile.Write(dgvSportsCategories.Rows[i].Cells[0].Value.ToString() + DELIM);

                }
                else
                {
                    productFile.Write(dgvSportsCategories.Rows[i].Cells[0].Value.ToString());
                }
                a++;
            }
            productFile.Close();
        }
        public void ReturnAndClean()
        {
            btnDeleteCategory.Enabled = false;
            btnEditCategories.Enabled = false;
            btnAddCategory.Enabled = true;
            txtSportCategory.Text = "";
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                newSport = txtSportCategory.Text;
                int n = dgvSportsCategories.Rows.Add();
                if (newSport == "")
                {
                    newSport = "Placeholder";
                    MessageBox.Show("User has input a blank space, a placeholder has been placed to update later.");
                }
                finalLetterPosition = newSport.Length;
                for (startingLetterPosition = 0; startingLetterPosition < finalLetterPosition; startingLetterPosition++)
                {
                    if (newSport.Substring(startingLetterPosition, 1) == ",")
                        replacement += "";
                    else
                        replacement += newSport.Substring(startingLetterPosition, 1);
                }
                dgvSportsCategories.Rows[n].Cells[0].Value = replacement;
                replacement = "";
                SaveDGV();
                CreateDGV();
                ReturnAndClean();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowProducts_Click(object sender, EventArgs e)
        {
            InventoryForm inventory = new InventoryForm();
            inventory.Show();
            this.Close();
        }

        private void btnEditCategories_Click(object sender, EventArgs e)
        {
            try
            {
                newSport = txtSportCategory.Text;

                finalLetterPosition = newSport.Length;
                for (startingLetterPosition = 0; startingLetterPosition < finalLetterPosition; startingLetterPosition++)
                {
                    if (newSport.Substring(startingLetterPosition, 1) == ",")
                        replacement += "";
                    else
                        replacement += newSport.Substring(startingLetterPosition, 1);
                }
                if (replacement == "")
                {
                    replacement = "Placeholder";
                    MessageBox.Show("User has input a blank space, a placeholder has been placed to update later.");
                }

                dgvSportsCategories[0, selectedRow].Value = replacement;
                replacement = "";
                SaveDGV();
                CreateDGV();
                ReturnAndClean();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBackToAdd_Click(object sender, EventArgs e)
        {
            ReturnAndClean();
        }

        private void dgvSportsCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = dgvSportsCategories.CurrentRow.Index;
            txtSportCategory.Text = Convert.ToString(dgvSportsCategories[0, selectedRow].Value);
            btnAddCategory.Enabled = false;
            btnEditCategories.Enabled = true;
            btnDeleteCategory.Enabled = true;
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            DialogResult deleteProduct;
            deleteProduct = MessageBox.Show("Are you sure you want to delete this category?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteProduct == DialogResult.Yes)
            {
                dgvSportsCategories.Rows.RemoveAt(selectedRow);
            }
            SaveDGV();
            CreateDGV();
            ReturnAndClean();
        }

        private void btnShowCustomers_Click(object sender, EventArgs e)
        {
            CustomerForm showCustomer = new CustomerForm();
            showCustomer.Show();
            this.Close();
        }
    }
}