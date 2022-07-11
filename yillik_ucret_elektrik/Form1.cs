namespace yillik_ucret_elektrik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tablo_cikis.Columns.Add("günlük_ucret", "Günlük Ücreti");
            tablo_cikis.Columns.Add("aylik_ucret", "Aylýk Ücreti");
            tablo_cikis.Columns.Add("yillik_ucret", "Yýllýk Ücreti");
        }


        private void radio_tarifeli_CheckedChanged(object sender, EventArgs e)
        {
            arayuz();
        }

        private void radio_tarifesiz_CheckedChanged(object sender, EventArgs e)
        {
            arayuz();
        }
        private void arayuz()
        {
            label2.Visible = radio_tarifesiz.Checked;
            txt_ucret_giris.Visible = radio_tarifesiz.Checked;

            label3.Visible = radio_tarifeli.Checked;
            txt_tarife1_giris.Visible = radio_tarifeli.Checked;

            label4.Visible = radio_tarifeli.Checked;
            txt_tarife2_giris.Visible = radio_tarifeli.Checked;

            label5.Visible = radio_tarifeli.Checked;
            txt_tarife3_giris.Visible = radio_tarifeli.Checked;
        }

        private float hesapla()
        {
            float toplam_gunluk = 0;
            if (radio_tarifeli.Checked)
            {
                toplam_gunluk = (float.Parse(txt_tarife1_giris.Text) * float.Parse(txt_guc_giris.Text) * 11) +
                (float.Parse(txt_tarife2_giris.Text) * float.Parse(txt_guc_giris.Text) * 5) +
                (float.Parse(txt_tarife3_giris.Text) * float.Parse(txt_guc_giris.Text) * 8);
            }
            else
            {
                toplam_gunluk = float.Parse(txt_ucret_giris.Text) * float.Parse(txt_guc_giris.Text) * 24;

            }
            return toplam_gunluk;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            tablo_cikis.Rows.Add(hesapla(), hesapla() * 30, hesapla() * 365);
        }
    }
}