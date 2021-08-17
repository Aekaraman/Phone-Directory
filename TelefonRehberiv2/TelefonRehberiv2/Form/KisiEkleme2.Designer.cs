
namespace TelefonRehberiv2
{
    partial class KisiEkleme2
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
            this.gpKişiEklemePaneli = new System.Windows.Forms.GroupBox();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.txtKişiAra = new System.Windows.Forms.TextBox();
            this.lblKişiAra = new System.Windows.Forms.Label();
            this.mtxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAD = new System.Windows.Forms.TextBox();
            this.lLYöneticiEkranı = new System.Windows.Forms.LinkLabel();
            this.lblTELEFON = new System.Windows.Forms.Label();
            this.lblSOYAD = new System.Windows.Forms.Label();
            this.lblAD = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.denemeDataSet = new TelefonRehberiv2.DenemeDataSet();
            this.kisiEklemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kisiEklemeTableAdapter = new TelefonRehberiv2.DenemeDataSetTableAdapters.KisiEklemeTableAdapter();
            this.kisiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adresEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpKişiEklemePaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisiEklemeBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpKişiEklemePaneli
            // 
            this.gpKişiEklemePaneli.Controls.Add(this.btnGüncelle);
            this.gpKişiEklemePaneli.Controls.Add(this.txtKişiAra);
            this.gpKişiEklemePaneli.Controls.Add(this.lblKişiAra);
            this.gpKişiEklemePaneli.Controls.Add(this.mtxtTelefon);
            this.gpKişiEklemePaneli.Controls.Add(this.btnKaydet);
            this.gpKişiEklemePaneli.Controls.Add(this.txtSoyad);
            this.gpKişiEklemePaneli.Controls.Add(this.txtAD);
            this.gpKişiEklemePaneli.Controls.Add(this.lLYöneticiEkranı);
            this.gpKişiEklemePaneli.Controls.Add(this.lblTELEFON);
            this.gpKişiEklemePaneli.Controls.Add(this.lblSOYAD);
            this.gpKişiEklemePaneli.Controls.Add(this.lblAD);
            this.gpKişiEklemePaneli.Location = new System.Drawing.Point(30, 14);
            this.gpKişiEklemePaneli.Name = "gpKişiEklemePaneli";
            this.gpKişiEklemePaneli.Size = new System.Drawing.Size(558, 256);
            this.gpKişiEklemePaneli.TabIndex = 3;
            this.gpKişiEklemePaneli.TabStop = false;
            this.gpKişiEklemePaneli.Text = "Kişi Ekleme Paneli";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(245, 206);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(147, 33);
            this.btnGüncelle.TabIndex = 11;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // txtKişiAra
            // 
            this.txtKişiAra.Location = new System.Drawing.Point(383, 147);
            this.txtKişiAra.Name = "txtKişiAra";
            this.txtKişiAra.Size = new System.Drawing.Size(141, 20);
            this.txtKişiAra.TabIndex = 10;
            this.txtKişiAra.TextChanged += new System.EventHandler(this.txtKişiAra_TextChanged);
            // 
            // lblKişiAra
            // 
            this.lblKişiAra.AutoSize = true;
            this.lblKişiAra.Location = new System.Drawing.Point(380, 109);
            this.lblKişiAra.Name = "lblKişiAra";
            this.lblKişiAra.Size = new System.Drawing.Size(55, 13);
            this.lblKişiAra.TabIndex = 9;
            this.lblKişiAra.Text = "KİŞİ ARA:";
            // 
            // mtxtTelefon
            // 
            this.mtxtTelefon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kisiEklemeBindingSource, "TELEFON", true));
            this.mtxtTelefon.Location = new System.Drawing.Point(147, 151);
            this.mtxtTelefon.Mask = "(999) 000-0000";
            this.mtxtTelefon.Name = "mtxtTelefon";
            this.mtxtTelefon.Size = new System.Drawing.Size(142, 20);
            this.mtxtTelefon.TabIndex = 8;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(50, 206);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(147, 34);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kisiEklemeBindingSource, "SOYAD", true));
            this.txtSoyad.Location = new System.Drawing.Point(148, 109);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(141, 20);
            this.txtSoyad.TabIndex = 5;
            // 
            // txtAD
            // 
            this.txtAD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kisiEklemeBindingSource, "AD", true));
            this.txtAD.Location = new System.Drawing.Point(148, 59);
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(142, 20);
            this.txtAD.TabIndex = 4;
            // 
            // lLYöneticiEkranı
            // 
            this.lLYöneticiEkranı.AutoSize = true;
            this.lLYöneticiEkranı.Location = new System.Drawing.Point(380, 59);
            this.lLYöneticiEkranı.Name = "lLYöneticiEkranı";
            this.lLYöneticiEkranı.Size = new System.Drawing.Size(78, 13);
            this.lLYöneticiEkranı.TabIndex = 3;
            this.lLYöneticiEkranı.TabStop = true;
            this.lLYöneticiEkranı.Text = "Yönetici Ekranı";
            this.lLYöneticiEkranı.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLYöneticiEkranı_LinkClicked);
            // 
            // lblTELEFON
            // 
            this.lblTELEFON.AutoSize = true;
            this.lblTELEFON.Location = new System.Drawing.Point(47, 154);
            this.lblTELEFON.Name = "lblTELEFON";
            this.lblTELEFON.Size = new System.Drawing.Size(62, 13);
            this.lblTELEFON.TabIndex = 2;
            this.lblTELEFON.Text = "TELEFON :";
            // 
            // lblSOYAD
            // 
            this.lblSOYAD.AutoSize = true;
            this.lblSOYAD.Location = new System.Drawing.Point(47, 109);
            this.lblSOYAD.Name = "lblSOYAD";
            this.lblSOYAD.Size = new System.Drawing.Size(50, 13);
            this.lblSOYAD.TabIndex = 1;
            this.lblSOYAD.Text = "SOYAD :";
            // 
            // lblAD
            // 
            this.lblAD.AutoSize = true;
            this.lblAD.Location = new System.Drawing.Point(47, 62);
            this.lblAD.Name = "lblAD";
            this.lblAD.Size = new System.Drawing.Size(28, 13);
            this.lblAD.TabIndex = 0;
            this.lblAD.Text = "AD :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kisiIDDataGridViewTextBoxColumn,
            this.aDDataGridViewTextBoxColumn,
            this.sOYADDataGridViewTextBoxColumn,
            this.tELEFONDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.kisiEklemeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(80, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // denemeDataSet
            // 
            this.denemeDataSet.DataSetName = "DenemeDataSet";
            this.denemeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kisiEklemeBindingSource
            // 
            this.kisiEklemeBindingSource.DataMember = "KisiEkleme";
            this.kisiEklemeBindingSource.DataSource = this.denemeDataSet;
            // 
            // kisiEklemeTableAdapter
            // 
            this.kisiEklemeTableAdapter.ClearBeforeFill = true;
            // 
            // kisiIDDataGridViewTextBoxColumn
            // 
            this.kisiIDDataGridViewTextBoxColumn.DataPropertyName = "KisiID";
            this.kisiIDDataGridViewTextBoxColumn.HeaderText = "KisiID";
            this.kisiIDDataGridViewTextBoxColumn.Name = "kisiIDDataGridViewTextBoxColumn";
            this.kisiIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDDataGridViewTextBoxColumn
            // 
            this.aDDataGridViewTextBoxColumn.DataPropertyName = "AD";
            this.aDDataGridViewTextBoxColumn.HeaderText = "AD";
            this.aDDataGridViewTextBoxColumn.Name = "aDDataGridViewTextBoxColumn";
            // 
            // sOYADDataGridViewTextBoxColumn
            // 
            this.sOYADDataGridViewTextBoxColumn.DataPropertyName = "SOYAD";
            this.sOYADDataGridViewTextBoxColumn.HeaderText = "SOYAD";
            this.sOYADDataGridViewTextBoxColumn.Name = "sOYADDataGridViewTextBoxColumn";
            // 
            // tELEFONDataGridViewTextBoxColumn
            // 
            this.tELEFONDataGridViewTextBoxColumn.DataPropertyName = "TELEFON";
            this.tELEFONDataGridViewTextBoxColumn.HeaderText = "TELEFON";
            this.tELEFONDataGridViewTextBoxColumn.Name = "tELEFONDataGridViewTextBoxColumn";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adresEkleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // adresEkleToolStripMenuItem
            // 
            this.adresEkleToolStripMenuItem.Name = "adresEkleToolStripMenuItem";
            this.adresEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adresEkleToolStripMenuItem.Text = "Adres Ekle";
            this.adresEkleToolStripMenuItem.Click += new System.EventHandler(this.adresEkleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // KisiEkleme2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gpKişiEklemePaneli);
            this.Name = "KisiEkleme2";
            this.Text = "KisiEkleme2";
            this.Load += new System.EventHandler(this.KisiEkleme2_Load);
            this.gpKişiEklemePaneli.ResumeLayout(false);
            this.gpKişiEklemePaneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisiEklemeBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpKişiEklemePaneli;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.TextBox txtKişiAra;
        private System.Windows.Forms.Label lblKişiAra;
        private System.Windows.Forms.MaskedTextBox mtxtTelefon;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAD;
        private System.Windows.Forms.LinkLabel lLYöneticiEkranı;
        private System.Windows.Forms.Label lblTELEFON;
        private System.Windows.Forms.Label lblSOYAD;
        private System.Windows.Forms.Label lblAD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DenemeDataSet denemeDataSet;
        private System.Windows.Forms.BindingSource kisiEklemeBindingSource;
        private DenemeDataSetTableAdapters.KisiEklemeTableAdapter kisiEklemeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kisiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adresEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}