using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AracKiralama
{
    public partial class Form1 : Form
    {
        private List<string> AracListesi = new List<string>();
        private List<string> MusteriListesi = new List<string>();

        
        private DatabaseHelper dbHelper = new DatabaseHelper();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAracBilgisi.Text))
            {
                
                dbHelper.AracEkle(txtAracBilgisi.Text);

               
                lstAraclar.Items.Clear();
                List<string> araclar = dbHelper.GetAraclar();
                foreach (var arac in araclar)
                {
                    lstAraclar.Items.Add(arac);
                }

                txtAracBilgisi.Clear();
                MessageBox.Show("Araç eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Araç bilgisi boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMusteriBilgisi.Text))
            {
                
                dbHelper.MusteriEkle(txtMusteriBilgisi.Text);

                
                lstMusteriler.Items.Clear();
                List<string> musteriler = dbHelper.GetMusteriler();
                foreach (var musteri in musteriler)
                {
                    lstMusteriler.Items.Add(musteri);
                }

                txtMusteriBilgisi.Clear();
                MessageBox.Show("Müşteri eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Müşteri bilgisi boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKirala_Click(object sender, EventArgs e)
        {
            if (lstAraclar.SelectedItem != null && lstMusteriler.SelectedItem != null && cmbSure.SelectedItem != null)
            {
                string secilenArac = lstAraclar.SelectedItem.ToString();
                string secilenMusteri = lstMusteriler.SelectedItem.ToString();
                string sure = cmbSure.SelectedItem.ToString();

                
                int aracID = dbHelper.GetAracID(secilenArac);
                int musteriID = dbHelper.GetMusteriID(secilenMusteri);
                dbHelper.KiralamaYap(aracID, musteriID);

                MessageBox.Show($"{secilenMusteri}, {secilenArac} aracını {sure} süreliğine kiraladı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                lstAraclar.Items.Remove(secilenArac);
                AracListesi.Remove(secilenArac);

                
                string gunSonuBilgisi = $"Araç: {secilenArac}, Müşteri: {secilenMusteri}, Süre: {sure}";
                lstGunSonu.Items.Add(gunSonuBilgisi);
            }
            else
            {
                MessageBox.Show("Lütfen bir araç, bir müşteri ve süre seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGunSonuTemizle_Click(object sender, EventArgs e)
        {
            
            lstGunSonu.Items.Clear();
            MessageBox.Show("Gün sonu raporu temizlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public class DatabaseHelper
    {
        private string connectionString = "Server=localhost;Database=AracKiralamaDB;Trusted_Connection=True;";

        public void AracEkle(string aracBilgisi)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Araclar (AracBilgisi) VALUES (@AracBilgisi)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AracBilgisi", aracBilgisi);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void MusteriEkle(string musteriBilgisi)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Musteriler (MusteriBilgisi) VALUES (@MusteriBilgisi)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MusteriBilgisi", musteriBilgisi);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<string> GetAraclar()
        {
            List<string> araclar = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT AracBilgisi FROM Araclar";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    araclar.Add(reader["AracBilgisi"].ToString());
                }
            }

            return araclar;
        }

        public List<string> GetMusteriler()
        {
            List<string> musteriler = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MusteriBilgisi FROM Musteriler";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    musteriler.Add(reader["MusteriBilgisi"].ToString());
                }
            }

            return musteriler;
        }

        public int GetAracID(string aracBilgisi)
        {
            int aracID = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT AracID FROM Araclar WHERE AracBilgisi = @AracBilgisi";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AracBilgisi", aracBilgisi);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    aracID = Convert.ToInt32(reader["AracID"]);
                }
            }

            return aracID;
        }

        public int GetMusteriID(string musteriBilgisi)
        {
            int musteriID = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MusteriID FROM Musteriler WHERE MusteriBilgisi = @MusteriBilgisi";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MusteriBilgisi", musteriBilgisi);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    musteriID = Convert.ToInt32(reader["MusteriID"]);
                }
            }

            return musteriID;
        }

        public void KiralamaYap(int aracID, int musteriID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Kiralamalar (AracID, MusteriID, KiralamaTarihi) VALUES (@AracID, @MusteriID, @KiralamaTarihi)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AracID", aracID);
                cmd.Parameters.AddWithValue("@MusteriID", musteriID);
                cmd.Parameters.AddWithValue("@KiralamaTarihi", DateTime.Now);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
