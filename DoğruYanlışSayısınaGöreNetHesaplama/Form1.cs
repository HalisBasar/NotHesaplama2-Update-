using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoğruYanlışSayısınaGöreNetHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            double turkceDogru, turkceYanlis, turkceNet;
            double matDogru, matYanlis, matNet;
            double fizDogru, fizYanlis, fizNet;
            double KimyaDogru, KimyaYanlis, KimyaNet;
            double TrhDogru, TrhYanlis, TrhNet;
            //
            turkceDogru = Convert.ToDouble(txtTurkceDogru.Text);
            turkceYanlis = Convert.ToDouble(txtTurkceYanlis.Text);
            //
            matDogru = Convert.ToDouble(txtMatDogru.Text);
            matYanlis = Convert.ToDouble(txtMatYanlis.Text);
            //
            fizDogru = Convert.ToDouble(txtFizDogru.Text);
            fizYanlis = Convert.ToDouble(txtFizYanlis.Text);
            //
            KimyaDogru = Convert.ToDouble(txtKimyaDogru.Text);
            KimyaYanlis = Convert.ToDouble(txtKimyaYanlis.Text);
            //
            TrhDogru = Convert.ToDouble(txtTrhDogru.Text);
            TrhYanlis = Convert.ToDouble(txtTrhYanlis.Text);
            //
            turkceNet = turkceDogru - (turkceYanlis / 4);
            matNet = matDogru - (matYanlis / 4);
            fizNet = fizDogru - (fizYanlis / 4);
            KimyaNet = KimyaDogru - (KimyaYanlis / 4);
            TrhNet = TrhDogru - (TrhYanlis / 4);
            //
            txtTurkceNet.Text = turkceNet.ToString();
            txtTrhNet.Text = matNet.ToString();
            txtFizNet.Text = fizNet.ToString();
            txtKimyaNet.Text = KimyaNet.ToString();
            txtMatNet.Text = matNet.ToString();
        }

        private void Btntemizle_Click(object sender, EventArgs e)
        {
            // TextBox'a Girilen herşeyi silen kod satırları. 
            txtTurkceDogru.Clear();
            txtTurkceYanlis.Clear();
            txtTurkceNet.Clear();
            //
            txtTrhYanlis.Clear();
            txtTrhDogru.Clear();
            txtTrhNet.Clear();
            //
            txtFizDogru.Clear();
            txtFizYanlis.Clear();
            txtFizNet.Clear();
            //
            txtMatDogru.Clear();
            txtMatYanlis.Clear();
            txtMatNet.Clear();
            //
            txtKimyaDogru.Clear();
            txtKimyaYanlis.Clear();
            txtKimyaNet.Clear();

        }
        // Harf Girilememesi için verilen Komut.
        private void txtTurkceDogru_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyText(sender, e);
        }
        private static void OnlyText(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        public static void Run(ApplicationContext context)
        {
            if (context is null)
            {
                throw new ArgumentNullException(nameof(context));
            }
        }

        private void txtTrhDogru_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyText(sender, e);
        }
        private void txtFizDogru_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyText(sender, e);
        }
        private void txtTurkceYanlis_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyText(sender, e);
        }
        private void txtTrhYanlis_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyText(sender, e);
        }
        private void txtFizYanlis_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyText(sender, e);
        }
        private void txtKimyaDogru_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyText(sender, e);
        }
        private void txtKimyaYanlis_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyText(sender, e);
        }
        private void txtMatDogru_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyText(sender, e);
        }
        private void txtMatYanlis_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyText(sender, e);
        }
        private void btnKapat_Click(object sender, EventArgs e)

        {
            DialogResult Cikis;
            Cikis = MessageBox.Show("Programı Kapatmak İstermisiniz?", "Kapanma Uyarısı!", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                MessageBox.Show("İyi Günler!");
                Application.Exit();
            }
            if (Cikis == DialogResult.No)
            {
                return;
            }
        }
        // Arka Plan Rengini Değiştirir.
        private void btnKırmızı_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
        private void btnMavi_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }
        private void btnYesil_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }
        private void btnSari_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }
        private void btnMor_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
        }
        private void btnKahverengi_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Brown;

        }

        private void btnRenktmz_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }
    }
}