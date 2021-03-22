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
    public partial class musteriListelemeForm : Form
    {
        public musteriListelemeForm()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432; Database=stok_takip;user Id=postgres; password=1234");
        DataSet daset = new DataSet();
        private void musteriListelemeForm_Load(object sender, EventArgs e)
        {
            Kayit_Goster();
        }
        private void Kayit_Goster()
        {

            baglanti.Open();
            NpgsqlDataAdapter adtr = new NpgsqlDataAdapter("SELECT *FROM MUSTERi ", baglanti);
            adtr.Fill(daset, "musteri");
            dataGridView1.DataSource = daset.Tables["musteri"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tcTextBox.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            adsoyadTextBox.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            telTextBox.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            adresTestBox.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            emailTextBox.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("UPDATE musteri SET adsoyad=@adsoyad,telefon=@telefon,adres=@adres,email=@email WHERE tc=@tc",baglanti);
            komut2.Parameters.AddWithValue("@tc", tcTextBox.Text);
            komut2.Parameters.AddWithValue("@adsoyad", adsoyadTextBox.Text);
            komut2.Parameters.AddWithValue("@telefon", telTextBox.Text);
            komut2.Parameters.AddWithValue("@adres", adresTestBox.Text);
            komut2.Parameters.AddWithValue("@email", emailTextBox.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["musteri"].Clear();
            Kayit_Goster();
            MessageBox.Show("Musteri Kaydi Guncellendi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sql1 = "select *from musteriSil('" + dataGridView1.CurrentRow.Cells["tc"].Value.ToString() + "')";
            NpgsqlCommand komut = new NpgsqlCommand(sql1, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["musteri"].Clear();
            Kayit_Goster();
            MessageBox.Show("Musteri Kaydi Silindi");
        }

        private void tcAraTextBox_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            NpgsqlDataAdapter adtr = new NpgsqlDataAdapter ("SELECT *FROM musteri WHERE tc like '%" + tcAraTextBox.Text +"%'",baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
