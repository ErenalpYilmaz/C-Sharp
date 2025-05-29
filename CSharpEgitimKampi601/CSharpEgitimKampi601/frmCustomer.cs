using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSharpEgitimKampi601
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        // PASSWORD GIRMEZSEN CALISMAZ.
        string connectionString = "Server=localhost;port=5432;Database=CustomerDb;user Id=postgres;Password=!!!PASSWORD!!!";
        void GetAllCustomers()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Customers";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }
        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            GetAllCustomers();
        }

        private void btnCustomerCreate_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            string customerSurname = txtCustomerSurname.Text;
            string customerCity = txtCustomerCity.Text;

            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Insert into Customers(CustomerName,CustomerSurname,CustomerCity) values (@CustomerName,@CustomerSurname,@CustomerCity)";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerName",customerName);
            command.Parameters.AddWithValue("@customerSurname",customerSurname);
            command.Parameters.AddWithValue("@customerCity",customerCity);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Ekleme İşlemi Başarılı.");
            GetAllCustomers();
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCustomerId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Delete from Customers where CustomerId = @customerId";
            var command = new NpgsqlCommand(query,connection);
            command.Parameters.AddWithValue("@customerId",id);
            command.ExecuteNonQuery();
            connection.Close();
            GetAllCustomers();
            MessageBox.Show("Silme Islemi Başarılı.");
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            string customerSurname = txtCustomerSurname.Text;
            string customerCity = txtCustomerCity.Text;
            int id = int.Parse(txtCustomerId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Update Customers set CustomerName=@customerName,CustomerSurname=@customerSurname,CustomerCity=@customerCity where CustomerId=@customerId";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerId",id);
            command.Parameters.AddWithValue("@customerName", customerName);
            command.Parameters.AddWithValue("@customerSurname", customerSurname);
            command.Parameters.AddWithValue("@customerCity", customerCity);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Güncelleme işlemi başarılı.");
            GetAllCustomers();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Geçerli satırın indeksini al
            int selectedRowIndex = e.RowIndex;

            // Geçerli satırın indeksinin geçerli olduğundan emin ol
            if (selectedRowIndex >= 0)
            {
                // Satırı al
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                // Örnek: 3 adet TextBox'a veri atama (sütunlara göre indeksleme yapılıyor)
                txtCustomerId.Text = selectedRow.Cells[0].Value.ToString(); // Örneğin ID
                txtCustomerName.Text = selectedRow.Cells[1].Value.ToString(); // Örneğin Ad
                txtCustomerSurname.Text = selectedRow.Cells[2].Value.ToString(); // Örneğin Soyad
                txtCustomerCity.Text = selectedRow.Cells[3].Value.ToString(); // Örneğin Soyad
            }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
