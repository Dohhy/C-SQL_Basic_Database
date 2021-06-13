
namespace Veri_Tabani_Odev
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.polikliniksilbutonu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.hastaidlabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hastalartablosu = new System.Windows.Forms.DataGridView();
            this.randevuolusturbutonu = new System.Windows.Forms.Button();
            this.randevuiptalbutonu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.hastaneidlabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hastanelertablosu = new System.Windows.Forms.DataGridView();
            this.hastanelistelebutonu = new System.Windows.Forms.Button();
            this.hastaneguncellebutonu = new System.Windows.Forms.Button();
            this.hastanesil = new System.Windows.Forms.Button();
            this.hastanekaydetbutonu = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.polikliniklistelebutonu = new System.Windows.Forms.Button();
            this.poliklinikguncellebutonu = new System.Windows.Forms.Button();
            this.polikliniksilbuton = new System.Windows.Forms.Button();
            this.poliklinikkaydetbutonu = new System.Windows.Forms.Button();
            this.poliklinikidlabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.polikliniklertablosu = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.polikliniksilbutonu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastalartablosu)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastanelertablosu)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polikliniklertablosu)).BeginInit();
            this.SuspendLayout();
            // 
            // polikliniksilbutonu
            // 
            this.polikliniksilbutonu.Controls.Add(this.tabPage1);
            this.polikliniksilbutonu.Controls.Add(this.tabPage2);
            this.polikliniksilbutonu.Controls.Add(this.tabPage3);
            this.polikliniksilbutonu.Location = new System.Drawing.Point(13, 13);
            this.polikliniksilbutonu.Name = "polikliniksilbutonu";
            this.polikliniksilbutonu.SelectedIndex = 0;
            this.polikliniksilbutonu.Size = new System.Drawing.Size(741, 572);
            this.polikliniksilbutonu.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.hastaidlabel);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.hastalartablosu);
            this.tabPage1.Controls.Add(this.randevuolusturbutonu);
            this.tabPage1.Controls.Add(this.randevuiptalbutonu);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(733, 543);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hasta Kayıt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(7, 136);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(246, 24);
            this.comboBox2.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(246, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // hastaidlabel
            // 
            this.hastaidlabel.AutoSize = true;
            this.hastaidlabel.Location = new System.Drawing.Point(325, 23);
            this.hastaidlabel.Name = "hastaidlabel";
            this.hastaidlabel.Size = new System.Drawing.Size(0, 17);
            this.hastaidlabel.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hasta id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Poliklinik Seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hastane Seçiniz";
            // 
            // hastalartablosu
            // 
            this.hastalartablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hastalartablosu.Location = new System.Drawing.Point(259, 43);
            this.hastalartablosu.Name = "hastalartablosu";
            this.hastalartablosu.RowHeadersWidth = 51;
            this.hastalartablosu.RowTemplate.Height = 24;
            this.hastalartablosu.Size = new System.Drawing.Size(468, 390);
            this.hastalartablosu.TabIndex = 4;
            this.hastalartablosu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hastalartablosu_CellDoubleClick);
            // 
            // randevuolusturbutonu
            // 
            this.randevuolusturbutonu.Location = new System.Drawing.Point(6, 180);
            this.randevuolusturbutonu.Name = "randevuolusturbutonu";
            this.randevuolusturbutonu.Size = new System.Drawing.Size(115, 47);
            this.randevuolusturbutonu.TabIndex = 3;
            this.randevuolusturbutonu.Text = "Randevu Oluştur";
            this.randevuolusturbutonu.UseVisualStyleBackColor = true;
            this.randevuolusturbutonu.Click += new System.EventHandler(this.randevuolusturbutonu_Click);
            // 
            // randevuiptalbutonu
            // 
            this.randevuiptalbutonu.Location = new System.Drawing.Point(138, 180);
            this.randevuiptalbutonu.Name = "randevuiptalbutonu";
            this.randevuiptalbutonu.Size = new System.Drawing.Size(115, 47);
            this.randevuiptalbutonu.TabIndex = 2;
            this.randevuiptalbutonu.Text = "Randevuyu İptal Et";
            this.randevuiptalbutonu.UseVisualStyleBackColor = true;
            this.randevuiptalbutonu.Click += new System.EventHandler(this.randevuiptalbutonu_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Ad Soyad";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.hastaneidlabel);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.hastanelertablosu);
            this.tabPage2.Controls.Add(this.hastanelistelebutonu);
            this.tabPage2.Controls.Add(this.hastaneguncellebutonu);
            this.tabPage2.Controls.Add(this.hastanesil);
            this.tabPage2.Controls.Add(this.hastanekaydetbutonu);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(733, 543);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hastaneler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // hastaneidlabel
            // 
            this.hastaneidlabel.AutoSize = true;
            this.hastaneidlabel.Location = new System.Drawing.Point(104, 128);
            this.hastaneidlabel.Name = "hastaneidlabel";
            this.hastaneidlabel.Size = new System.Drawing.Size(0, 17);
            this.hastaneidlabel.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Hastane id";
            // 
            // hastanelertablosu
            // 
            this.hastanelertablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hastanelertablosu.Location = new System.Drawing.Point(25, 148);
            this.hastanelertablosu.Name = "hastanelertablosu";
            this.hastanelertablosu.RowHeadersWidth = 51;
            this.hastanelertablosu.RowTemplate.Height = 24;
            this.hastanelertablosu.Size = new System.Drawing.Size(462, 389);
            this.hastanelertablosu.TabIndex = 6;
            this.hastanelertablosu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hastanelertablosu_CellDoubleClick);
            // 
            // hastanelistelebutonu
            // 
            this.hastanelistelebutonu.Location = new System.Drawing.Point(376, 96);
            this.hastanelistelebutonu.Name = "hastanelistelebutonu";
            this.hastanelistelebutonu.Size = new System.Drawing.Size(111, 46);
            this.hastanelistelebutonu.TabIndex = 5;
            this.hastanelistelebutonu.Text = "Listele";
            this.hastanelistelebutonu.UseVisualStyleBackColor = true;
            this.hastanelistelebutonu.Click += new System.EventHandler(this.hastanelistelebutonu_Click);
            // 
            // hastaneguncellebutonu
            // 
            this.hastaneguncellebutonu.Location = new System.Drawing.Point(259, 96);
            this.hastaneguncellebutonu.Name = "hastaneguncellebutonu";
            this.hastaneguncellebutonu.Size = new System.Drawing.Size(111, 46);
            this.hastaneguncellebutonu.TabIndex = 4;
            this.hastaneguncellebutonu.Text = "Güncelle";
            this.hastaneguncellebutonu.UseVisualStyleBackColor = true;
            this.hastaneguncellebutonu.Click += new System.EventHandler(this.hastaneguncellebutonu_Click);
            // 
            // hastanesil
            // 
            this.hastanesil.Location = new System.Drawing.Point(376, 44);
            this.hastanesil.Name = "hastanesil";
            this.hastanesil.Size = new System.Drawing.Size(111, 46);
            this.hastanesil.TabIndex = 3;
            this.hastanesil.Text = "Sil";
            this.hastanesil.UseVisualStyleBackColor = true;
            this.hastanesil.Click += new System.EventHandler(this.hastanesil_Click);
            // 
            // hastanekaydetbutonu
            // 
            this.hastanekaydetbutonu.Location = new System.Drawing.Point(259, 44);
            this.hastanekaydetbutonu.Name = "hastanekaydetbutonu";
            this.hastanekaydetbutonu.Size = new System.Drawing.Size(111, 46);
            this.hastanekaydetbutonu.TabIndex = 2;
            this.hastanekaydetbutonu.Text = "Kaydet";
            this.hastanekaydetbutonu.UseVisualStyleBackColor = true;
            this.hastanekaydetbutonu.Click += new System.EventHandler(this.hastanekaydetbutonu_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(25, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 22);
            this.textBox2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hastane Adı";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.polikliniklistelebutonu);
            this.tabPage3.Controls.Add(this.poliklinikguncellebutonu);
            this.tabPage3.Controls.Add(this.polikliniksilbuton);
            this.tabPage3.Controls.Add(this.poliklinikkaydetbutonu);
            this.tabPage3.Controls.Add(this.poliklinikidlabel);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.polikliniklertablosu);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(733, 543);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Poliklinikler";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // polikliniklistelebutonu
            // 
            this.polikliniklistelebutonu.Location = new System.Drawing.Point(453, 70);
            this.polikliniklistelebutonu.Name = "polikliniklistelebutonu";
            this.polikliniklistelebutonu.Size = new System.Drawing.Size(117, 50);
            this.polikliniklistelebutonu.TabIndex = 8;
            this.polikliniklistelebutonu.Text = "Listele";
            this.polikliniklistelebutonu.UseVisualStyleBackColor = true;
            this.polikliniklistelebutonu.Click += new System.EventHandler(this.polikliniklistelebutonu_Click);
            // 
            // poliklinikguncellebutonu
            // 
            this.poliklinikguncellebutonu.Location = new System.Drawing.Point(330, 70);
            this.poliklinikguncellebutonu.Name = "poliklinikguncellebutonu";
            this.poliklinikguncellebutonu.Size = new System.Drawing.Size(117, 50);
            this.poliklinikguncellebutonu.TabIndex = 7;
            this.poliklinikguncellebutonu.Text = "Güncelle";
            this.poliklinikguncellebutonu.UseVisualStyleBackColor = true;
            this.poliklinikguncellebutonu.Click += new System.EventHandler(this.poliklinikguncellebutonu_Click);
            // 
            // polikliniksilbuton
            // 
            this.polikliniksilbuton.Location = new System.Drawing.Point(453, 14);
            this.polikliniksilbuton.Name = "polikliniksilbuton";
            this.polikliniksilbuton.Size = new System.Drawing.Size(117, 50);
            this.polikliniksilbuton.TabIndex = 6;
            this.polikliniksilbuton.Text = "Sil";
            this.polikliniksilbuton.UseVisualStyleBackColor = true;
            this.polikliniksilbuton.Click += new System.EventHandler(this.polikliniksilbuton_Click);
            // 
            // poliklinikkaydetbutonu
            // 
            this.poliklinikkaydetbutonu.Location = new System.Drawing.Point(330, 14);
            this.poliklinikkaydetbutonu.Name = "poliklinikkaydetbutonu";
            this.poliklinikkaydetbutonu.Size = new System.Drawing.Size(117, 50);
            this.poliklinikkaydetbutonu.TabIndex = 5;
            this.poliklinikkaydetbutonu.Text = "Kaydet";
            this.poliklinikkaydetbutonu.UseVisualStyleBackColor = true;
            this.poliklinikkaydetbutonu.Click += new System.EventHandler(this.poliklinikkaydetbutonu_Click);
            // 
            // poliklinikidlabel
            // 
            this.poliklinikidlabel.AutoSize = true;
            this.poliklinikidlabel.Location = new System.Drawing.Point(110, 113);
            this.poliklinikidlabel.Name = "poliklinikidlabel";
            this.poliklinikidlabel.Size = new System.Drawing.Size(0, 17);
            this.poliklinikidlabel.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Poliklinik id";
            // 
            // polikliniklertablosu
            // 
            this.polikliniklertablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.polikliniklertablosu.Location = new System.Drawing.Point(30, 133);
            this.polikliniklertablosu.Name = "polikliniklertablosu";
            this.polikliniklertablosu.RowHeadersWidth = 51;
            this.polikliniklertablosu.RowTemplate.Height = 24;
            this.polikliniklertablosu.Size = new System.Drawing.Size(460, 407);
            this.polikliniklertablosu.TabIndex = 2;
            this.polikliniklertablosu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.polikliniklertablosu_CellDoubleClick);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(120, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(154, 22);
            this.textBox3.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Poliklinik Adı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 597);
            this.Controls.Add(this.polikliniksilbutonu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.polikliniksilbutonu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastalartablosu)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastanelertablosu)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polikliniklertablosu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl polikliniksilbutonu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView hastalartablosu;
        private System.Windows.Forms.Button randevuolusturbutonu;
        private System.Windows.Forms.Button randevuiptalbutonu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label hastaidlabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView hastanelertablosu;
        private System.Windows.Forms.Button hastanelistelebutonu;
        private System.Windows.Forms.Button hastaneguncellebutonu;
        private System.Windows.Forms.Button hastanesil;
        private System.Windows.Forms.Button hastanekaydetbutonu;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label hastaneidlabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button polikliniklistelebutonu;
        private System.Windows.Forms.Button poliklinikguncellebutonu;
        private System.Windows.Forms.Button poliklinikkaydetbutonu;
        private System.Windows.Forms.Label poliklinikidlabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView polikliniklertablosu;
        private System.Windows.Forms.Button polikliniksilbuton;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

