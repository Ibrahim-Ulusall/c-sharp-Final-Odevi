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

namespace Final_Odevi
{
    public partial class Movies : Form
    {
        public string filmAdi, filmTur, yonetmen, oyuncular, imdb, tur, yil, ozet, resimyol;
        public string film_saat = "11:15";
        public Movies()
        {
            InitializeComponent();
        }
        private void DoluKoltukMetot(Guna.UI.WinForms.GunaImageCheckBox cbox){
            cbox.ImageCheckedOn = Properties.Resources.Dolu_koltuk;
            cbox.Enabled = false;
        }
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-2853N3D;Initial Catalog=Cinema;Integrated Security=True");
        public int i = 0;
        public int biletFiyat = 0; // Bilet Fiyatı 25 TL
        List<Guna.UI.WinForms.GunaImageCheckBox> koltuklar = new List<Guna.UI.WinForms.GunaImageCheckBox>();
        List<string> livingRoom = new List<string>();
        private void Movies_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("select *from cinema",connect);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                for (int i = 0; i < koltuklar.Count; i++)
                {
                    if (koltuklar[i] == read["koltuk_no"])
                    {
                        DoluKoltukMetot(koltuklar[i]);
                    }
                }
            }
            connect.Close();
            HeaderFilmAdi.Text = filmAdi;
            HeaderFilmTuru.Text = tur;
            yonetmenLabel.Text = yonetmen;
            oyuncuLabel.Text = oyuncular;
            imdbLabel.Text = imdb;
            yilLabel.Text = yil;
            turLabel.Text = tur;
            ozetBox.Text = ozet;
            ImageBox.ImageLocation = string.Format(@"..\..\Resources\{0}.jpg", resimyol);
            
        }
        private void KoltukSayisi(Guna.UI.WinForms.GunaImageCheckBox checkbox) // Kullanıcının Secimiyle Koltuk Sayisini Belirleyecek Metot.
        {

            if (checkbox.Checked == true) // Eğer Kullancı Gönderdiği Parametredeki checkbox 'ı onaylamışsa koltuk sayisi 1 arttırılıp koltukSayi adındaki labele yazılacak.
            {
                livingRoom.Add(checkbox.Name);
                koltuklar.Add(checkbox);
                i++;
                biletFiyat += 25;
                satinAlButon.Visible = true;
                koltukSayi.Text = i.ToString();
                toplamLabel.Text = biletFiyat.ToString();
            }
            else
            {
                if (i == 0)
                {
                    //satinAlButon.Visible = false;
                }
                else
                {
                    livingRoom.Remove(checkbox.Name);
                    koltuklar.Remove(checkbox);
                    i--;
                    biletFiyat -= 25;
                    satinAlButon.Visible = true;
                    koltukSayi.Text = i.ToString();
                    toplamLabel.Text = biletFiyat.ToString();
                }
            }
        }
        private void ShowDatabase()
        {
            //connect.Open();     
        }
        private void a1_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(a1);
        }

        private void a2_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(a2);
        }

        private void a3_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(a3);
        }

        private void a4_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(a4);
        }

        private void a5_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(a5);
        }

        private void a6_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(a6);
        }

        private void a7_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(a7);
        }

        private void a8_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(a8);
        }

        private void a9_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(a9);
        }

        private void a10_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(a10);
        }

        private void a11_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(a11);
        }

        private void a12_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(a12);
        }

        private void b1_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(b1);
        }

        private void b2_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(b2);
        }

        private void b3_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(b3);
        }

        private void b4_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(b4);
        }

        private void b5_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(b5);
        }

        private void b6_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(b6);
        }

        private void b7_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(b7);
        }

        private void b8_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(b8);
        }

        private void b9_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(b9);
        }

        private void b10_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(b10);
        }

        private void b11_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(b11);
        }

        private void b12_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(b12);
        }

        private void c1_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(c1);
        }

        private void c2_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(c2);
        }

        private void c3_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(c3);
        }

        private void c4_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(c4);
        }

        private void c5_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(c5);
        }

        private void c6_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(c6);
        }

        private void c7_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(c7);
        }

        private void c8_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(c8);
        }

        private void c9_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(c9);
        }

        private void c10_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(c10);
        }

        private void c11_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(c11);
        }

        private void c12_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(c12);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void d1_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(d1);
        }

        private void d2_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(d2);
        }

        private void d3_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(d3);
        }

        private void d4_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(d4);
        }

        private void d5_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(d5);
        }

        private void d6_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(d6);
        }

        private void d7_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(d7);
        }

        private void d8_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(d8);
        }

        private void d9_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(d9);
        }

        private void d10_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(d10);
        }

        private void d11_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(d11);
        }

        private void d12_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(d12);
        }

        private void e1_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(e1);
        }

        private void e2_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(e2);
        }

        private void e3_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(e3);
        }

        private void e4_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(e4);
        }

        private void e5_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(e5);
        }

        private void e6_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(e6);
        }

        private void e7_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(e7);
        }

        private void e8_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(e8);
        }

        private void e9_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(e9);
        }

        private void e10_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(e10);
        }

        private void e11_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(e11);
        }

        private void e12_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(e12);
        }

        private void f1_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(f1);
        }

        private void f2_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(f2);
        }

        private void f3_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(f3);
        }

        private void f4_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(f4);
        }

        private void f5_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(f5);
        }

        private void f6_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(f6);
        }

        private void f7_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(f7);
        }

        private void f8_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(f8);
        }

        private void f9_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(f9);
        }

        private void f10_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(f10);
        }

        private void f11_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(f11);
        }

        private void f12_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(f12);
        }

        private void g1_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(g1);
        }

        private void g2_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(g2);
        }

        private void g3_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(g3);
        }

        private void g4_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(g4);
        }

        private void g5_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(g5);
        }

        private void g6_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(g6);
        }

        private void g7_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(g7);
        }

        private void g8_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(g8);
        }

        private void g9_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(g9);
        }

        private void g10_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(g10);
        }

        private void g11_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(g11);
        }

        private void g12_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(g12);
        }

        private void h1_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(h1);
        }

        private void h2_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(h2);
        }

        private void h3_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(h3);
        }

        private void h4_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(h4);
        }

        private void h5_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(h5);
        }

        private void h6_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(h6);
        }

        private void h7_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(h7);
        }

        private void h8_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(h8);
        }

        private void h9_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(h9);
        }

        private void h10_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(h10);
        }

        private void h11_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(h11);
        }

        private void h12_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(h12);
        }

        private void j1_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(j1);
        }

        private void j2_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(j2);
        }

        private void j3_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(j3);
        }

        private void j4_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(j4);
        }

        private void j5_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(j5);
        }

        private void j6_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(j6);
        }

        private void j7_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(j7);
        }

        private void j8_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(j8);
        }

        private void j9_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(j9);
        }

        private void j10_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(j10);
        }

        private void j11_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(j11);
        }

        private void j12_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(j12);
        }

        private void k1_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(k1);
        }

        private void k2_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(k2);
        }

        private void k3_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(k3);
        }

        private void k4_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(k4);
        }

        private void k5_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(k5);
        }

        private void k6_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(k6);
        }

        private void k7_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(k7);
        }

        private void k8_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(k8);
        }

        private void k9_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(k9);
        }

        private void k10_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(k10);
        }

        private void k11_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(k11);
        }

        private void k12_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(k12);
        }

        private void l1_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(l1);
        }

        private void l2_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(l2);
        }

        private void l3_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(l3);
        }

        private void l4_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(l4);
        }

        private void l5_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(l5);
        }

        private void l6_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(l6);
        }

        private void l7_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(l7);
        }

        private void l8_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(l8);
        }

        private void l9_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(l9);
        }

        private void l10_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(l10);
        }

        private void l11_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(l11);
        }

        private void l12_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(l12);
        }

        private void m1_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(m1);
        }

        private void m2_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(m2);
        }

        private void m3_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(m3);
        }

        private void m4_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(m4);
        }

        private void m5_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(m5);
        }

        private void m6_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(m6);
        }

        private void m7_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(m7);
        }

        private void m8_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(m8);
        }

        private void m9_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(m9);
        }

        private void m10_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(m10);
        }

        private void m11_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(m11);
        }

        private void m12_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSayisi(m12);
        }

        private void satinAlButon_Click(object sender, EventArgs e)
        {
            connect.Open();
            try
            {
                SqlCommand command = new SqlCommand("insert into cinema(film_adi,film_tur,koltuk_no,film_saat) values (@film_adi,@film_tur,@koltuk_no,@film_saat)", connect);
               
                for (int i = 0; i < koltuklar.Count; i++ )
                {
                    command.Parameters.AddWithValue("@film_adi", HeaderFilmAdi.Text);
                    command.Parameters.AddWithValue("@film_tur", HeaderFilmTuru.Text);
                    command.Parameters.AddWithValue("@koltuk_no", koltuklar[i]);
                    command.Parameters.AddWithValue("@film_saat", film_saat);
                    command.ExecuteNonQuery();
                }
                
                
                MessageBox.Show("işlem Başarılı");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                connect.Close();
            }
        }
    }
}
