using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VYS_Proje
{
    public partial class satis : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432; Database=stok_takip;user Id=postgres; password=1234");
        DataSet daset = new DataSet();
        public satis()
        {
            InitializeComponent();
        }
        private void SepetListele()
        {
            baglanti.Open();
            NpgsqlDataAdapter adtr = new NpgsqlDataAdapter("select *from sepet", baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            baglanti.Close();
        }
        private void Hesapla()
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut = new NpgsqlCommand("select sum(toplamfiyat) from sepet", baglanti);
                genelToplamLabel.Text = komut.ExecuteScalar() + "TL";
                baglanti.Close();
            }
            catch (Exception)
            {

                ;
            }
        }
        private void satis_Load(object sender, EventArgs e)
        {
            
            SepetListele();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void musteriEkleButton_Click(object sender, EventArgs e)
        {
            musteriEkleForm ekle = new musteriEkleForm();
            ekle.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void musteriListeleButton_Click(object sender, EventArgs e)
        {
            musteriListelemeForm listele = new musteriListelemeForm();
            listele.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UrunEkleForm ekle = new UrunEkleForm();
            ekle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KategoriForm kategori = new KategoriForm();
            kategori.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MarkaForm marka = new MarkaForm();
            marka.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UrunListeleForm listeleme = new UrunListeleForm();
            listeleme.ShowDialog();
        }

        private void tcTextBox_TextChanged(object sender, EventArgs e)
        {
            if (tcTextBox.Text == "")
            {
                adSoyadTextBox.Text = "";
                telefonTextBox.Text = "";
            }
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select *from musteri where tc like'" + tcTextBox.Text + "'", baglanti);
            NpgsqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                adSoyadTextBox.Text = read["adsoyad"].ToString();
                telefonTextBox.Text = read["telefon"].ToString();

            }
            baglanti.Close();
        }

        private void Temizle()
        {
            if (barkodTextBox.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != miktarTextBox)
                        {
                            item.Text = "";
                        }
                    }

                }
            }
        }
        bool durum;
        private void BarkodKontrol()
        {
            durum = true;
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select *from sepet",baglanti);
            NpgsqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (barkodTextBox.Text==read["barkodno"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void ekleButton_Click(object sender, EventArgs e)
        {
            BarkodKontrol();
            if (durum==true)
            {
                baglanti.Open();
                NpgsqlCommand komut = new NpgsqlCommand("insert into sepet(tc,adsoyad,telefon,barkodno,urunadi,miktar,satisfiyati,toplamfiyat,tarih) values(@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktar,@satisfiyati,@toplamfiyat,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@tc", tcTextBox.Text);
                komut.Parameters.AddWithValue("@adsoyad", adSoyadTextBox.Text);
                komut.Parameters.AddWithValue("@telefon", telefonTextBox.Text);
                komut.Parameters.AddWithValue("@barkodno", barkodTextBox.Text);
                komut.Parameters.AddWithValue("@urunadi", urunAdiTextBox.Text);
                komut.Parameters.AddWithValue("@miktar", int.Parse(miktarTextBox.Text));
                komut.Parameters.AddWithValue("@satisfiyati", satisFiyatiTextBox.Text);
                komut.Parameters.AddWithValue("@toplamfiyat", toplamFiyatTextBox.Text);
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand komut2 = new NpgsqlCommand("update sepet set miktar=miktar+'"+int.Parse(miktarTextBox.Text)+ "'where barkodno='" + barkodTextBox.Text + "'",baglanti);
                komut2.ExecuteNonQuery();

                baglanti.Close();
            }
           
            miktarTextBox.Text = "1";
            daset.Tables["sepet"].Clear();
            SepetListele();
            Hesapla();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != miktarTextBox)
                    {
                        item.Text = "";
                    }
                }

            }


        }

        private void miktarTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                toplamFiyatTextBox.Text = (double.Parse(miktarTextBox.Text) * double.Parse(satisFiyatiTextBox.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void satisFiyatiTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                toplamFiyatTextBox.Text = (double.Parse(miktarTextBox.Text) * double.Parse(satisFiyatiTextBox.Text)).ToString();
            }
            catch (Exception)
            {

               ;
            }
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("delete from sepet where barkodno='"+dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString()+"'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
           
            MessageBox.Show("Ürün sepetten silindi");
            daset.Tables["sepet"].Clear();
            SepetListele();
            Hesapla();
        }

        private void satisİptalButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("delete from sepet", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
           
            MessageBox.Show("Satış İptal Edildi");
            daset.Tables["sepet"].Clear();
           
            SepetListele();
            Hesapla();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SatisListeleForm listele = new SatisListeleForm();
            listele.ShowDialog();
        }

        private void barkodTextBox_TextChanged_1(object sender, EventArgs e)
        {

            if (barkodTextBox.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item != miktarTextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            baglanti.Close();
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("select *from urun where barkodno like'" + barkodTextBox.Text + "'", baglanti);
            NpgsqlDataReader read = komut2.ExecuteReader();
            while (read.Read())
            {
                urunAdiTextBox.Text = read["urunadi"].ToString();
                satisFiyatiTextBox.Text = read["satisfiyati"].ToString();

            }
            baglanti.Close();
            
           



        }

        private void NewMethod()
        {
            baglanti.Open();
        }

        private void satisYapButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                baglanti.Open();
                NpgsqlCommand komut = new NpgsqlCommand("insert into satis(tc,adsoyad,telefon,barkodno,urunadi,miktar,satisfiyati,toplamfiyat,tarih) values(@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktar,@satisfiyati,@toplamfiyat,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@tc", tcTextBox.Text);
                komut.Parameters.AddWithValue("@adsoyad", adSoyadTextBox.Text);
                komut.Parameters.AddWithValue("@telefon", telefonTextBox.Text);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                komut.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["urunadi"].Value.ToString());
                komut.Parameters.AddWithValue("@miktar", int.Parse(dataGridView1.Rows[i].Cells["miktar"].Value.ToString()));
                komut.Parameters.AddWithValue("@satisfiyati", dataGridView1.Rows[i].Cells["satisfiyati"].Value.ToString());
                komut.Parameters.AddWithValue("@toplamfiyat", dataGridView1.Rows[i].Cells["toplamfiyat"].Value.ToString());
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                NpgsqlCommand komut2 = new NpgsqlCommand("update urun set miktar=miktar-'" + int.Parse(dataGridView1.Rows[i].Cells["miktar"].Value.ToString()) + "'where barkodno='" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString()+ "' ", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
            }
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("delete from sepet", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["sepet"].Clear();
            SepetListele();
            Hesapla();
        }

       
    }
}
