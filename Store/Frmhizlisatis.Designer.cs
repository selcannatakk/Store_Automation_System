
namespace Magaza_Hareket
{
    partial class Frmhizlisatis
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
            this.lblciro = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hareketIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.müşteriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunSatışFiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hareketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet = new Magaza_Hareket.shopDataSet();
            this.hareketTableAdapter = new Magaza_Hareket.shopDataSetTableAdapters.hareketTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.musteriiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.urunTableAdapter = new Magaza_Hareket.shopDataSetTableAdapters.urunTableAdapter();
            this.personelTableAdapter = new Magaza_Hareket.shopDataSetTableAdapters.personelTableAdapter();
            this.musteriiTableAdapter = new Magaza_Hareket.shopDataSetTableAdapters.musteriiTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txthareketid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblciro
            // 
            this.lblciro.AutoSize = true;
            this.lblciro.Location = new System.Drawing.Point(1225, 492);
            this.lblciro.Name = "lblciro";
            this.lblciro.Size = new System.Drawing.Size(58, 24);
            this.lblciro.TabIndex = 1;
            this.lblciro.Text = "0000";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hareketIdDataGridViewTextBoxColumn,
            this.urunAdiDataGridViewTextBoxColumn,
            this.personelDataGridViewTextBoxColumn,
            this.müşteriDataGridViewTextBoxColumn,
            this.urunSatışFiyatiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hareketBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(447, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(856, 436);
            this.dataGridView1.TabIndex = 2;
            // 
            // hareketIdDataGridViewTextBoxColumn
            // 
            this.hareketIdDataGridViewTextBoxColumn.DataPropertyName = "HareketId";
            this.hareketIdDataGridViewTextBoxColumn.HeaderText = "HareketId";
            this.hareketIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hareketIdDataGridViewTextBoxColumn.Name = "hareketIdDataGridViewTextBoxColumn";
            this.hareketIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunAdiDataGridViewTextBoxColumn
            // 
            this.urunAdiDataGridViewTextBoxColumn.DataPropertyName = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.HeaderText = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunAdiDataGridViewTextBoxColumn.Name = "urunAdiDataGridViewTextBoxColumn";
            // 
            // personelDataGridViewTextBoxColumn
            // 
            this.personelDataGridViewTextBoxColumn.DataPropertyName = "Personel";
            this.personelDataGridViewTextBoxColumn.HeaderText = "Personel";
            this.personelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelDataGridViewTextBoxColumn.Name = "personelDataGridViewTextBoxColumn";
            this.personelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // müşteriDataGridViewTextBoxColumn
            // 
            this.müşteriDataGridViewTextBoxColumn.DataPropertyName = "Müşteri";
            this.müşteriDataGridViewTextBoxColumn.HeaderText = "Müşteri";
            this.müşteriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.müşteriDataGridViewTextBoxColumn.Name = "müşteriDataGridViewTextBoxColumn";
            this.müşteriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunSatışFiyatiDataGridViewTextBoxColumn
            // 
            this.urunSatışFiyatiDataGridViewTextBoxColumn.DataPropertyName = "UrunSatışFiyati";
            this.urunSatışFiyatiDataGridViewTextBoxColumn.HeaderText = "UrunSatışFiyati";
            this.urunSatışFiyatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunSatışFiyatiDataGridViewTextBoxColumn.Name = "urunSatışFiyatiDataGridViewTextBoxColumn";
            // 
            // hareketBindingSource
            // 
            this.hareketBindingSource.DataMember = "hareket";
            this.hareketBindingSource.DataSource = this.shopDataSet;
            // 
            // shopDataSet
            // 
            this.shopDataSet.DataSetName = "shopDataSet";
            this.shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hareketTableAdapter
            // 
            this.hareketTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1092, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Toplam Ciro:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.urunBindingSource;
            this.comboBox1.DisplayMember = "UrunId";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(158, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 32);
            this.comboBox1.TabIndex = 4;
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataMember = "urun";
            this.urunBindingSource.DataSource = this.shopDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.personelBindingSource;
            this.comboBox2.DisplayMember = "PerId";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(158, 121);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(234, 32);
            this.comboBox2.TabIndex = 5;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "personel";
            this.personelBindingSource.DataSource = this.shopDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.musteriiBindingSource;
            this.comboBox3.DisplayMember = "MusteriId";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(158, 191);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(234, 32);
            this.comboBox3.TabIndex = 6;
            // 
            // musteriiBindingSource
            // 
            this.musteriiBindingSource.DataMember = "musterii";
            this.musteriiBindingSource.DataSource = this.shopDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "URUN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "PERSONEL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "MÜŞTERİ:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 262);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 30);
            this.textBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "SATIŞ FİYATI:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 69);
            this.button1.TabIndex = 12;
            this.button1.Text = "SAT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // urunTableAdapter
            // 
            this.urunTableAdapter.ClearBeforeFill = true;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // musteriiTableAdapter
            // 
            this.musteriiTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ürün-Personel-Müşteri ID lerini giriniz!";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 70);
            this.button2.TabIndex = 14;
            this.button2.Text = "SİL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txthareketid
            // 
            this.txthareketid.Location = new System.Drawing.Point(158, 403);
            this.txthareketid.Name = "txthareketid";
            this.txthareketid.Size = new System.Drawing.Size(234, 30);
            this.txthareketid.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Font = new System.Drawing.Font("Georgia", 9F);
            this.label7.Location = new System.Drawing.Point(32, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(336, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Silmek istediğiniz ürünün hareket ID sini giriniz! ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "HAREKET ID:";
            // 
            // Frmhizlisatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1338, 571);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txthareketid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblciro);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frmhizlisatis";
            this.Text = "Frmhizlisatis";
            this.Load += new System.EventHandler(this.Frmhizlisatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblciro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private shopDataSet shopDataSet;
        private System.Windows.Forms.BindingSource hareketBindingSource;
        private shopDataSetTableAdapters.hareketTableAdapter hareketTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hareketIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn müşteriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunSatışFiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource urunBindingSource;
        private shopDataSetTableAdapters.urunTableAdapter urunTableAdapter;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private shopDataSetTableAdapters.personelTableAdapter personelTableAdapter;
        private System.Windows.Forms.BindingSource musteriiBindingSource;
        private shopDataSetTableAdapters.musteriiTableAdapter musteriiTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txthareketid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}