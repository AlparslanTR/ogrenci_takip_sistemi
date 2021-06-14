using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ogrenci_takip_sistemi
{
    public partial class FormMezunPaneli : Form
    {
      

        public FormMezunPaneli()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();
        public string TC,Numara;

        private void BtnHatıra_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            SqlCommand hatıra = new SqlCommand("Insert into Tbl_Hatıra (Hatıralar)values(@h1)", conn);
            hatıra.Parameters.AddWithValue("@h1", richTextBox1.Text);
            hatıra.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Hatıranız Eklenmiştir", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tbl_HatıraTableAdapter.Fill(this.ogrenci_takipDataSet15.Tbl_Hatıra);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            SqlCommand ekle = new SqlCommand("Insert into Tbl_Mezun (Universite,Meslek,MeslekYılları,Tecrübe)values(@e1,@e2,@e3,@e4)", conn);
            ekle.Parameters.AddWithValue("@e1", comboBox1.Text);
            ekle.Parameters.AddWithValue("@e2", textBox1.Text);
            ekle.Parameters.AddWithValue("@e3", textBox2.Text);
            ekle.Parameters.AddWithValue("@e4", textBox3.Text);
            ekle.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Bilgileriniz Eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.tbl_MezunTableAdapter.Fill(this.ogrenci_takipDataSet18.Tbl_Mezun);

        }

        private void FormMezunPaneli_Load(object sender, EventArgs e)
        {
        
            // TODO: Bu kod satırı 'ogrenci_takipDataSet15.Tbl_Hatıra' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_HatıraTableAdapter.Fill(this.ogrenci_takipDataSet15.Tbl_Hatıra);
            label8.Text = TC;
            label7.Text = Numara;
            // AD GETİRDİK
            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            SqlCommand adgetir = new SqlCommand("Select Ad From Tbl_ogrenci Where TC=@a1", conn);
            adgetir.Parameters.AddWithValue("@a1", label8.Text);
            SqlDataReader ad = adgetir.ExecuteReader();
            while (ad.Read())
            {
                label6.Text = (string)ad[0];

            }
            conn.Close();
            // SOYADI GETİRME
            conn.Open();
            SqlCommand soygetir = new SqlCommand("Select Soyad From Tbl_Ogrenci Where TC=@s1", conn);
            soygetir.Parameters.AddWithValue("@s1", label8.Text);
            SqlDataReader soy = soygetir.ExecuteReader();
            while (soy.Read())
            {
                label5.Text = (string)soy[0];

            }
            conn.Close();

            //Durum 

            conn.Open();
            SqlCommand durum = new SqlCommand("Select Durum From Tbl_Ogrenci Where TC=@d1", conn);
            durum.Parameters.AddWithValue("@d1", label8.Text);
            SqlDataReader dur = durum.ExecuteReader();
            while (dur.Read())
            {
                label10.Text = dur[0].ToString();
            }
            conn.Close();
        }
    }
}
