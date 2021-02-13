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

namespace Magaza_Hareket
{
    public partial class Frmmusteri : Form
    {
        public Frmmusteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=demet;Initial Catalog=shop;Integrated Security=True");

        private void Frmmusteri_Load_1(object sender, EventArgs e)
        {
            this.musteriiTableAdapter.Fill(this.shopDataSet.musterii);
            sayac();

        }
        void sayac()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from musteriSayi ", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                lblmusterisayisi.Text = dr[0].ToString();
            }

            baglanti.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(@"insert into musterii(MusteriAd,MusteriSoyad,MusteriTelefon) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtmusteriisim.Text);
            komut.Parameters.AddWithValue("@p2", txtmusteriSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtmusteritel.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            this.musteriiTableAdapter.Fill(this.shopDataSet.musterii);
            sayac();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update musterii set MusteriAd= @p1,MusteriSoyad=@p2,MusteriTelefon = @p3 where MusteriId=@p5", baglanti);
            komut.Parameters.AddWithValue("@p1", txtmusteriisim.Text);
            komut.Parameters.AddWithValue("@p2", txtmusteriSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtmusteritel.Text);
            komut.Parameters.AddWithValue("@p5", txtmusteriid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            this.musteriiTableAdapter.Fill(this.shopDataSet.musterii);


        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int Row = dataGridView1.CurrentCell.RowIndex;
            txtmusteriid.Text = dataGridView1.Rows[Row].Cells[0].Value.ToString();
            txtmusteriisim.Text = dataGridView1.Rows[Row].Cells[1].Value.ToString();
            txtmusteriSoyad.Text = dataGridView1.Rows[Row].Cells[2].Value.ToString();
            txtmusteritel.Text= dataGridView1.Rows[Row].Cells[3].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from musterii where MusteriId=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1",txtmusteriid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            this.musteriiTableAdapter.Fill(this.shopDataSet.musterii);
            sayac();
        }
    }
}
