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
    public partial class Form1 : Form
    {
        EgitimKampiEfTravelDBEntities1 db = new EgitimKampiEfTravelDBEntities1();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            // Toplam 2 satır kod ile tablodan veri çekebiliyoruz (db nesnesini en ustte olusturduk.)
            var values = db.Guide.ToList(); 
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Guide Tablomuz icin guide adında nesne üretiyoruz.
                Guide guide = new Guide();

                // Üretilen nesnenin tablo isimleri ile propertyleri alıyoruz.
                guide.GuideName = txtName.Text;
                guide.GuideSurname = txtSurname.Text;

                // Guide tablomuza ekliyoruz.
                db.Guide.Add(guide);

                // Veritabanını güncelliyoruz.
                db.SaveChanges();


                var values = db.Guide.ToList();
                dataGridView1.DataSource = values;

                MessageBox.Show("Rehber Başarıyla eklendi.", "Başarılı Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Silmek istenilen id bilgisi alınıyor.
            int id = int.Parse(txtId.Text);

            // Silinmesi istenen veriyi Guide tablosunda id sine göre bulup removeValue içine atıyoruz.
            var removeValue = db.Guide.Find(id);

            // removeValue değişkeninden gelen veriyi sil.
            db.Guide.Remove(removeValue);
            
            // Değişiklikleri kaydet.
            db.SaveChanges();

            MessageBox.Show("Rehber Başarıyla silindi.", "Başarılı Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            
            // Id ye göre güncellenmesi gereken id deki rehberin bilgilerini getirir.
            var updateValue = db.Guide.Find(id);

            // Gelen verideki isim ve soyisim alanlarına formdaki txtName ve txtSurname alanlarının değerlerini atıyor.
            updateValue.GuideName = txtName.Text;
            updateValue.GuideSurname = txtSurname.Text;

            // Değişiklikleri kaydet.
            db.SaveChanges();

            MessageBox.Show("Rehber Başarıyla Güncellendi.", "Başarılı Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);

            // Where linq sorgusudur.SQL'deki where şartına denktir.
            // x => x.GuideId == id: Her bir kayıt için GuideId değeri girilen id'ye eşit olanlar filtrelenir.
            var values = db.Guide.Where(x => x.GuideId == id).ToList();
            
            dataGridView1.DataSource = values;
        }
    }
}
