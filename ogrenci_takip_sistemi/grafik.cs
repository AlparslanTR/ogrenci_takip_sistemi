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
    public partial class grafik : Form
    {
        public grafik()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();
        private void grafik_Load(object sender, EventArgs e)
        {
            //TOPLAM ÖĞRENCİ SAYISI
            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            SqlCommand komutgrafik = new SqlCommand("Select count (*) from Tbl_ogrenci",conn);
            SqlDataReader gr1 = komutgrafik.ExecuteReader();

            while (gr1.Read())
            {
                label2.Text = gr1[0].ToString();
            }
            conn.Close();

            // TOPLAM ERKEK ÖĞRENCİ SAYISI
            conn.Open();
            SqlCommand komutgrafik2 = new SqlCommand("Select Count (*) from Tbl_ogrenci where Cinsiyet='ERKEK'", conn);
            SqlDataReader gr2 = komutgrafik2.ExecuteReader();

            while (gr2.Read())
            {
                label4.Text = gr2[0].ToString();
            }
            conn.Close();

            // TOPLAM KIZ ÖĞRENCİ SAYISI
            conn.Open();
            SqlCommand komutgrafik3 = new SqlCommand("Select Count (*) from Tbl_ogrenci where Cinsiyet='KIZ'", conn);
            SqlDataReader gr3 = komutgrafik3.ExecuteReader();

            while (gr3.Read())
            {
                label6.Text = gr3[0].ToString();
            }
            conn.Close();

        }
        

    }
}
