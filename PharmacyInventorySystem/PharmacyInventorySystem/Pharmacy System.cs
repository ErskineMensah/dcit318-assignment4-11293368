using System;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace PharmacyInventorySystem
{
    public partial class PharmacySystem : Form
    {
        private string connectionString;
        private SqlConnection connection;

        public PharmacySystem()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["PharmacyDBConnection"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        private void PharmacySystem_Load(object sender, EventArgs e)
        {
            LoadMedicines();
        }

        private void LoadMedicines()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("GetAllMedicines", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Columns["MedicineID"].HeaderText = "Medicine ID";
                dataGridView1.Columns["Name"].HeaderText = "Medicine Name";
                dataGridView1.Columns["Category"].HeaderText = "Category";
                dataGridView1.Columns["Price"].HeaderText = "Price (GHC)";
                dataGridView1.Columns["Quantity"].HeaderText = "Quantity";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading medicines: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                LoadMedicines();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            // Your update stock logic here
        }

        private void seacrhCatBtn(object sender, EventArgs e)
        {
            SearchMedicines("category");
        }

        private void searchNameBtn(object sender, EventArgs e)
        {
            SearchMedicines("name");
        }

        private void SearchMedicines(string searchType)
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                LoadMedicines();
                return;
            }

            try
            {
                connection.Open();
                SqlCommand cmd = searchType == "name"
                    ? new SqlCommand("SearchMedicineByName", connection)
                    : new SqlCommand("SearchMedicineByCategory", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SearchTerm", searchTextBox.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching medicines: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void addMedBtn_Click(object sender, EventArgs e)  // ? RENAMED
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(priceTextBox.Text) ||
                string.IsNullOrWhiteSpace(quantityTextBox.Text))
            {
                MessageBox.Show("Please fill in Name, Price and Quantity fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("AddMedicine", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", nameTextBox.Text);
                cmd.Parameters.AddWithValue("@Category", categoryTextBox.Text);
                cmd.Parameters.AddWithValue("@Price", decimal.Parse(priceTextBox.Text));
                cmd.Parameters.AddWithValue("@Quantity", int.Parse(quantityTextBox.Text));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Medicine added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputFields();
                LoadMedicines();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for Price and Quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding medicine: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void purchaseBtn_Click(object sender, EventArgs e)  // ? RENAMED
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a medicine from the list to record purchase.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(quantityTextBox.Text))
            {
                MessageBox.Show("Please enter quantity to purchase.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedQuantity;
            if (!int.TryParse(quantityTextBox.Text, out selectedQuantity) || selectedQuantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int medicineId = (int)dataGridView1.CurrentRow.Cells["MedicineID"].Value;
            int currentStock = (int)dataGridView1.CurrentRow.Cells["Quantity"].Value;
            string medicineName = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();

            if (selectedQuantity > currentStock)
            {
                MessageBox.Show($"Not enough stock of {medicineName}. Only {currentStock} available.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("RecordSale", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MedicineID", medicineId);
                cmd.Parameters.AddWithValue("@QuantitySold", selectedQuantity);

                cmd.ExecuteNonQuery();

                MessageBox.Show($"Purchase of {selectedQuantity} {medicineName} recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputFields();
                LoadMedicines();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error recording purchase: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index >= 0)
            {
                nameTextBox.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
                categoryTextBox.Text = dataGridView1.CurrentRow.Cells["Category"].Value.ToString();
                priceTextBox.Text = dataGridView1.CurrentRow.Cells["Price"].Value.ToString();
                quantityTextBox.Text = dataGridView1.CurrentRow.Cells["Quantity"].Value.ToString();
            }
        }

        private void ClearInputFields()
        {
            nameTextBox.Clear();
            categoryTextBox.Clear();
            priceTextBox.Clear();
            quantityTextBox.Clear();
            searchTextBox.Clear();
        }
    }
}