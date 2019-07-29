using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ProlabOdev
{
    public partial class Form1 : Form
    {
        ArrayList AryIller = new ArrayList();
        ArrayList AryIller2 = new ArrayList();
        ArrayList AryEnlem = new ArrayList();
        ArrayList AryBoylam = new ArrayList();
        ArrayList AryRakim = new ArrayList();
        ArrayList AryKomsu = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KoordinatCek();
            KomsuBul();
            Cmbİller.DataSource = AryIller;
            CmbGidilecekIl.DataSource = AryIller2;
            PctTR.Image = Properties.Resources.harita;
        }

        private void KomsuBul()
        {
            string[] komsu = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "komşuluk.txt");
            foreach (string ilkomsu in komsu) {
                AryKomsu.Add(ilkomsu.Split('>')[1].Trim());
            }
        }

        private void KoordinatCek()
        {
            string[] ilyol = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "İl Koordinatları.txt");
            foreach (string il in ilyol)
            {
                AryIller.Add(il.Split(' ')[0]);
                AryIller2.Add(il.Split(' ')[0]);
                AryEnlem.Add(il.Split(' ')[1]);
                AryBoylam.Add(il.Split(' ')[2]);
                AryRakim.Add(il.Split(' ')[3]);
            }
        }

        private void Cmbİller_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtEnlem.Text = AryEnlem[Cmbİller.SelectedIndex].ToString();
            TxtBoylam.Text = AryBoylam[Cmbİller.SelectedIndex].ToString();
            TxtRakim.Text = AryRakim[Cmbİller.SelectedIndex].ToString();
            try
            {
                double EnlemFark = Math.Abs(Convert.ToDouble(TxtEnlem.Text) - Convert.ToDouble(TxtGidilecekEnlem.Text));
                double BoylamFark = Math.Abs(Convert.ToDouble(TxtBoylam.Text) - Convert.ToDouble(TxtGidilecekBoylam.Text));
                double EnlemBoylamUs = Math.Pow(EnlemFark, 2) + Math.Pow(BoylamFark, 2);
                double KaraKok = Math.Sqrt(EnlemBoylamUs);

                TxtFark.Text = KaraKok.ToString();

                int RakımFark = Math.Abs(Convert.ToInt32(TxtRakim.Text) - Convert.ToInt32(TxtGidilecekRakim.Text));
                TxtRakimFark.Text = RakımFark.ToString();

                LblKomşu.Text = AryKomsu[Cmbİller.SelectedIndex].ToString();
            }
            catch { }
        }

        private void CmbGidilecekIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtGidilecekEnlem.Text = AryEnlem[CmbGidilecekIl.SelectedIndex].ToString();
            TxtGidilecekBoylam.Text = AryBoylam[CmbGidilecekIl.SelectedIndex].ToString();
            TxtGidilecekRakim.Text = AryRakim[CmbGidilecekIl.SelectedIndex].ToString();
            try
            {
                double EnlemFark = Math.Abs(Convert.ToDouble(TxtEnlem.Text) - Convert.ToDouble(TxtGidilecekEnlem.Text));
                double BoylamFark = Math.Abs(Convert.ToDouble(TxtBoylam.Text) - Convert.ToDouble(TxtGidilecekBoylam.Text));
                double EnlemBoylamUs = Math.Pow(EnlemFark, 2) + Math.Pow(BoylamFark, 2);
                double KaraKok = Math.Sqrt(EnlemBoylamUs);

                TxtFark.Text = KaraKok.ToString();

                int RakımFark = Math.Abs(Convert.ToInt32(TxtRakim.Text) - Convert.ToInt32(TxtGidilecekRakim.Text));
                TxtRakimFark.Text = RakımFark.ToString();
            }
            catch { }
        }

        private void BtnAsama2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
