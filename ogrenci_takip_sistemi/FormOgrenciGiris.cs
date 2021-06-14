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
    public partial class FormOgrenciGiris : Form
    {
        public FormOgrenciGiris()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            SqlCommand giris = new SqlCommand("Select * from Tbl_ogrenci where TC=@g1 and Numara=@g2", conn);
            giris.Parameters.AddWithValue("@g1", textBox1.Text);
            giris.Parameters.AddWithValue("@g2", textBox2.Text);
            SqlDataReader dr = giris.ExecuteReader();
            if (dr.Read())
            {
                FormOgrenciPaneli fr = new FormOgrenciPaneli();
                fr.TC = textBox1.Text;
                fr.NO = textBox2.Text;
                
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC veya Okul Numaranızı yanlış girdiniz.Tekrar deneyin", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }
    }
}
