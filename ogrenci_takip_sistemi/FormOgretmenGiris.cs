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
    public partial class FormOgretmenGiris : Form
    {
        public FormOgretmenGiris()
        {
            InitializeComponent();
        }
        void temizle2()
        {
            textadmin.Text = "";
            textsifre.Text = "";
        }
        baglanti bgl = new baglanti();
        
        private void textgiris_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            SqlCommand komutgiris = new SqlCommand("Select * from TblAdminGiris where KullaniciAdi=@g1 and Sifre=@g2",conn);
            komutgiris.Parameters.AddWithValue("@g1", textadmin.Text);
            komutgiris.Parameters.AddWithValue("@g2",textsifre.Text);
            SqlDataReader gr = komutgiris.ExecuteReader();
            
            if (gr.Read())
            {
                FormOgrOgrenci frm = new FormOgrOgrenci();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre yanlış.!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            temizle2();
            textadmin.Focus();
            conn.Close();
        }
    }
}
