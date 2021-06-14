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
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            FormOgretmenGiris fr = new FormOgretmenGiris();
            fr.Show();
            this.Hide();
        }

        private void BtnOgrenci_Click(object sender, EventArgs e)
        {
            FormOgrenciGiris fr2 = new FormOgrenciGiris();
            fr2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormMezunGiris fr3 = new FormMezunGiris();
            fr3.Show();
            this.Hide();
        }
    }
}
