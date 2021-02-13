
namespace Magaza_Hareket
{
    partial class Frmmusteri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmusteriid = new System.Windows.Forms.TextBox();
            this.txtmusteriisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmusteritel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.musteriIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet = new Magaza_Hareket.shopDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.lblmusterisayisi = new System.Windows.Forms.Label();
            this.txtmusteriSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.musteriiTableAdapter = new Magaza_Hareket.shopDataSetTableAdapters.musteriiTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtmusteriid
            // 
            this.txtmusteriid.Enabled = false;
            this.txtmusteriid.Location = new System.Drawing.Point(146, 43);
            this.txtmusteriid.Name = "txtmusteriid";
            this.txtmusteriid.Size = new System.Drawing.Size(140, 30);
            this.txtmusteriid.TabIndex = 1;
            // 
            // txtmusteriisim
            // 
            this.txtmusteriisim.Location = new System.Drawing.Point(146, 85);
            this.txtmusteriisim.Name = "txtmusteriisim";
            this.txtmusteriisim.Size = new System.Drawing.Size(140, 30);
            this.txtmusteriisim.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "İSİM:";
            // 
            // txtmusteritel
            // 
            this.txtmusteritel.Location = new System.Drawing.Point(146, 157);
            this.txtmusteritel.Name = "txtmusteritel";
            this.txtmusteritel.Size = new System.Drawing.Size(140, 30);
            this.txtmusteritel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "TELEFON:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 54);
            this.button2.TabIndex = 7;
            this.button2.Text = "GÜNCELLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriIdDataGridViewTextBoxColumn,
            this.musteriAdDataGridViewTextBoxColumn,
            this.musteriSoyadDataGridViewTextBoxColumn,
            this.musteriTelefonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.musteriiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(310, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(669, 284);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // musteriIdDataGridViewTextBoxColumn
            // 
            this.musteriIdDataGridViewTextBoxColumn.DataPropertyName = "MusteriId";
            this.musteriIdDataGridViewTextBoxColumn.HeaderText = "MusteriId";
            this.musteriIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriIdDataGridViewTextBoxColumn.Name = "musteriIdDataGridViewTextBoxColumn";
            this.musteriIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musteriAdDataGridViewTextBoxColumn
            // 
            this.musteriAdDataGridViewTextBoxColumn.DataPropertyName = "MusteriAd";
            this.musteriAdDataGridViewTextBoxColumn.HeaderText = "MusteriAd";
            this.musteriAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriAdDataGridViewTextBoxColumn.Name = "musteriAdDataGridViewTextBoxColumn";
            // 
            // musteriSoyadDataGridViewTextBoxColumn
            // 
            this.musteriSoyadDataGridViewTextBoxColumn.DataPropertyName = "MusteriSoyad";
            this.musteriSoyadDataGridViewTextBoxColumn.HeaderText = "MusteriSoyad";
            this.musteriSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriSoyadDataGridViewTextBoxColumn.Name = "musteriSoyadDataGridViewTextBoxColumn";
            // 
            // musteriTelefonDataGridViewTextBoxColumn
            // 
            this.musteriTelefonDataGridViewTextBoxColumn.DataPropertyName = "MusteriTelefon";
            this.musteriTelefonDataGridViewTextBoxColumn.HeaderText = "MusteriTelefon";
            this.musteriTelefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriTelefonDataGridViewTextBoxColumn.Name = "musteriTelefonDataGridViewTextBoxColumn";
            // 
            // musteriiBindingSource
            // 
            this.musteriiBindingSource.DataMember = "musterii";
            this.musteriiBindingSource.DataSource = this.shopDataSet;
            // 
            // shopDataSet
            // 
            this.shopDataSet.DataSetName = "shopDataSet";
            this.shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(714, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Toplam Müşteri:";
            // 
            // lblmusterisayisi
            // 
            this.lblmusterisayisi.AutoSize = true;
            this.lblmusterisayisi.Location = new System.Drawing.Point(880, 352);
            this.lblmusterisayisi.Name = "lblmusterisayisi";
            this.lblmusterisayisi.Size = new System.Drawing.Size(46, 24);
            this.lblmusterisayisi.TabIndex = 10;
            this.lblmusterisayisi.Text = "000";
            // 
            // txtmusteriSoyad
            // 
            this.txtmusteriSoyad.Location = new System.Drawing.Point(146, 121);
            this.txtmusteriSoyad.Name = "txtmusteriSoyad";
            this.txtmusteriSoyad.Size = new System.Drawing.Size(140, 30);
            this.txtmusteriSoyad.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "SOY AD:";
            // 
            // musteriiTableAdapter
            // 
            this.musteriiTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(63, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 46);
            this.button3.TabIndex = 13;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Frmmusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(991, 400);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmusteriSoyad);
            this.Controls.Add(this.lblmusterisayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtmusteritel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmusteriisim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmusteriid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frmmusteri";
            this.Text = "Frmmusteri";
            this.Load += new System.EventHandler(this.Frmmusteri_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmusteriid;
        private System.Windows.Forms.TextBox txtmusteriisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmusteritel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblmusterisayisi;
        private System.Windows.Forms.TextBox txtmusteriSoyad;
        private System.Windows.Forms.Label label5;
        private shopDataSet shopDataSet;
        private System.Windows.Forms.BindingSource musteriiBindingSource;
        private shopDataSetTableAdapters.musteriiTableAdapter musteriiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}