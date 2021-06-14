
namespace ogrenci_takip_sistemi
{
    partial class FormOgretmenGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOgretmenGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textadmin = new System.Windows.Forms.TextBox();
            this.textsifre = new System.Windows.Forms.TextBox();
            this.textgiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // textadmin
            // 
            this.textadmin.Location = new System.Drawing.Point(136, 54);
            this.textadmin.Name = "textadmin";
            this.textadmin.Size = new System.Drawing.Size(159, 31);
            this.textadmin.TabIndex = 1;
            // 
            // textsifre
            // 
            this.textsifre.Location = new System.Drawing.Point(136, 113);
            this.textsifre.Name = "textsifre";
            this.textsifre.Size = new System.Drawing.Size(159, 31);
            this.textsifre.TabIndex = 2;
            this.textsifre.UseSystemPasswordChar = true;
            // 
            // textgiris
            // 
            this.textgiris.Location = new System.Drawing.Point(161, 165);
            this.textgiris.Name = "textgiris";
            this.textgiris.Size = new System.Drawing.Size(134, 36);
            this.textgiris.TabIndex = 4;
            this.textgiris.Text = "GİRİŞ";
            this.textgiris.UseVisualStyleBackColor = true;
            this.textgiris.Click += new System.EventHandler(this.textgiris_Click);
            // 
            // FormOgretmenGiris
            // 
            this.AcceptButton = this.textgiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(338, 202);
            this.Controls.Add(this.textgiris);
            this.Controls.Add(this.textsifre);
            this.Controls.Add(this.textadmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "FormOgretmenGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğretmen Giriş Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textadmin;
        private System.Windows.Forms.TextBox textsifre;
        private System.Windows.Forms.Button textgiris;
    }
}