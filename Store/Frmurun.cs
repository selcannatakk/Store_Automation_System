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
    public partial class Frmurun : Form
    {
        public Frmurun()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=demet;Initial Catalog=shop;Integrated Security=True");
     
        private void Frmurun_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'shopDataSet.urun' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunTableAdapter.Fill(this.shopDataSet.urun);

            sayac();

        }
        void sayac()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from urunSayi ", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblurunsayisi.Text = dr[0].ToString();
            }

            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(@"insert into urun(UrunAdi,UrunAlısFiyati,UrunSatışFiyati) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", txturunadi.Text);
            komut.Parameters.AddWithValue("@p2", txturunalis.Text);
            komut.Parameters.AddWithValue("@p3", txturunsatis.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            this.urunTableAdapter.Fill(this.shopDataSet.urun);
            sayac();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from urun where UrunId=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txturunid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            this.urunTableAdapter.Fill(this.shopDataSet.urun);
            sayac();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

             int Row = dataGridView1.CurrentCell.RowIndex;
            txturunid.Text = dataGridView1.Rows[Row].Cells[0].Value.ToString();
            txturunadi.Text = dataGridView1.Rows[Row].Cells[1].Value.ToString();
            txturunalis.Text = dataGridView1.Rows[Row].Cells[2].Value.ToString();
            txturunsatis.Text = dataGridView1.Rows[Row].Cells[3].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set UrunAdi= @p1,UrunAlısFiyati=@p2,UrunSatışFiyati = @p3 where UrunId=@p4", baglanti);
            komut.Parameters.AddWithValue("@p1", txturunadi.Text);
            komut.Parameters.AddWithValue("@p2", txturunalis.Text);
            komut.Parameters.AddWithValue("@p3", txturunsatis.Text);
            komut.Parameters.AddWithValue("@p4", txturunid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            
        }

    }
}

