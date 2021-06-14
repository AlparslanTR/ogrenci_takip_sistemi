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
    public partial class FormDuyuru : Form
    {
        public FormDuyuru()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            SqlCommand duyuru = new SqlCommand("Insert into Tbl_Duyurular (Duyurular)values (@d1)",conn);
            duyuru.Parameters.AddWithValue("@d1", richTextBox1.Text);
            duyuru.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Duyuru Öğrencilere İletilmiştir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
