using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace VYS_Proje
{
    public partial class KullaniciForm : Form
    {
        public KullaniciForm()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432; Database=stok_takip;user Id=postgres; password=1234");
        DataSet daset = new DataSet();
        private void KullaniciForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciEkleForm ekleme = new KullaniciEkleForm();
            ekleme.ShowDialog();
        }

        private void GirisButton_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql1 = @"select *from login(:_username,:_password)";
                NpgsqlCommand komut = new NpgsqlCommand(sql1, baglanti);
                komut.Parameters.AddWithValue("_username", kullaniciAdiTextBox.Text);
                komut.Parameters.AddWithValue("_password", sifreTextBox.Text);
                int result = (int)komut.ExecuteScalar();
                baglanti.Close();

                if (result==1)
                {
                    satis sts = new satis();
                     sts.ShowDialog();
                }
            }
            catch (Exception )
            {

                MessageBox.Show("Hatali Giriş");
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }

        }
    }
}
