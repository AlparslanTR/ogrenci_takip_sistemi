using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace ogrenci_takip_sistemi
{
    public partial class FormOgrenciPaneli : Form
    {
        public FormOgrenciPaneli()
        {
            InitializeComponent();
        }
        public string TC, NO;
        baglanti bgl = new baglanti();

        private void googleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com.tr");
        }

        private void youtubeAnaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.youtube.com.tr");
        }

        private void canlıRapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=-fWAlXBXG1k");
        }

        private void canlıSlowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=oEfPse8H2p4");
        }

        private void canlıPopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=KG8tvdGvpmc");
        }

        private void canlıYabancıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=IF70iqaTiRY");
        }

        private void facebookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.facebook.com/");
        }

        private void twitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://twitter.com/home?lang=tr");
        }

        private void ınstagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.instagram.com/");
        }

        private void notHesaplaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://lise-ortalama.hesaplama.net/");
        }

        private void wikipediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://tr.wikipedia.org/wiki/Anasayfa");
        }

        private void ekşiSözlükToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://eksisozluk.com/");
        }

        private void FormOgrenciPaneli_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ogrenci_takipDataSet13.Tbl_Duyurular' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_DuyurularTableAdapter.Fill(this.ogrenci_takipDataSet13.Tbl_Duyurular);
            // TODO: Bu kod satırı 'ogrenci_takipDataSet12.Tbl_Dersler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_DerslerTableAdapter.Fill(this.ogrenci_takipDataSet12.Tbl_Dersler);



            label3.Text = TC;
            label4.Text = NO;

            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            SqlCommand adgetir = new SqlCommand("Select Ad from Tbl_ogrenci Where TC=@a1", conn);
            adgetir.Parameters.AddWithValue("@a1", label3.Text);
            SqlDataReader ad = adgetir.ExecuteReader();
            while (ad.Read())
            {
                label6.Text = (string)ad[0];
            }
            conn.Close();

            conn.Open();
            SqlCommand soyad = new SqlCommand("Select Soyad From Tbl_ogrenci Where TC=@a1", conn);
            soyad.Parameters.AddWithValue("@a1", label3.Text);
            SqlDataReader so = soyad.ExecuteReader();
            while (so.Read())
            {
                label8.Text = (string)so[0];
            }
            conn.Close();
        }
    }
}
