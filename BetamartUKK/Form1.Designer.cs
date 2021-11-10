
namespace BetamartUKK
{
    partial class Form1
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.merkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukuranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglKadaluarsaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.stokBarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appBetaMart = new BetamartUKK.AppBetaMart();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.txtTglKadaluarsa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUkuran = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMerk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProduk = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.stok_BarangTableAdapter = new BetamartUKK.AppBetaMartTableAdapters.Stok_BarangTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokBarangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appBetaMart)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produk:";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Khaki;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.produkDataGridViewTextBoxColumn,
            this.merkDataGridViewTextBoxColumn,
            this.ukuranDataGridViewTextBoxColumn,
            this.tglKadaluarsaDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.dataGridView.DataSource = this.stokBarangBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(27, 306);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 158;
            this.dataGridView.Size = new System.Drawing.Size(475, 184);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.Width = 60;
            // 
            // produkDataGridViewTextBoxColumn
            // 
            this.produkDataGridViewTextBoxColumn.DataPropertyName = "Produk";
            this.produkDataGridViewTextBoxColumn.HeaderText = "Produk";
            this.produkDataGridViewTextBoxColumn.Name = "produkDataGridViewTextBoxColumn";
            this.produkDataGridViewTextBoxColumn.Width = 120;
            // 
            // merkDataGridViewTextBoxColumn
            // 
            this.merkDataGridViewTextBoxColumn.DataPropertyName = "Merk";
            this.merkDataGridViewTextBoxColumn.HeaderText = "Merk";
            this.merkDataGridViewTextBoxColumn.Name = "merkDataGridViewTextBoxColumn";
            this.merkDataGridViewTextBoxColumn.Width = 180;
            // 
            // ukuranDataGridViewTextBoxColumn
            // 
            this.ukuranDataGridViewTextBoxColumn.DataPropertyName = "Ukuran";
            this.ukuranDataGridViewTextBoxColumn.HeaderText = "Ukuran";
            this.ukuranDataGridViewTextBoxColumn.Name = "ukuranDataGridViewTextBoxColumn";
            // 
            // tglKadaluarsaDataGridViewTextBoxColumn
            // 
            this.tglKadaluarsaDataGridViewTextBoxColumn.DataPropertyName = "TglKadaluarsa";
            this.tglKadaluarsaDataGridViewTextBoxColumn.HeaderText = "TglKadaluarsa";
            this.tglKadaluarsaDataGridViewTextBoxColumn.Name = "tglKadaluarsaDataGridViewTextBoxColumn";
            this.tglKadaluarsaDataGridViewTextBoxColumn.Width = 200;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.Width = 145;
            // 
            // stokBarangBindingSource
            // 
            this.stokBarangBindingSource.DataMember = "Stok_Barang";
            this.stokBarangBindingSource.DataSource = this.appBetaMart;
            // 
            // appBetaMart
            // 
            this.appBetaMart.DataSetName = "AppBetaMart";
            this.appBetaMart.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Khaki;
            this.btnBrowse.Location = new System.Drawing.Point(40, 167);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.txtTglKadaluarsa);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.txtUkuran);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.txtMerk);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.txtProduk);
            this.panel.Controls.Add(this.btnBrowse);
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Controls.Add(this.label1);
            this.panel.Enabled = false;
            this.panel.Location = new System.Drawing.Point(27, 45);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(557, 209);
            this.panel.TabIndex = 3;
            // 
            // txtTglKadaluarsa
            // 
            this.txtTglKadaluarsa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stokBarangBindingSource, "TglKadaluarsa", true));
            this.txtTglKadaluarsa.Location = new System.Drawing.Point(247, 81);
            this.txtTglKadaluarsa.Name = "txtTglKadaluarsa";
            this.txtTglKadaluarsa.Size = new System.Drawing.Size(228, 20);
            this.txtTglKadaluarsa.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tgl kadaluarsa:";
            // 
            // txtUkuran
            // 
            this.txtUkuran.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stokBarangBindingSource, "Ukuran", true));
            this.txtUkuran.Location = new System.Drawing.Point(247, 55);
            this.txtUkuran.Name = "txtUkuran";
            this.txtUkuran.Size = new System.Drawing.Size(228, 20);
            this.txtUkuran.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ukuran:";
            // 
            // txtMerk
            // 
            this.txtMerk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stokBarangBindingSource, "Merk", true));
            this.txtMerk.Location = new System.Drawing.Point(247, 29);
            this.txtMerk.Name = "txtMerk";
            this.txtMerk.Size = new System.Drawing.Size(228, 20);
            this.txtMerk.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Merk:";
            // 
            // txtProduk
            // 
            this.txtProduk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stokBarangBindingSource, "Produk", true));
            this.txtProduk.Location = new System.Drawing.Point(247, 3);
            this.txtProduk.Name = "txtProduk";
            this.txtProduk.Size = new System.Drawing.Size(228, 20);
            this.txtProduk.TabIndex = 4;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.stokBarangBindingSource, "Image", true));
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(145, 158);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Khaki;
            this.btnNew.Location = new System.Drawing.Point(509, 306);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Khaki;
            this.btnEdit.Location = new System.Drawing.Point(509, 362);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Khaki;
            this.btnSave.Location = new System.Drawing.Point(508, 467);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // stok_BarangTableAdapter
            // 
            this.stok_BarangTableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Khaki;
            this.btnDelete.Location = new System.Drawing.Point(509, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(616, 520);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BetaMart";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokBarangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appBetaMart)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtTglKadaluarsa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUkuran;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMerk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProduk;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private AppBetaMart appBetaMart;
        private System.Windows.Forms.BindingSource stokBarangBindingSource;
        private AppBetaMartTableAdapters.Stok_BarangTableAdapter stok_BarangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn merkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukuranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglKadaluarsaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.Button btnDelete;
    }
}

