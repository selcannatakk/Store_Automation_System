
namespace Magaza_Hareket
{
    partial class Frmfiyatliste
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shopDataSet = new Magaza_Hareket.shopDataSet();
            this.urunBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunBilgiTableAdapter = new Magaza_Hareket.shopDataSetTableAdapters.urunBilgiTableAdapter();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunSatışFiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBilgiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunAdiDataGridViewTextBoxColumn,
            this.urunSatışFiyatiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.urunBilgiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(494, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // shopDataSet
            // 
            this.shopDataSet.DataSetName = "shopDataSet";
            this.shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunBilgiBindingSource
            // 
            this.urunBilgiBindingSource.DataMember = "urunBilgi";
            this.urunBilgiBindingSource.DataSource = this.shopDataSet;
            // 
            // urunBilgiTableAdapter
            // 
            this.urunBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // urunAdiDataGridViewTextBoxColumn
            // 
            this.urunAdiDataGridViewTextBoxColumn.DataPropertyName = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.HeaderText = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunAdiDataGridViewTextBoxColumn.Name = "urunAdiDataGridViewTextBoxColumn";
            // 
            // urunSatışFiyatiDataGridViewTextBoxColumn
            // 
            this.urunSatışFiyatiDataGridViewTextBoxColumn.DataPropertyName = "UrunSatışFiyati";
            this.urunSatışFiyatiDataGridViewTextBoxColumn.HeaderText = "UrunSatışFiyati";
            this.urunSatışFiyatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunSatışFiyatiDataGridViewTextBoxColumn.Name = "urunSatışFiyatiDataGridViewTextBoxColumn";
            // 
            // Frmfiyatliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frmfiyatliste";
            this.Text = "Frmfiyatliste";
            this.Load += new System.EventHandler(this.Frmfiyatliste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBilgiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private shopDataSet shopDataSet;
        private System.Windows.Forms.BindingSource urunBilgiBindingSource;
        private shopDataSetTableAdapters.urunBilgiTableAdapter urunBilgiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunSatışFiyatiDataGridViewTextBoxColumn;
    }
}