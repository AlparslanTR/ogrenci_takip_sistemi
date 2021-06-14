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
    public partial class FormMezunGiris : Form
    {
        public FormMezunGiris()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            SqlCommand giris = new SqlCommand("Select * From Tbl_Ogrenci Where TC=@g1 and Numara=@g2", conn);
            giris.Parameters.AddWithValue("@g1",textBox1.Text);
            giris.Parameters.AddWithValue("@g2", textBox2.Text);
            giris.ExecuteNonQuery();
            SqlDataReader dr = giris.ExecuteReader();
            if (dr.Read())
            {
                FormMezunPaneli fr = new FormMezunPaneli();
                fr.TC = textBox1.Text;
                fr.Numara = textBox2.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC veya Numaranız Hatalı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
    }
}
