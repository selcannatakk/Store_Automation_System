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
    public partial class Frmhizlisatis : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=demet;Initial Catalog=shop;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;
        
        public Frmhizlisatis()
        {
            InitializeComponent();
        }
        

        private void Frmhizlisatis_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'shopDataSet.musterii' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musteriiTableAdapter.Fill(this.shopDataSet.musterii);
            // TODO: Bu kod satırı 'shopDataSet.personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.shopDataSet.personel);
            // TODO: Bu kod satırı 'shopDataSet.urun' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunTableAdapter.Fill(this.shopDataSet.urun);
            // TODO: Bu kod satırı 'shopDataSet.hareket' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hareketTableAdapter.Fill(this.shopDataSet.hareket);



            int toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }
            lblciro.Text = toplam.ToString();


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
 
            //Sütun değerlerini toplama
            

           /* int numara = (int)dataGridView1.CurrentRow.Cells[6].Value;
            ds = new DataSet();
            //da = new SqlDataAdapter("SELECT *FROM Hareket WHERE hogr=" + numara, con);
            da = new SqlDataAdapter("Select Ogrenci.ogrno AS NUMARA,ograd AS AD,ogrsoyad AS SOYAD,kitapad AS [KİTAP ADI],halis AS [ALIŞ TARİHİ],hteslim AS [TESLİMTARİHİ] FROM Ogrenci JOIN Hareket on Ogrenci.ogrno=Hareket.hogr JOIN Kitap on Kitap.ktpno=Hareket.hkitap WHERE Ogrenci.ogrno=" + numara, con);
            baglanti.Open();
            da.Fill(ds, "Hareket");
            dataGridView2.DataSource = ds.Tables["Hareket"];
            baglanti.Close();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(@"insert into hareketler(H_UrunId,H_PerId,H_MusteriId,H_UrunSatısFiyati) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", Convert.ToInt32(comboBox1.Text));
            komut.Parameters.AddWithValue("@p2", Convert.ToInt32(comboBox2.Text));
            komut.Parameters.AddWithValue("@p3", Convert.ToInt32(comboBox3.Text));
            komut.Parameters.AddWithValue("@p4", textBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            this.hareketTableAdapter.Fill(this.shopDataSet.hareket);
            int toplamsat = 0;
            for (int i = 0; i < dataGridView1.Rows.Count-1; ++i)
            {
                toplamsat += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }
            lblciro.Text = toplamsat.ToString();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from hareketler where HareketId=@p1", baglanti);   // silme işlemi
            komut.Parameters.AddWithValue("@p1",txthareketid.Text );
            komut.ExecuteNonQuery();
            baglanti.Close();
            this.hareketTableAdapter.Fill(this.shopDataSet.hareket);

        }

      
    }
}
