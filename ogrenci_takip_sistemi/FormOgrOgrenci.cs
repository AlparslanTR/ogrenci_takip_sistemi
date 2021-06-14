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
    public partial class FormOgrOgrenci : Form
    {
       
        public FormOgrOgrenci()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();


        void temizle() // Temizle butonu için sınıf kullandım
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            textBox7.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox1.Text = "";
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ogrenci_takipDataSet17.Tbl_ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_ogrenciTableAdapter14.Fill(this.ogrenci_takipDataSet17.Tbl_ogrenci);
            // TODO: Bu kod satırı 'ogrenci_takipDataSet16.Tbl_ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_ogrenciTableAdapter14.Fill(this.ogrenci_takipDataSet17.Tbl_ogrenci);
            // TODO: Bu kod satırı 'ogrenci_takipDataSet14.Tbl_ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_ogrenciTableAdapter12.Fill(this.ogrenci_takipDataSet14.Tbl_ogrenci);
            
            

            textBox1.Focus(); // Program Açıldığındaki ilk fokus ayarı
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            this.tbl_ogrenciTableAdapter14.Fill(this.ogrenci_takipDataSet17.Tbl_ogrenci);
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            SqlCommand komutekle = new SqlCommand("insert into Tbl_ogrenci (Numara, Ad, Soyad, Sehir, DogumTarihi, Sınıf, Anne, Baba, Tel, TC, cinsiyet) values(@e1,@e2,@e3,@e4,@e5,@e6,@e7,@e8,@e9,@e10,@e11)", conn);
            komutekle.Parameters.AddWithValue("@e1", textBox1.Text);
            komutekle.Parameters.AddWithValue("@e2", textBox2.Text);
            komutekle.Parameters.AddWithValue("@e3", textBox3.Text);
            komutekle.Parameters.AddWithValue("@e4", comboBox1.Text);
            komutekle.Parameters.AddWithValue("@e5", textBox7.Text);
            komutekle.Parameters.AddWithValue("@e6", textBox4.Text);
            komutekle.Parameters.AddWithValue("@e7", textBox5.Text);
            komutekle.Parameters.AddWithValue("@e8", textBox6.Text);
            komutekle.Parameters.AddWithValue("@e9", maskedTextBox2.Text);
            komutekle.Parameters.AddWithValue("@e10", maskedTextBox1.Text);
            komutekle.Parameters.AddWithValue("@e11", label12.Text);
            komutekle.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Öğrenci eklendi, yenile tuşuna basmayı unutmayınız.!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            SqlCommand komutsil = new SqlCommand("Delete from Tbl_ogrenci where numara=@s1", conn);
            komutsil.Parameters.AddWithValue("@s1", textBox1.Text);
            komutsil.Parameters.AddWithValue("@s2", textBox2.Text);
            komutsil.Parameters.AddWithValue("@s3", textBox3.Text);
            komutsil.Parameters.AddWithValue("@s4", comboBox1.Text);
            komutsil.Parameters.AddWithValue("@s5", textBox7.Text);
            komutsil.Parameters.AddWithValue("@s6", textBox4.Text);
            komutsil.Parameters.AddWithValue("@s7", textBox5.Text);
            komutsil.Parameters.AddWithValue("@s8", textBox6.Text);
            komutsil.Parameters.AddWithValue("@s9", maskedTextBox2.Text);
            komutsil.Parameters.AddWithValue("@s10", maskedTextBox1.Text);
            komutsil.Parameters.AddWithValue("@s11", label12.Text);

            komutsil.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Öğrenci silindi, yenile tuşuna basmayı unutmayınız.!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) // Kayıtlardaki öğrencilere çift tıklandığında kayıt formuna verileri aktarır.
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox7.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            textBox6.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            maskedTextBox2.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            label12.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
            textBox1.Focus();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_ogrenci set ad=@g1,soyad=@g2,sehir=@g3,dogumtarihi=@g4,sınıf=@g5,anne=@g6,baba=@g7,tel=@g8,TC=@g9,cinsiyet=@g10 where numara=@g11",conn);

            komutguncelle.Parameters.AddWithValue("@g1", textBox2.Text);
            komutguncelle.Parameters.AddWithValue("@g2", textBox3.Text);
            komutguncelle.Parameters.AddWithValue("@g3", comboBox1.Text);
            komutguncelle.Parameters.AddWithValue("@g4", textBox7.Text);
            komutguncelle.Parameters.AddWithValue("@g5", textBox4.Text);
            komutguncelle.Parameters.AddWithValue("@g6", textBox5.Text);
            komutguncelle.Parameters.AddWithValue("@g7", textBox6.Text);
            komutguncelle.Parameters.AddWithValue("@g8", maskedTextBox2.Text);
            komutguncelle.Parameters.AddWithValue("@g9", maskedTextBox1.Text);
            komutguncelle.Parameters.AddWithValue("@g10", label12.Text);
            komutguncelle.Parameters.AddWithValue("@g11", textBox1.Text);

            komutguncelle.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Öğrenci güncellendi, yenile tuşuna basmayı unutmayınız.!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                label12.Text = "ERKEK";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked==true)
            {
                label12.Text = "KIZ";
            }
        }

        private void label12_TextChanged(object sender, EventArgs e)
        {
            if (label12.Text=="ERKEK")
            {
                radioButton1.Checked = true;
            }
            if (label12.Text=="KIZ")
            {
                radioButton2.Checked = true;
            }
        }

        private void Btngrafik_Click(object sender, EventArgs e)
        {
            grafik gr = new grafik();
            gr.Show();

           
        }

        private void Btnara_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            SqlCommand ara = new SqlCommand("Select * From Tbl_ogrenci Where Ad like '%" + textara.Text + "%'", conn);
            SqlDataAdapter ar = new SqlDataAdapter(ara);
            DataSet ds = new DataSet();
            ar.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void BtnDuyuruYap_Click(object sender, EventArgs e)
        {
            FormDuyuru fr5 = new FormDuyuru();
            fr5.Show();
            
            
        }

        private void BtnÇıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
