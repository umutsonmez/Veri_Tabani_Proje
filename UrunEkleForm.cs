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
    public partial class UrunEkleForm : Form
    {
        public UrunEkleForm()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432; Database=stok_takip;user Id=postgres; password=1234");
        bool durum;
        private void BarkodKontrol()
        {
            durum = true;
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select *from urun", baglanti);
            NpgsqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (barkodNoTextBox.Text==read["barkodno"].ToString()||barkodNoTextBox.Text=="")
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void KategoriGetir()
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select *from kategoribilgileri", baglanti);
            NpgsqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                kategoriComboBox.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }
        private void UrunEkleForm_Load(object sender, EventArgs e)
        {
            KategoriGetir();
        }

        private void kategoriComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            markaComboBox.Items.Clear();
            markaComboBox.Text = "";
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select *from markabilgileri where kategori='"+kategoriComboBox.SelectedItem+"'", baglanti);
            NpgsqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                markaComboBox.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void yeniUrunEkleButton_Click(object sender, EventArgs e)
        {
            BarkodKontrol();
            if (durum==true)
            {
                baglanti.Open();
                NpgsqlCommand komut = new NpgsqlCommand("insert into urun(barkodno,kategori,marka,urunadi,miktar,alisfiyati,satisfiyati,tarih) values(@barkodno,@kategori,@marka,@urunadi,@miktar,@alisfiyati,@satisfiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@barkodno", barkodNoTextBox.Text);
                komut.Parameters.AddWithValue("@kategori", kategoriComboBox.Text);
                komut.Parameters.AddWithValue("@marka", markaComboBox.Text);
                komut.Parameters.AddWithValue("@urunadi", urunAdiTextBox.Text);
                komut.Parameters.AddWithValue("@miktar", int.Parse(miktarTextBox.Text));
                komut.Parameters.AddWithValue("@alisfiyati", alisFiyatiTextBox.Text);
                komut.Parameters.AddWithValue("@satisfiyati", satisFiyatiTextBox.Text);
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
               
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ürün Eklendi");
            }
            else
            {
                MessageBox.Show("Böyle bir barkod no var", "Uyarı");
            }
           
            markaComboBox.Items.Clear();

            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void varOlanBarkodTextBox_TextChanged(object sender, EventArgs e)
        {
           
            if (varOlanBarkodTextBox.Text=="")
            {
                miktarLabel.Text = "";
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select *from urun where barkodno like '" + varOlanBarkodTextBox.Text + "'", baglanti);
            NpgsqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                varOlanKategoriTextBox.Text = read["kategori"].ToString();
                varOlanMarkaTextBox.Text = read["marka"].ToString();
                varOlanUrunAdiTextBox.Text = read["urunadi"].ToString();
                miktarLabel.Text = read["miktar"].ToString();
                varOlanAlisFiyatiTextBox.Text = read["alisfiyati"].ToString();
                varOlanSatisFiyatiTextBox.Text = read["satisfiyati"].ToString();
              
            }
            baglanti.Close();

        }

        private void varOlanUrunEkleButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("update urun set miktar=miktar+'"+int.Parse(varOlanMiktarTextBox.Text)+"'where barkodno='"+varOlanBarkodTextBox.Text+"' ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("Var olan ürüne ekleme yapıldı");
        }
    }
}
