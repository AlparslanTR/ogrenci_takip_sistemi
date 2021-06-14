
namespace ogrenci_takip_sistemi
{
    partial class FormOgrenciPaneli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gOOGLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googlecomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yOUTUBEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youtubeAnaSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canlıRapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canlıSlowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canlıPopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canlıYabancıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fACEBOOKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facebookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tWETTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNSTAGRAMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ınstagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOTHESAPLAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notHesaplaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wİKİPEDİAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wikipediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eKŞİSÖZLÜKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekşiSözlükToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.derslerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDerslerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenci_takipDataSet12 = new ogrenci_takip_sistemi.ogrenci_takipDataSet12();
            this.tbl_DerslerTableAdapter = new ogrenci_takip_sistemi.ogrenci_takipDataSet12TableAdapters.Tbl_DerslerTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tblDuyurularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenci_takipDataSet13 = new ogrenci_takip_sistemi.ogrenci_takipDataSet13();
            this.tbl_DuyurularTableAdapter = new ogrenci_takip_sistemi.ogrenci_takipDataSet13TableAdapters.Tbl_DuyurularTableAdapter();
            this.duyurularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDerslerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenci_takipDataSet12)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDuyurularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenci_takipDataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 176);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(253, 29);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(144, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "null";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Öğrenci Soyad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "null ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Öğrenci Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrenci NO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci TC:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gOOGLEToolStripMenuItem,
            this.yOUTUBEToolStripMenuItem,
            this.fACEBOOKToolStripMenuItem,
            this.tWETTERToolStripMenuItem,
            this.iNSTAGRAMToolStripMenuItem,
            this.nOTHESAPLAToolStripMenuItem,
            this.wİKİPEDİAToolStripMenuItem,
            this.eKŞİSÖZLÜKToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1115, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gOOGLEToolStripMenuItem
            // 
            this.gOOGLEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.googlecomToolStripMenuItem});
            this.gOOGLEToolStripMenuItem.Name = "gOOGLEToolStripMenuItem";
            this.gOOGLEToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.gOOGLEToolStripMenuItem.Text = "GOOGLE";
            // 
            // googlecomToolStripMenuItem
            // 
            this.googlecomToolStripMenuItem.Name = "googlecomToolStripMenuItem";
            this.googlecomToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.googlecomToolStripMenuItem.Text = "Google";
            this.googlecomToolStripMenuItem.Click += new System.EventHandler(this.googleToolStripMenuItem_Click);
            // 
            // yOUTUBEToolStripMenuItem
            // 
            this.yOUTUBEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.youtubeAnaSayfaToolStripMenuItem,
            this.canlıRapToolStripMenuItem,
            this.canlıSlowToolStripMenuItem,
            this.canlıPopToolStripMenuItem,
            this.canlıYabancıToolStripMenuItem});
            this.yOUTUBEToolStripMenuItem.Name = "yOUTUBEToolStripMenuItem";
            this.yOUTUBEToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.yOUTUBEToolStripMenuItem.Text = "YOUTUBE";
            // 
            // youtubeAnaSayfaToolStripMenuItem
            // 
            this.youtubeAnaSayfaToolStripMenuItem.Name = "youtubeAnaSayfaToolStripMenuItem";
            this.youtubeAnaSayfaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.youtubeAnaSayfaToolStripMenuItem.Text = "Youtube Ana sayfa";
            this.youtubeAnaSayfaToolStripMenuItem.Click += new System.EventHandler(this.youtubeAnaSayfaToolStripMenuItem_Click);
            // 
            // canlıRapToolStripMenuItem
            // 
            this.canlıRapToolStripMenuItem.Name = "canlıRapToolStripMenuItem";
            this.canlıRapToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.canlıRapToolStripMenuItem.Text = "Canlı Rap";
            this.canlıRapToolStripMenuItem.Click += new System.EventHandler(this.canlıRapToolStripMenuItem_Click);
            // 
            // canlıSlowToolStripMenuItem
            // 
            this.canlıSlowToolStripMenuItem.Name = "canlıSlowToolStripMenuItem";
            this.canlıSlowToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.canlıSlowToolStripMenuItem.Text = "Canlı Slow";
            this.canlıSlowToolStripMenuItem.Click += new System.EventHandler(this.canlıSlowToolStripMenuItem_Click);
            // 
            // canlıPopToolStripMenuItem
            // 
            this.canlıPopToolStripMenuItem.Name = "canlıPopToolStripMenuItem";
            this.canlıPopToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.canlıPopToolStripMenuItem.Text = "Canlı Pop";
            this.canlıPopToolStripMenuItem.Click += new System.EventHandler(this.canlıPopToolStripMenuItem_Click);
            // 
            // canlıYabancıToolStripMenuItem
            // 
            this.canlıYabancıToolStripMenuItem.Name = "canlıYabancıToolStripMenuItem";
            this.canlıYabancıToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.canlıYabancıToolStripMenuItem.Text = "Canlı Yabancı";
            this.canlıYabancıToolStripMenuItem.Click += new System.EventHandler(this.canlıYabancıToolStripMenuItem_Click);
            // 
            // fACEBOOKToolStripMenuItem
            // 
            this.fACEBOOKToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facebookToolStripMenuItem1});
            this.fACEBOOKToolStripMenuItem.Name = "fACEBOOKToolStripMenuItem";
            this.fACEBOOKToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.fACEBOOKToolStripMenuItem.Text = "FACEBOOK";
            // 
            // facebookToolStripMenuItem1
            // 
            this.facebookToolStripMenuItem1.Name = "facebookToolStripMenuItem1";
            this.facebookToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.facebookToolStripMenuItem1.Text = "Facebook";
            this.facebookToolStripMenuItem1.Click += new System.EventHandler(this.facebookToolStripMenuItem1_Click);
            // 
            // tWETTERToolStripMenuItem
            // 
            this.tWETTERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.twitterToolStripMenuItem});
            this.tWETTERToolStripMenuItem.Name = "tWETTERToolStripMenuItem";
            this.tWETTERToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.tWETTERToolStripMenuItem.Text = "TWETTER";
            // 
            // twitterToolStripMenuItem
            // 
            this.twitterToolStripMenuItem.Name = "twitterToolStripMenuItem";
            this.twitterToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.twitterToolStripMenuItem.Text = "Twitter";
            this.twitterToolStripMenuItem.Click += new System.EventHandler(this.twitterToolStripMenuItem_Click);
            // 
            // iNSTAGRAMToolStripMenuItem
            // 
            this.iNSTAGRAMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ınstagramToolStripMenuItem});
            this.iNSTAGRAMToolStripMenuItem.Name = "iNSTAGRAMToolStripMenuItem";
            this.iNSTAGRAMToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.iNSTAGRAMToolStripMenuItem.Text = "İNSTAGRAM";
            // 
            // ınstagramToolStripMenuItem
            // 
            this.ınstagramToolStripMenuItem.Name = "ınstagramToolStripMenuItem";
            this.ınstagramToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.ınstagramToolStripMenuItem.Text = "Instagram";
            this.ınstagramToolStripMenuItem.Click += new System.EventHandler(this.ınstagramToolStripMenuItem_Click);
            // 
            // nOTHESAPLAToolStripMenuItem
            // 
            this.nOTHESAPLAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notHesaplaToolStripMenuItem1});
            this.nOTHESAPLAToolStripMenuItem.Name = "nOTHESAPLAToolStripMenuItem";
            this.nOTHESAPLAToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.nOTHESAPLAToolStripMenuItem.Text = "NOT HESAPLA";
            // 
            // notHesaplaToolStripMenuItem1
            // 
            this.notHesaplaToolStripMenuItem1.Name = "notHesaplaToolStripMenuItem1";
            this.notHesaplaToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.notHesaplaToolStripMenuItem1.Text = "Not Hesapla";
            this.notHesaplaToolStripMenuItem1.Click += new System.EventHandler(this.notHesaplaToolStripMenuItem1_Click);
            // 
            // wİKİPEDİAToolStripMenuItem
            // 
            this.wİKİPEDİAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wikipediaToolStripMenuItem});
            this.wİKİPEDİAToolStripMenuItem.Name = "wİKİPEDİAToolStripMenuItem";
            this.wİKİPEDİAToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.wİKİPEDİAToolStripMenuItem.Text = "WİKİPEDİA";
            // 
            // wikipediaToolStripMenuItem
            // 
            this.wikipediaToolStripMenuItem.Name = "wikipediaToolStripMenuItem";
            this.wikipediaToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.wikipediaToolStripMenuItem.Text = "Wikipedia";
            this.wikipediaToolStripMenuItem.Click += new System.EventHandler(this.wikipediaToolStripMenuItem_Click);
            // 
            // eKŞİSÖZLÜKToolStripMenuItem
            // 
            this.eKŞİSÖZLÜKToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekşiSözlükToolStripMenuItem});
            this.eKŞİSÖZLÜKToolStripMenuItem.Name = "eKŞİSÖZLÜKToolStripMenuItem";
            this.eKŞİSÖZLÜKToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.eKŞİSÖZLÜKToolStripMenuItem.Text = "EKŞİ SÖZLÜK";
            // 
            // ekşiSözlükToolStripMenuItem
            // 
            this.ekşiSözlükToolStripMenuItem.Name = "ekşiSözlükToolStripMenuItem";
            this.ekşiSözlükToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.ekşiSözlükToolStripMenuItem.Text = "Ekşi Sözlük";
            this.ekşiSözlükToolStripMenuItem.Click += new System.EventHandler(this.ekşiSözlükToolStripMenuItem_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(407, 28);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(708, 426);
            this.webBrowser1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(0, 447);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1115, 192);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ders Programı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tarihDataGridViewTextBoxColumn,
            this.saatDataGridViewTextBoxColumn,
            this.derslerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDerslerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1109, 164);
            this.dataGridView1.TabIndex = 0;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            // 
            // saatDataGridViewTextBoxColumn
            // 
            this.saatDataGridViewTextBoxColumn.DataPropertyName = "saat";
            this.saatDataGridViewTextBoxColumn.HeaderText = "saat";
            this.saatDataGridViewTextBoxColumn.Name = "saatDataGridViewTextBoxColumn";
            // 
            // derslerDataGridViewTextBoxColumn
            // 
            this.derslerDataGridViewTextBoxColumn.DataPropertyName = "dersler";
            this.derslerDataGridViewTextBoxColumn.HeaderText = "dersler";
            this.derslerDataGridViewTextBoxColumn.Name = "derslerDataGridViewTextBoxColumn";
            // 
            // tblDerslerBindingSource
            // 
            this.tblDerslerBindingSource.DataMember = "Tbl_Dersler";
            this.tblDerslerBindingSource.DataSource = this.ogrenci_takipDataSet12;
            // 
            // ogrenci_takipDataSet12
            // 
            this.ogrenci_takipDataSet12.DataSetName = "ogrenci_takipDataSet12";
            this.ogrenci_takipDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_DerslerTableAdapter
            // 
            this.tbl_DerslerTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(11, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 208);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DUYURULAR";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.duyurularDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblDuyurularBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(383, 180);
            this.dataGridView2.TabIndex = 0;
            // 
            // tblDuyurularBindingSource
            // 
            this.tblDuyurularBindingSource.DataMember = "Tbl_Duyurular";
            this.tblDuyurularBindingSource.DataSource = this.ogrenci_takipDataSet13;
            // 
            // ogrenci_takipDataSet13
            // 
            this.ogrenci_takipDataSet13.DataSetName = "ogrenci_takipDataSet13";
            this.ogrenci_takipDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_DuyurularTableAdapter
            // 
            this.tbl_DuyurularTableAdapter.ClearBeforeFill = true;
            // 
            // duyurularDataGridViewTextBoxColumn
            // 
            this.duyurularDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.duyurularDataGridViewTextBoxColumn.DataPropertyName = "Duyurular";
            this.duyurularDataGridViewTextBoxColumn.Frozen = true;
            this.duyurularDataGridViewTextBoxColumn.HeaderText = "Duyurular";
            this.duyurularDataGridViewTextBoxColumn.Name = "duyurularDataGridViewTextBoxColumn";
            this.duyurularDataGridViewTextBoxColumn.Width = 340;
            // 
            // FormOgrenciPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1115, 640);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FormOgrenciPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOgrenciPaneli";
            this.Load += new System.EventHandler(this.FormOgrenciPaneli_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDerslerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenci_takipDataSet12)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDuyurularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenci_takipDataSet13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gOOGLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googlecomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yOUTUBEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fACEBOOKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tWETTERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNSTAGRAMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOTHESAPLAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wİKİPEDİAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eKŞİSÖZLÜKToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripMenuItem youtubeAnaSayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canlıRapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canlıSlowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canlıPopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canlıYabancıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facebookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem twitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ınstagramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notHesaplaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wikipediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekşiSözlükToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ogrenci_takipDataSet12 ogrenci_takipDataSet12;
        private System.Windows.Forms.BindingSource tblDerslerBindingSource;
        private ogrenci_takipDataSet12TableAdapters.Tbl_DerslerTableAdapter tbl_DerslerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn derslerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private ogrenci_takipDataSet13 ogrenci_takipDataSet13;
        private System.Windows.Forms.BindingSource tblDuyurularBindingSource;
        private ogrenci_takipDataSet13TableAdapters.Tbl_DuyurularTableAdapter tbl_DuyurularTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn duyurularDataGridViewTextBoxColumn;
    }
}