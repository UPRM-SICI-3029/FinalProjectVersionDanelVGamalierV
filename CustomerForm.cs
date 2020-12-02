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
    public partial class CustomerForm : Form
    {
        int selectedRow, startingLetterPosition, finalLetterPosition;
        long telephone;
        string firstName, lastName, address, email, replacementFirstName = "", replacementLastName = "", replacementAddress = "", replacementEmail = "";
        string filename = "CustomerInformation.txt";
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void btnAddCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                firstName = txtFirstName.Text;
                lastName = txtLastName.Text;
                telephone = Convert.ToInt64(txtTelephone.Text);
                address = txtAddress.Text;
                email = txtEmail.Text;
                finalLetterPosition = firstName.Length;
                for (startingLetterPosition = 0; startingLetterPosition < finalLetterPosition; startingLetterPosition++)
                {
                    if (firstName.Substring(startingLetterPosition, 1) == ",")
                        replacementFirstName += "";
                    else
                        replacementFirstName += firstName.Substring(startingLetterPosition, 1);
                }

                finalLetterPosition = lastName.Length;
                for (startingLetterPosition = 0; startingLetterPosition < finalLetterPosition; startingLetterPosition++)
                {
                    if (lastName.Substring(startingLetterPosition, 1) == ",")
                        replacementLastName += "";
                    else
                        replacementLastName += lastName.Substring(startingLetterPosition, 1);
                }

                finalLetterPosition = address.Length;
                for (startingLetterPosition = 0; startingLetterPosition < finalLetterPosition; startingLetterPosition++)
                {
                    if (address.Substring(startingLetterPosition, 1) == ",")
                        replacementAddress += "";
                    else
                        replacementAddress += address.Substring(startingLetterPosition, 1);
                }

                finalLetterPosition = email.Length;
                for (startingLetterPosition = 0; startingLetterPosition < finalLetterPosition; startingLetterPosition++)
                {
                    if (email.Substring(startingLetterPosition, 1) == ",")
                        replacementEmail += "";
                    else
                        replacementEmail += email.Substring(startingLetterPosition, 1);
                }
                if (replacementFirstName == "" || replacementLastName == "" || replacementAddress == "" || replacementEmail == "")
                {
                    MessageBox.Show("Please fill out all the boxes");
                    ReturnAndClean();
                    replacementFirstName = "";
                    replacementLastName = "";
                    replacementAddress = "";
                    replacementEmail = "";
                }
                else
                {
                    int n = dgvCustomers.Rows.Add();
                    dgvCustomers.Rows[n].Cells[0].Value = replacementFirstName;
                    dgvCustomers.Rows[n].Cells[1].Value = replacementLastName;
                    dgvCustomers.Rows[n].Cells[2].Value = telephone;
                    dgvCustomers.Rows[n].Cells[3].Value = replacementAddress;
                    dgvCustomers.Rows[n].Cells[4].Value = replacementEmail;
                    replacementFirstName = "";
                    replacementLastName = "";
                    replacementAddress = "";
                    replacementEmail = "";
                    SaveDGV();
                    CreateDGV();
                    ReturnAndClean();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("The telephone number must be only numbers.\nDo not use any dashes or characters that aren't numbers.", "Input error");
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

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = dgvCustomers.CurrentRow.Index;
            txtFirstName.Text = Convert.ToString(dgvCustomers[0, selectedRow].Value);
            txtLastName.Text = Convert.ToString(dgvCustomers[1, selectedRow].Value);
            txtTelephone.Text = Convert.ToString(dgvCustomers[2, selectedRow].Value);
            txtAddress.Text = Convert.ToString(dgvCustomers[3, selectedRow].Value);
            txtEmail.Text = Convert.ToString(dgvCustomers[4, selectedRow].Value);
            btnAddCustomers.Enabled = false;
            btnEditCustomers.Enabled = true;
            btnDeleteCustomers.Enabled = true;
        }

        public void CreateDGV()
        {
            dgvCustomers.Rows.Clear();

            using (var streamReader = new StreamReader(filename))
            {
                while (!streamReader.EndOfStream)
                {
                    var line = streamReader.ReadLine();
                    var values = line.Split(',');
                    var rowIndex = dgvCustomers.Rows.Add();
                    for (int i = 0; i < values.Length; i++)
                    {
                        dgvCustomers.Rows[rowIndex].Cells[i].Value = values[i];
                    }
                }
            }
        }

        private void btnEditCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                firstName = txtFirstName.Text;
                lastName = txtLastName.Text;
                telephone = Convert.ToInt64(txtTelephone.Text);
                address =  txtAddress.Text;
                email = txtEmail.Text;
                finalLetterPosition = firstName.Length;
                for (startingLetterPosition = 0; startingLetterPosition < finalLetterPosition; startingLetterPosition++)
                {
                    if (firstName.Substring(startingLetterPosition, 1) == ",")
                        replacementFirstName += "";
                    else
                        replacementFirstName += firstName.Substring(startingLetterPosition, 1);
                }

                finalLetterPosition = lastName.Length;
                for (startingLetterPosition = 0; startingLetterPosition < finalLetterPosition; startingLetterPosition++)
                {
                    if (lastName.Substring(startingLetterPosition, 1) == ",")
                        replacementLastName += "";
                    else
                        replacementLastName += lastName.Substring(startingLetterPosition, 1);
                }

                finalLetterPosition = address.Length;
                for (startingLetterPosition = 0; startingLetterPosition < finalLetterPosition; startingLetterPosition++)
                {
                    if (address.Substring(startingLetterPosition, 1) == ",")
                        replacementAddress += "";
                    else
                        replacementAddress += address.Substring(startingLetterPosition, 1);
                }

                finalLetterPosition = email.Length;
                for (startingLetterPosition = 0; startingLetterPosition < finalLetterPosition; startingLetterPosition++)
                {
                    if (email.Substring(startingLetterPosition, 1) == ",")
                        replacementEmail += "";
                    else
                        replacementEmail += email.Substring(startingLetterPosition, 1);
                }
                if (replacementFirstName == "" || replacementLastName == "" || replacementAddress == "" || replacementEmail == "")
                {
                    MessageBox.Show("Please fill out all the boxes");
                    ReturnAndClean();
                    replacementFirstName = "";
                    replacementLastName = "";
                    replacementAddress = "";
                    replacementEmail = "";
                }
                else
                {
                    dgvCustomers[0, selectedRow].Value = replacementFirstName;
                    dgvCustomers[1, selectedRow].Value = replacementLastName;
                    dgvCustomers[2, selectedRow].Value = telephone;
                    dgvCustomers[3, selectedRow].Value = replacementAddress;
                    dgvCustomers[4, selectedRow].Value = replacementEmail;
                    replacementFirstName = "";
                    replacementLastName = "";
                    replacementAddress = "";
                    replacementEmail = "";
                    SaveDGV();
                    CreateDGV();
                    ReturnAndClean();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("The telephone number must be only numbers.\nDo not use any dashes or characters that aren't numbers.", "Input error");
                ReturnAndClean();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteCustomers_Click(object sender, EventArgs e)
        {
            DialogResult deleteProduct;
            deleteProduct = MessageBox.Show("Are you sure you want to delete this customer?", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteProduct == DialogResult.Yes)
            {
                dgvCustomers.Rows.RemoveAt(selectedRow);
            }
            SaveDGV();
            CreateDGV();
            ReturnAndClean();
        }

        private void btnShowProducts_Click(object sender, EventArgs e)
        {
            InventoryForm showInventory = new InventoryForm();
            showInventory.Show();
            this.Close();
        }

        private void btnShowCategories_Click(object sender, EventArgs e)
        {
            SportsCategoryForm showCategories = new SportsCategoryForm();
            showCategories.Show();
            this.Close();
        }

        public void SaveDGV()
        {

            const char DELIM = ',';

            StreamWriter productFile;
            productFile = File.CreateText(filename);
            int rowcount = dgvCustomers.Rows.Count;
            for (int i = 0; i < rowcount; i++)
            {
                productFile.WriteLine(dgvCustomers.Rows[i].Cells[0].Value.ToString() + DELIM
                    + dgvCustomers.Rows[i].Cells[1].Value.ToString() + DELIM
                    + dgvCustomers.Rows[i].Cells[2].Value.ToString() + DELIM
                    + dgvCustomers.Rows[i].Cells[3].Value.ToString() + DELIM
                    + dgvCustomers.Rows[i].Cells[4].Value.ToString());
            }
            productFile.Close();
        }

        public void ReturnAndClean()
        {
            btnEditCustomers.Enabled = false;
            btnDeleteCustomers.Enabled = false;
            btnAddCustomers.Enabled = true;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtTelephone.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            CreateDGV();
            ReturnAndClean();
        }
    }
}
