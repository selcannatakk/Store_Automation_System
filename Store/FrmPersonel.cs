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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'shopDataSet.personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.shopDataSet.personel);


            sayac();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=demet;Initial Catalog=shop;Integrated Security=True");
        void sayac()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from personelSayi  ", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblpersonelsayisi.Text = dr[0].ToString();
            }

            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();    //store proc
            SqlCommand komut = new SqlCommand("perEkle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@ad",txtpersonelisim.Text.Trim());
            komut.Parameters.AddWithValue("@soyad", txtpersonelsoyad.Text.Trim());
            komut.Parameters.AddWithValue("@telefon", txtpersoneltel.Text.Trim());
            komut.Parameters.AddWithValue("@maas", txtpersonelmaas.Text.Trim());
            komut.ExecuteNonQuery();
            baglanti.Close();
            this.personelTableAdapter.Fill(this.shopDataSet.personel);
            sayac();
        }

        private void button2_Click(object sender, EventArgs e)

        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update personel set PerIsim= @p1,perSoyad=@p2,perTelefon = @p3,perMaas = @p4 where perId=@p5", baglanti);
            komut.Parameters.AddWithValue("@p1", txtpersonelisim.Text);
            komut.Parameters.AddWithValue("@p2", txtpersonelsoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtpersoneltel.Text);
            komut.Parameters.AddWithValue("@p4", txtpersonelmaas.Text);
            komut.Parameters.AddWithValue("@p5", txtpersonelid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            this.personelTableAdapter.Fill(this.shopDataSet.personel);

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            int Row = dataGridView1.CurrentCell.RowIndex;
            txtpersonelid.Text = dataGridView1.Rows[Row].Cells[0].Value.ToString();
            txtpersonelisim.Text = dataGridView1.Rows[Row].Cells[1].Value.ToString();
            txtpersonelsoyad.Text = dataGridView1.Rows[Row].Cells[2].Value.ToString();
            txtpersoneltel.Text = dataGridView1.Rows[Row].Cells[3].Value.ToString();
            txtpersonelmaas.Text = dataGridView1.Rows[Row].Cells[4].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from personel where PerId=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtpersonelid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            this.personelTableAdapter.Fill(this.shopDataSet.personel);
            sayac();
        }
    }
}
