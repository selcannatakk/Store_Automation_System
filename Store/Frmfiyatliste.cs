using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magaza_Hareket
{
    public partial class Frmfiyatliste : Form
    {
        public Frmfiyatliste()
        {
            InitializeComponent();
        }

        private void Frmfiyatliste_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'shopDataSet.urunBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunBilgiTableAdapter.Fill(this.shopDataSet.urunBilgi);

        }
    }
}
