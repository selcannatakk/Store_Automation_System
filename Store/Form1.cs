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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonel child = new FrmPersonel();
            child.MdiParent = this;
            child.Show(); 
        }

        private void müşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmmusteri child = new Frmmusteri();
            child.MdiParent = this;
            child.Show();
        }

        private void ürünToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmurun child = new Frmurun();
            child.MdiParent = this;
            child.Show();
        }

        private void hızlıSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmhizlisatis child = new Frmhizlisatis();
            child.MdiParent = this;
            child.Show();
           
        }

        private void cariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmfiyatliste child = new Frmfiyatliste();
            child.MdiParent = this;
            child.Show();
        }
    }
}
