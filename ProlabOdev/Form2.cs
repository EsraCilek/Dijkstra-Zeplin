using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProlabOdev
{
    public partial class Form2 : Form
    {
        ArrayList AryIller = new ArrayList(); //başlangıç ili 
        ArrayList AryIller2 = new ArrayList(); //gidilecek il
        ArrayList AryEnlem = new ArrayList();
        ArrayList AryBoylam = new ArrayList();
        ArrayList AryRakim = new ArrayList();
        ArrayList AryKomsu = new ArrayList();
        ArrayList AryKoordinat = new ArrayList();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(Properties.Resources.harita, Properties.Resources.harita.Width, Properties.Resources.harita.Height);
            KoordinatCek();
            KomsuBul();
            Cmbİller.DataSource = AryIller; //commoboxa başlangıç illeri ekleme
            CmbGidilecekIl.DataSource = AryIller2; //commoboxa gidilecek illeri ekleme
            MessageBox.Show("Minimum 5 Maximum 50 Yolcu Giriniz");

            //HaritaKoordinat();
            // Ciz(20, 20, 200, 200);
        }
        private void KoordinatCek()
        {
            string[] ilyol = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "İl Koordinatları.txt");
            foreach (string il in ilyol)// başlangıç ve gidilecek illerin enlemini boylamını rakımını bulma
            {
                AryIller.Add(il.Split(' ')[0]);
                AryIller2.Add(il.Split(' ')[0]);
                AryEnlem.Add(il.Split(' ')[1]);
                AryBoylam.Add(il.Split(' ')[2]);
                AryRakim.Add(il.Split(' ')[3]);
            }
        }


        private void KomsuBul()
        {
            string[] komsu = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "komşuluk.txt");
            foreach (string ilkomsu in komsu)
            {
                AryKomsu.Add(ilkomsu.Split('>')[1].Trim());// seçilen illerin komşusunu arrsyliste ekleme
            }
        }

      

      
        private void Cmbİller_SelectedIndexChanged(object sender, EventArgs e)//başlangıç ile gidilecek yol arasındaki mesafeyi hesaplama
        {
            TxtEnlem.Text = AryEnlem[Cmbİller.SelectedIndex].ToString();
            TxtBoylam.Text = AryBoylam[Cmbİller.SelectedIndex].ToString();
            TxtRakim.Text = AryRakim[Cmbİller.SelectedIndex].ToString();
            try
            {
                double EnlemFark = Math.Abs(Convert.ToDouble(TxtEnlem.Text) - Convert.ToDouble(TxtGidilecekEnlem.Text));
                double BoylamFark = Math.Abs(Convert.ToDouble(TxtBoylam.Text) - Convert.ToDouble(TxtGidilecekBoylam.Text));
                double EnlemBoylamUs = Math.Pow(EnlemFark, 2) + Math.Pow(BoylamFark, 2);
                double KaraKok = Math.Sqrt(EnlemBoylamUs) * 111;

                TxtFark.Text = KaraKok.ToString();

                int RakımFark = Math.Abs(Convert.ToInt32(TxtRakim.Text) - Convert.ToInt32(TxtGidilecekRakim.Text));
                TxtRakimFark.Text = RakımFark.ToString();
            }
            catch { }

        }

        private void CmbGidilecekIl_SelectedIndexChanged(object sender, EventArgs e)//aynı şekilde
        {
            TxtGidilecekEnlem.Text = AryEnlem[CmbGidilecekIl.SelectedIndex].ToString();
            TxtGidilecekBoylam.Text = AryBoylam[CmbGidilecekIl.SelectedIndex].ToString();
            TxtGidilecekRakim.Text = AryRakim[CmbGidilecekIl.SelectedIndex].ToString();
            try
            {
                double EnlemFark = Math.Abs(Convert.ToDouble(TxtEnlem.Text) - Convert.ToDouble(TxtGidilecekEnlem.Text));
                double BoylamFark = Math.Abs(Convert.ToDouble(TxtBoylam.Text) - Convert.ToDouble(TxtGidilecekBoylam.Text));
                double EnlemBoylamUs = Math.Pow(EnlemFark, 2) + Math.Pow(BoylamFark, 2);
                double KaraKok = Math.Sqrt(EnlemBoylamUs) * 111;

                TxtFark.Text = KaraKok.ToString();

                int RakımFark = Math.Abs(Convert.ToInt32(TxtRakim.Text) - Convert.ToInt32(TxtGidilecekRakim.Text));
                TxtRakimFark.Text = RakımFark.ToString();
            }
            catch { }
        }
        private void KomsuHesaplama() //yazdığımız algroritma kısmı(gidilecek ille başlangıç ilinin komşularından kendisine en yakın olanı bulup güzergaha ekliyoruz)
        {
            ArrayList AryKomsuFarklar = new ArrayList();
            ArrayList Komsular = new ArrayList();
            foreach (string i in AryKomsu[Cmbİller.SelectedIndex].ToString().Split(',').ToList())
            //komşular.txt dosyasından çektiğimşz bir ilin komşularını ayırıp komşular arraylistesine ekleme
            {
                Komsular.Add(i);
            }
            ArrayList GidilebilirKomsular = new ArrayList();
            ArrayList GidilecekYol = new ArrayList();
            ArrayList Guzergah = new ArrayList();
            ArrayList Elenen = new ArrayList();
            ArrayList GidilenToplamYol = new ArrayList();
            ArrayList Acılar = new ArrayList();


            while (true)
            {
                GidilebilirKomsular.Clear();
                GidilecekYol.Clear();
                foreach (string i in Komsular)
                {
                    if (MesafeHesaplama(i.Split('|')[0], AryIller.IndexOf(i.Split('|')[0]), Cmbİller.SelectedIndex).ToString() != "HATA")
                    {
                        GidilebilirKomsular.Add(MesafeHesaplama(i.Split('|')[0], AryIller.IndexOf(i.Split('|')[0]), CmbGidilecekIl.SelectedIndex));
                    }
                   // GidilecekYol.Add(MesafeHesaplama(i.Split('|')[0], AryIller.IndexOf(i.Split('|')[0]), CmbGidilecekIl.SelectedIndex));
                    try
                    {
                        GidilebilirKomsular.RemoveAt(GidilebilirKomsular.IndexOf("HATA"));
                      //  GidilecekYol.RemoveAt(GidilebilirKomsular.IndexOf("HATA"));
                    }
                    catch { }

                }
                for (int i = 0; i < GidilebilirKomsular.Count; i++)
                {

                    try
                    {
                        GidilebilirKomsular.RemoveAt(GidilebilirKomsular.IndexOf("HATA"));
                      //  GidilecekYol.RemoveAt(GidilebilirKomsular.IndexOf("HATA"));

                    }
                    catch { }
                }
                //foreach (string item in Komsular)
                //{
                //    string bul = "";
                //    bul = item.Split('|')[0] + "|" + Cmbİller.Text + "|" + MesafeHesaplama(item.Split('|')[0], AryIller.IndexOf(item.Split('|')[0]), Cmbİller.SelectedIndex);

                //    GidilecekYol.Add(bul );           
                //}
                //string c = "";
                //for (int i = 0; i < Komsular.Count; i++)
                //{
                //   // int SilinecekIndeks;
                //    string a = GidilecekYol[i].ToString().Split('|')[2];
                    
                //    if (a== "HATA")
                //    {
                //        try
                //        {
                //            //string b = GidilecekYol[i].ToString().Split('|')[1];
                //          c = GidilecekYol[i].ToString().Split('|')[0];
                //          //  GidilecekYol.RemoveAt(GidilecekYol.IndexOf(a));

                //        }
                //        catch { }
                   
                //    }
                //    GidilebilirKomsular.Remove(c);
                   
                    
                //}
                //try
                //{
                //    GidilebilirKomsular.RemoveAt(GidilecekYol.IndexOf(c));
                //}
                //catch { }




                double[] mesafe = new double[GidilebilirKomsular.Count];

                for (int i = 0; i < mesafe.Length; i++)
                {
                    mesafe[i] = Convert.ToDouble(GidilebilirKomsular[i].ToString().Split('|')[1]);
                }
                Array.Sort(mesafe);

                string EnYakinKomusuIl = "";
                foreach (string i in GidilebilirKomsular)
                {
                    if (i.Contains(mesafe[0].ToString()))
                    {
                        EnYakinKomusuIl = GidilebilirKomsular[GidilebilirKomsular.IndexOf(i)].ToString().Split('|')[0];
                        if (EnYakinKomusuIl.Contains("HATA"))
                        {

                        }
                        else
                        {
                            break;
                        }
                    }
                }
                Komsular.Clear();

                if (EnYakinKomusuIl.Trim().Length > 0)
                {
                    if (!EnYakinKomusuIl.Contains("HATA"))
                    {
                        foreach (string i in AryKomsu[AryIller.IndexOf(EnYakinKomusuIl.Split('|')[0])].ToString().Split(',').ToList())
                            Komsular.Add(i);
                        Guzergah.Add(EnYakinKomusuIl);
                        if (Komsular.ToArray().Where(x => x.ToString().ToLower().Contains(CmbGidilecekIl.Text.ToLower())).FirstOrDefault() != null)
                            break;
                    }
                }
                else break;
            }
            string ilkguzergah = Guzergah[0].ToString().Split('|')[0];
            string Yol = "";

            Yol += Cmbİller.Text + " => " + Guzergah[0] + " : " + MesafeHesaplama(Cmbİller.Text, Cmbİller.SelectedIndex, AryIller.IndexOf(Guzergah[0].ToString())) + Environment.NewLine;
            string l1 = (MesafeHesaplama(Cmbİller.Text, Cmbİller.SelectedIndex, AryIller.IndexOf(Guzergah[0].ToString())).Split('|')[1]);
            GidilenToplamYol.Add(l1);
            Acılar.Add((MesafeHesaplama(Cmbİller.Text, Cmbİller.SelectedIndex, AryIller.IndexOf(Guzergah[0].ToString())).Split('|')[2]));
            for (int i = 0; i < Guzergah.Count; i++)
            {
                if (i != Guzergah.Count - 1)
                {
                    Yol += Guzergah[i] + " => " + Guzergah[i + 1] + " : " + MesafeHesaplama(Guzergah[i].ToString(), AryIller.IndexOf(Guzergah[i].ToString()), AryIller.IndexOf(Guzergah[i + 1].ToString())) + Environment.NewLine;
                    string l2 = (MesafeHesaplama(Guzergah[i].ToString(), AryIller.IndexOf(Guzergah[i].ToString()), AryIller.IndexOf(Guzergah[i + 1].ToString())).Split('|')[1]);
                    GidilenToplamYol.Add(l2);
                    Acılar.Add((MesafeHesaplama(Guzergah[i].ToString(), AryIller.IndexOf(Guzergah[i].ToString()), AryIller.IndexOf(Guzergah[i + 1].ToString())).Split('|')[2]));
                }
                else
                {

                    Yol += Guzergah[i] + " => " + CmbGidilecekIl.Text + " : " + (MesafeHesaplama(Guzergah[i].ToString(), AryIller.IndexOf(Guzergah[i].ToString()), AryIller.IndexOf(CmbGidilecekIl.Text))) +  Environment.NewLine;
                    string l3 = (MesafeHesaplama(Guzergah[i].ToString(), AryIller.IndexOf(Guzergah[i].ToString()), AryIller.IndexOf(CmbGidilecekIl.Text))).Split('|')[1];
                    GidilenToplamYol.Add(l3);
                    Acılar.Add((MesafeHesaplama(Guzergah[i].ToString(), AryIller.IndexOf(Guzergah[i].ToString()), AryIller.IndexOf(CmbGidilecekIl.Text))).Split('|')[2]);
                }

            }
            int Maliyet = 0;
            double toplamyol = 0;
            for (int i = 0; i < GidilenToplamYol.Count; i++)
            {
                if (GidilenToplamYol[i].ToString() == "HATA") { }
                else
                {
                    toplamyol = toplamyol + Convert.ToDouble(GidilenToplamYol[i]);
                    Maliyet = Convert.ToInt32(10 * toplamyol);

                }

            }
           
            GidilenToplamYol.Clear();
            maliyet.Text = Maliyet.ToString();

            double[] A = new double[Acılar.Count];
            double[] B = new double[Acılar.Count];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = Convert.ToDouble(Acılar[i]);
                B[i] =Math.Round(A[i]);
            }
            Array.Sort(B);
            Array.Reverse(B);
            double YolcuSayisi = (80 - B[0]);
            MaxYolcuS.Text =YolcuSayisi.ToString();
           
                int kar = Convert.ToInt32(Maliyet * 2 / YolcuSayisi);
                MessageBox.Show ("%50 Kâr için " + Maliyet + " maliyetli yolu " + YolcuSayisi + " yolcu ile yolculardan " + kar + " tl alınmalıdır.");
            
            
        

            MessageBox.Show(Yol);

        

        }


        private string MesafeHesaplama(string il, int ilkil, int ikinciil)//mesafeyi hesaplattığımız fonksiyon eğer açı olayı olmazsa onu komşular listesine eklemiyor
        {
            double x = 0;
            double y = 0;
            string enlem1 = AryEnlem[ilkil].ToString();
            string boylam1 = AryBoylam[ilkil].ToString();
            string rakim1 = AryRakim[ilkil].ToString();
      
            string enlem2 = AryEnlem[ikinciil].ToString();
            string boylam2 = AryBoylam[ikinciil].ToString();
            string rakim2 = AryRakim[ikinciil].ToString();
            
            double EnlemFark = Math.Abs(Convert.ToDouble(enlem1) - Convert.ToDouble(enlem2));
            double BoylamFark = Math.Abs(Convert.ToDouble(boylam1) - Convert.ToDouble(boylam2));
            double EnlemBoylamUs = Math.Pow(EnlemFark, 2) + Math.Pow(BoylamFark, 2);
            double KaraKok = Math.Sqrt(EnlemBoylamUs) * 111; x = KaraKok;
            int RakımFark = Math.Abs(Convert.ToInt32(rakim1) - Convert.ToInt32(rakim2)); y = 50 + RakımFark;

            double acı = Math.Atan2(y, x);
            double Acı = acı * (180 / Math.PI);
            double sonuc = Math.Sqrt((Math.Pow(x, 2) + (Math.Pow(y, 2) * Math.Pow(10, -3))));
            string b = Convert.ToString(Acı);
            if ((80 - Convert.ToInt32(TxtYolcu.Text)) >= Math.Round(Acı))
            {
                return il + "|" + sonuc + "|" + Acı;
            }
            else
                return "HATA";
        }

       

        private void BtnBul_Click(object sender, EventArgs e)
        {
           
            if (TxtYolcu.Text.Trim() != "")
            {
                if (Cmbİller.SelectedIndex != CmbGidilecekIl.SelectedIndex)
                    KomsuHesaplama();
                else MessageBox.Show("Lütfen farklı il seçiniz!");
            }
            else MessageBox.Show("Yolcu boş olamaz!", "HATA");
        }

        
    }
}
