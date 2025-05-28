using CSharpEgitimKampi601.Entities;
using CSharpEgitimKampi601.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi601
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Customer> customers = customerOperations.GetAllCustomer();
            dataGridView1.DataSource = customers;
        }
        // CustomerOperations sınıfından bir nesne oluşturuluyor (müşteri işlemlerini yönetmek için)
        CustomerOperations customerOperations = new CustomerOperations();

        // "Müşteri Oluştur" butonuna tıklanıldığında çalışacak olay metodu
        private void btnCustomerCreate_Click(object sender, EventArgs e)
        {
            // Kullanıcı arayüzünden alınan verilerle yeni bir Customer nesnesi oluşturuluyor
            var customer = new Customer()
            {
                CustomerName = txtCustomerName.Text,                             // İsim metin kutusundan alınır
                CustomerSurname = txtCustomerSurname.Text,                       // Soyisim metin kutusundan alınır
                CustomerCity = txtCustomerCity.Text,                             // Şehir metin kutusundan alınır
                CustomerBalance = decimal.Parse(txtCustomerBalance.Text),        // Bakiye metin kutusundan alınır ve decimal'e çevrilir
                CustomerShoppingCount = int.Parse(txtCustomerShoppingCount.Text) // Alışveriş sayısı metin kutusundan alınır ve int'e çevrilir
            };

            // CustomerOperations sınıfı kullanılarak MongoDB'ye müşteri ekleme işlemi gerçekleştirilir
            customerOperations.AddCustomer(customer);

            // Kullanıcıya bilgilendirme mesajı gösterilir
            MessageBox.Show("Müşteri Ekleme İşlemi Başarılı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            List<Customer> customers = customerOperations.GetAllCustomer();
            dataGridView1.DataSource = customers;
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            string customerId = txtCustomerId.Text;
            customerOperations.DeleteCustomer(customerId);
            MessageBox.Show("Müşteri Başarılı bir şekilde silindi.");
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            string id = txtCustomerId.Text;
            var updateCustomer = new Customer()
            {
                CustomerName = txtCustomerName.Text,
                CustomerBalance = decimal.Parse(txtCustomerBalance.Text),
                CustomerCity = txtCustomerCity.Text,
                CustomerShoppingCount = int.Parse(txtCustomerShoppingCount.Text),
                CustomerSurname = txtCustomerSurname.Text,
                CustomerId = txtCustomerId.Text
            };
            customerOperations.UpdateCustomer(updateCustomer);
            MessageBox.Show("Müşteri Başarılı bir şekilde güncellendi.");
        }

        private void btnGetByCustomerId_Click(object sender, EventArgs e)
        {
            string id = txtCustomerId.Text;
            Customer customers = customerOperations.GetCustomerById(id);
            dataGridView1.DataSource = new List<Customer>() { customers };
        }
    }
}
