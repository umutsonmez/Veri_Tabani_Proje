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
    public partial class KullaniciEkleForm : Form
    {
        public KullaniciEkleForm()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432; Database=stok_takip;user Id=postgres; password=1234");
        DataSet daset = new DataSet();
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sql1 = "select *from kullaniciKayitEkle('" + int.Parse(idTextBox.Text) + "','" + ekleKullaniciAdiTextBox.Text + "','" + ekleSifreTextBox.Text + "')";
            NpgsqlCommand komut = new NpgsqlCommand(sql1, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kullanici Eklendi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
           
        }

        private void KullaniciEkleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
