
namespace TelefonRehberiv2
{
    partial class AdresEkleme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtAdresDetay = new System.Windows.Forms.TextBox();
            this.adresEkleme2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.denemeDataSet = new TelefonRehberiv2.DenemeDataSet();
            this.txtİlçe = new System.Windows.Forms.TextBox();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.lblAdresDetay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSehir = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adresEkleme2TableAdapter = new TelefonRehberiv2.DenemeDataSetTableAdapters.AdresEkleme2TableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adresEkleme2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGüncelle);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.txtAdresDetay);
            this.groupBox1.Controls.Add(this.txtİlçe);
            this.groupBox1.Controls.Add(this.txtSehir);
            this.groupBox1.Controls.Add(this.lblAdresDetay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblSehir);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adres Ekleme Paneli";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(386, 149);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(150, 39);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(386, 95);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(150, 39);
            this.btnGüncelle.TabIndex = 7;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(386, 48);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(150, 38);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtAdresDetay
            // 
            this.txtAdresDetay.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresEkleme2BindingSource, "AdresDetay", true));
            this.txtAdresDetay.Location = new System.Drawing.Point(132, 146);
            this.txtAdresDetay.Multiline = true;
            this.txtAdresDetay.Name = "txtAdresDetay";
            this.txtAdresDetay.Size = new System.Drawing.Size(165, 46);
            this.txtAdresDetay.TabIndex = 5;
            // 
            // adresEkleme2BindingSource
            // 
            this.adresEkleme2BindingSource.DataMember = "AdresEkleme2";
            this.adresEkleme2BindingSource.DataSource = this.denemeDataSet;
            // 
            // denemeDataSet
            // 
            this.denemeDataSet.DataSetName = "DenemeDataSet";
            this.denemeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtİlçe
            // 
            this.txtİlçe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresEkleme2BindingSource, "Ilce", true));
            this.txtİlçe.Location = new System.Drawing.Point(132, 91);
            this.txtİlçe.Name = "txtİlçe";
            this.txtİlçe.Size = new System.Drawing.Size(165, 20);
            this.txtİlçe.TabIndex = 4;
            // 
            // txtSehir
            // 
            this.txtSehir.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresEkleme2BindingSource, "Sehir", true));
            this.txtSehir.Location = new System.Drawing.Point(132, 45);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(165, 20);
            this.txtSehir.TabIndex = 3;
            // 
            // lblAdresDetay
            // 
            this.lblAdresDetay.AutoSize = true;
            this.lblAdresDetay.Location = new System.Drawing.Point(51, 149);
            this.lblAdresDetay.Name = "lblAdresDetay";
            this.lblAdresDetay.Size = new System.Drawing.Size(71, 13);
            this.lblAdresDetay.TabIndex = 2;
            this.lblAdresDetay.Text = "Adres Detay :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İlçe :";
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Location = new System.Drawing.Point(51, 48);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(37, 13);
            this.lblSehir.TabIndex = 0;
            this.lblSehir.Text = "Sehir :";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 275);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(550, 163);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sehir";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İlçe";
            this.columnHeader2.Width = 139;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Detay";
            this.columnHeader3.Width = 215;
            // 
            // adresEkleme2TableAdapter
            // 
            this.adresEkleme2TableAdapter.ClearBeforeFill = true;
            // 
            // AdresEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdresEkleme";
            this.Text = "AdresEkleme";
            this.Load += new System.EventHandler(this.AdresEkleme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adresEkleme2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtAdresDetay;
        private System.Windows.Forms.TextBox txtİlçe;
        private System.Windows.Forms.TextBox txtSehir;
        private System.Windows.Forms.Label lblAdresDetay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSehir;
        private DenemeDataSet denemeDataSet;
        private System.Windows.Forms.BindingSource adresEkleme2BindingSource;
        private DenemeDataSetTableAdapters.AdresEkleme2TableAdapter adresEkleme2TableAdapter;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}