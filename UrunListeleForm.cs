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
   
    public partial class UrunListeleForm : Form
    {
        public UrunListeleForm()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432; Database=stok_takip;user Id=postgres; password=1234");
        DataSet daset = new DataSet();
        private void KategoriGetir()
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select *from kategoribilgileri", baglanti);
            NpgsqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                kategoriGuncelleComboBox.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }
        private void UrunListeleForm_Load(object sender, EventArgs e)
        {
            UrunListele();
            KategoriGetir();

        }

        private void UrunListele()
        {
            baglanti.Open();
            NpgsqlDataAdapter adtr = new NpgsqlDataAdapter("select *from urun", baglanti);
            adtr.Fill(daset, "urun");
            dataGridView1.DataSource = daset.Tables["urun"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            varOlanBarkodTextBox.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            varOlanKategoriTextBox.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            varOlanMarkaTextBox.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            varOlanUrunAdiTextBox.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            varOlanMiktarTextBox.Text = dataGridView1.CurrentRow.Cells["miktar"].Value.ToString();
            varOlanAlisFiyatiTextBox.Text = dataGridView1.CurrentRow.Cells["alisfiyati"].Value.ToString();
            varOlanSatisFiyatiTextBox.Text = dataGridView1.CurrentRow.Cells["satisfiyati"].Value.ToString();
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("update urun set urunadi=@urunadi,miktar=@miktar,alisfiyati=@alisfiyati,satisfiyati=@satisfiyati where barkodno=@barkodno", baglanti);
            komut.Parameters.AddWithValue("@barkodno",varOlanBarkodTextBox.Text);
            komut.Parameters.AddWithValue("@urunadi",varOlanUrunAdiTextBox.Text);
            komut.Parameters.AddWithValue("@miktar",int.Parse(varOlanMiktarTextBox.Text));
            komut.Parameters.AddWithValue("@alisfiyati",varOlanAlisFiyatiTextBox.Text);
            komut.Parameters.AddWithValue("@satisfiyati",varOlanSatisFiyatiTextBox.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urun"].Clear();
            UrunListele();
            MessageBox.Show("Guncelleme Yapıldı");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
           
        }

        private void markaGuncelleButton_Click(object sender, EventArgs e)
        {
            if (varOlanBarkodTextBox.Text!="")
            {
                baglanti.Open();
                NpgsqlCommand komut = new NpgsqlCommand("update urun set kategori=@kategori,marka=@marka where barkodno=@barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", varOlanBarkodTextBox.Text);
                komut.Parameters.AddWithValue("@kategori", kategoriGuncelleComboBox.Text);
                komut.Parameters.AddWithValue("@marka", markaGuncelleComboBox.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                daset.Tables["urun"].Clear();
                UrunListele();
                MessageBox.Show("Guncelleme Yapıldı");
                foreach (Control item in this.Controls)
                {
                    if (item is ComboBox)
                    {
                        item.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("BarkodNo yazılı değil", "Uyarı");
            }
        
        }

        private void kategoriGuncelleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            markaGuncelleComboBox.Items.Clear();
            markaGuncelleComboBox.Text = "";
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select *from markabilgileri where kategori='" + kategoriGuncelleComboBox.SelectedItem + "'", baglanti);
            NpgsqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                markaGuncelleComboBox.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void silmeButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("Delete From urun where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urun"].Clear();
            UrunListele();
            MessageBox.Show("Urun Kaydi Silindi");
        }

        private void barkodNoAraTextBox_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            NpgsqlDataAdapter adtr = new NpgsqlDataAdapter("SELECT *FROM urun WHERE barkodno like '%" + barkodNoAraTextBox.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void varOlanBarkodTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
