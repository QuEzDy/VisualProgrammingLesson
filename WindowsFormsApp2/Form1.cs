using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

      

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btntamam_click(object sender, EventArgs e)
        {
            {
                KontrolEt(txtadı, "Ad");
                KontrolEt(txtsoyadı, "Soyad");
                KontrolEt(txtsehir, "Şehir");
                KontrolEt(txtŞifre, "Şifre");

                if (!txttelefon.MaskCompleted)
                    errorProvider1.SetError(txttelefon, "Geçerli bir telefon giriniz");
                else
                    errorProvider1.SetError(txttelefon, "");

                if (!lnkSözleşme.LinkVisited)
                {
                    MessageBox.Show("Lüften sözleşme metnini okuyunuz");
                }

                string bilgi =
                    $"Ad: {txtadı.Text}\n" +
                    $"Soyad: {txtsoyadı.Text}\n" +
                    $"Doğum Tarihi: {dttarih.Value.ToShortDateString()}\n" +
                    $"Kilo:{nmkilo.Value}\n" +
                    $"";

                MessageBox.Show(bilgi, "Kayıt Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SözleşmeKabul(object sender, EventArgs e)
        {
            btnTamam.Enabled = chSözleşme.Checked;

        }

        private void SözleşmeMetniOku(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkSözleşme.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.mevzuat.gov.tr/mevzuat?MevzuatNo=4735&MevzuatTur=1&MevzuatTertip=5");
        }


        private void KontrolEt(TextBox txt, string v)
        {
            if (txt.Text == "")
            {
                errorProvider1.SetError(txt, $"{v} boş bırakılamaz");
                txt.Focus();
                return;
            }
            else
                errorProvider1.SetError(txt, "");

        }
    }
}
