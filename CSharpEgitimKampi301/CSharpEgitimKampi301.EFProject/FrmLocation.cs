using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmLocation : Form
    {
        EgitimKampiEfTravelDBEntities1 db = new EgitimKampiEfTravelDBEntities1();
        public FrmLocation()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Location.Select(x => new
            {
                x.LocationId,
                x.City,
                x.Country,
                x.Capacity,
                x.Price,
                x.DayNight,
                GuideFullName = x.GuideId + " - " + x.Guide.GuideName + " " + x.Guide.GuideSurname,
            }).ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            // Veritabanındaki Guide tablosundan rehberin adı, soyadı ve ID'sini içeren bir liste oluşturuluyor
            var values = db.Guide.Select(x => new
            {
                // Rehberin adı ve soyadı birleştirilerek FullName alanı oluşturuluyor
                FullName = x.GuideName + " " + x.GuideSurname,

                // Rehberin benzersiz kimliği (ID)
                x.GuideId
            }).ToList();

            // ComboBox'ta görüntülenecek metin alanı olarak FullName atanıyor
            comboBoxGuide.DisplayMember = "FullName";

            // Seçilen öğenin değer (ID) alanı olarak GuideId atanıyor
            comboBoxGuide.ValueMember = "GuideId";

            // ComboBox'ın veri kaynağı olarak yukarıda oluşturulan liste atanıyor
            comboBoxGuide.DataSource = values;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.Capacity = byte.Parse(numericUpDownCapacity.Value.ToString());
            location.City = txtCity.Text;
            location.Country = txtCountry.Text;
            location.Price = decimal.Parse(txtPrice.Text);
            location.DayNight = textBoxDayNight.Text;
            location.GuideId = int.Parse(comboBoxGuide.SelectedValue.ToString());
            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarılı");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtLocationId.Text);
            var deletedValue = db.Location.Find(id);
            db.Location.Remove(deletedValue);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarılı");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtLocationId.Text);
            var updatedValue = db.Location.Find(id);
            updatedValue.DayNight = textBoxDayNight.Text;
            updatedValue.Price = decimal.Parse(txtPrice.Text);
            updatedValue.Capacity = byte.Parse(numericUpDownCapacity.Text);
            updatedValue.City = txtCity.Text;
            updatedValue.Country = txtCountry.Text;
            updatedValue.GuideId = int.Parse(comboBoxGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarılı");
        }
    }
}
