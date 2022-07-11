namespace yillik_ucret_elektrik
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_guc_giris = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ucret_giris = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tablo_cikis = new System.Windows.Forms.DataGridView();
            this.radio_tarifeli = new System.Windows.Forms.RadioButton();
            this.radio_tarifesiz = new System.Windows.Forms.RadioButton();
            this.txt_tarife1_giris = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tarife2_giris = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tarife3_giris = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablo_cikis)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_guc_giris
            // 
            this.txt_guc_giris.Location = new System.Drawing.Point(232, 56);
            this.txt_guc_giris.Name = "txt_guc_giris";
            this.txt_guc_giris.Size = new System.Drawing.Size(125, 27);
            this.txt_guc_giris.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cihaz Gücü (kWh):";
            // 
            // txt_ucret_giris
            // 
            this.txt_ucret_giris.Location = new System.Drawing.Point(232, 108);
            this.txt_ucret_giris.Name = "txt_ucret_giris";
            this.txt_ucret_giris.Size = new System.Drawing.Size(125, 27);
            this.txt_ucret_giris.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enerji Ücreti (₺/kWh):";
            // 
            // tablo_cikis
            // 
            this.tablo_cikis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablo_cikis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablo_cikis.Location = new System.Drawing.Point(374, 12);
            this.tablo_cikis.Name = "tablo_cikis";
            this.tablo_cikis.RowHeadersWidth = 51;
            this.tablo_cikis.RowTemplate.Height = 29;
            this.tablo_cikis.Size = new System.Drawing.Size(404, 211);
            this.tablo_cikis.TabIndex = 2;
            // 
            // radio_tarifeli
            // 
            this.radio_tarifeli.AutoSize = true;
            this.radio_tarifeli.Location = new System.Drawing.Point(55, 12);
            this.radio_tarifeli.Name = "radio_tarifeli";
            this.radio_tarifeli.Size = new System.Drawing.Size(74, 24);
            this.radio_tarifeli.TabIndex = 3;
            this.radio_tarifeli.Text = "Tarifeli";
            this.radio_tarifeli.UseVisualStyleBackColor = true;
            this.radio_tarifeli.CheckedChanged += new System.EventHandler(this.radio_tarifeli_CheckedChanged);
            // 
            // radio_tarifesiz
            // 
            this.radio_tarifesiz.AutoSize = true;
            this.radio_tarifesiz.Checked = true;
            this.radio_tarifesiz.Location = new System.Drawing.Point(135, 12);
            this.radio_tarifesiz.Name = "radio_tarifesiz";
            this.radio_tarifesiz.Size = new System.Drawing.Size(83, 24);
            this.radio_tarifesiz.TabIndex = 3;
            this.radio_tarifesiz.TabStop = true;
            this.radio_tarifesiz.Text = "Tarifesiz";
            this.radio_tarifesiz.UseVisualStyleBackColor = true;
            this.radio_tarifesiz.CheckedChanged += new System.EventHandler(this.radio_tarifesiz_CheckedChanged);
            // 
            // txt_tarife1_giris
            // 
            this.txt_tarife1_giris.Location = new System.Drawing.Point(232, 108);
            this.txt_tarife1_giris.Name = "txt_tarife1_giris";
            this.txt_tarife1_giris.Size = new System.Drawing.Size(125, 27);
            this.txt_tarife1_giris.TabIndex = 0;
            this.txt_tarife1_giris.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tarife 1 Ücret (₺/kWh):";
            this.label3.Visible = false;
            // 
            // txt_tarife2_giris
            // 
            this.txt_tarife2_giris.Location = new System.Drawing.Point(232, 153);
            this.txt_tarife2_giris.Name = "txt_tarife2_giris";
            this.txt_tarife2_giris.Size = new System.Drawing.Size(125, 27);
            this.txt_tarife2_giris.TabIndex = 0;
            this.txt_tarife2_giris.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tarife 2 Ücret (₺/kWh):";
            this.label4.Visible = false;
            // 
            // txt_tarife3_giris
            // 
            this.txt_tarife3_giris.Location = new System.Drawing.Point(232, 196);
            this.txt_tarife3_giris.Name = "txt_tarife3_giris";
            this.txt_tarife3_giris.Size = new System.Drawing.Size(125, 27);
            this.txt_tarife3_giris.TabIndex = 0;
            this.txt_tarife3_giris.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tarife 3 Ücret (₺/kWh):";
            this.label5.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 249);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radio_tarifesiz);
            this.Controls.Add(this.radio_tarifeli);
            this.Controls.Add(this.tablo_cikis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tarife3_giris);
            this.Controls.Add(this.txt_ucret_giris);
            this.Controls.Add(this.txt_tarife2_giris);
            this.Controls.Add(this.txt_tarife1_giris);
            this.Controls.Add(this.txt_guc_giris);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablo_cikis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_guc_giris;
        private Label label1;
        private TextBox txt_ucret_giris;
        private Label label2;
        private DataGridView tablo_cikis;
        private RadioButton radio_tarifeli;
        private RadioButton radio_tarifesiz;
        private TextBox txt_tarife1_giris;
        private Label label3;
        private TextBox txt_tarife2_giris;
        private Label label4;
        private TextBox txt_tarife3_giris;
        private Label label5;
        private Button button1;
    }
}