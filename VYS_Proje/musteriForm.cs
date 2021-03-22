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
    public partial class musteriEkleForm : Form
    {
       
        public musteriEkleForm()
        {
            InitializeComponent();
        }

       
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432; Database=stok_takip;user Id=postgres; password=1234");
        private void EkleMusteriButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            string sql1 = "select *from musteriKayitEkle('" + tcTextBox.Text + "','" + adsoyadTextBox.Text + "'," +
                "'" + telTextBox.Text + "','" + adresTestBox.Text + "','" + emailTextBox.Text + "')";
            NpgsqlCommand komut = new NpgsqlCommand(sql1, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Musteri Eklendi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void musteriEkleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
